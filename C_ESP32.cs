using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Net;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Windows.Forms;

namespace LightControlWifi
{
    internal class C_ESP32
    {
        #region définition des variables

        public string ip = ConfigurationManager.AppSettings["esp32-ip"];
        //C_SQL bdd = new C_SQL(ConfigurationManager.AppSettings["host"], ConfigurationManager.AppSettings["user"], ConfigurationManager.AppSettings["mdp"], ConfigurationManager.AppSettings["database"], ConfigurationManager.AppSettings["port"]);
        DataTable data = new DataTable();

        #endregion fin de définition des variables

        // --------------------- [constructeur] ----------------------

        public C_ESP32() { }

        public void Allumer(int index, int id)
        {
            // vérifie si le logiciel peut communiquer avec la carte esp32
            bool connecte = VerificationConnexionServeur();
            if (connecte == false)
            {
                MessageBox.Show("Impossible de communiquer avec la carte Wifi", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // définition de variable jetable
            string requete;
            DataTable dt;
            DataTableReader dr;

            // si la modification conçerne l'ensemble des projecteurs wifi
            // récupère la luminosité stockée en db, change l'état d'éteint vers allumé et modifie la luminosité de la lampe (vers celle enregistrée)
            if (index == 0)
            {
                int temp = 1;
                requete = "SELECT * FROM `lampe` WHERE type = 'WIFI';";
                //DataTable projecteurs;
                //foreach (DataRow row in projecteurs.Rows)
                //{
                //    // modifie l'état de la lampe sur la carte arduino
                //    RequeteHttp($"http://{ip}/P?lum={row["luminosite"]}&id={temp}");

                //    // crée un logs pour cette modification
                //    Logs(idLampe: Int32.Parse($"{row["id"]}"), description: "La lampe est à présent allumé.");
                //    temp++;
                //}

                // modifie la base de données
                requete = $"UPDATE lampe SET etat = '1' WHERE `type` = 'WIFI'";
                //bdd.exec_commande(requete);

                // arrête la fonction ici
                return;
            }

            // récupère la luminosité stocké dans la base de données
            requete = $"SELECT `luminosite` FROM `lampe` WHERE `id` = '{id}';";
            //dt = bdd.exec_commande(requete);
            //dr = dt.CreateDataReader();

            // lecture de la première ligne récupérée
            ////dr.Read();
            //int luminosite = (int)dr["luminosite"];

            //// modifie l'état de la lampe sur la carte arduino
            //RequeteHttp($"http://{ip}/P?lum={luminosite}&id={index}");

            //// modifie l'état dans la base de données
            //requete = $"UPDATE lampe SET etat = '1' WHERE id = '{id}';";
            ////bdd.exec_commande(requete);
        }

        public void Eteindre(int index, int id)
        {
            // vérifie si le logiciel peut communiquer avec la carte esp32
            bool connecte = VerificationConnexionServeur();
            if (connecte == false)
            {
                MessageBox.Show("Impossible de communiquer avec la carte Wifi", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // définition de variable jetable
            string requete;

            // si la modification conçerne l'ensemble des projecteurs wifi
            // récupère la change l'état d'allumé vers éteint et modifie la luminosité de la lampe (vers 0)
            if (index == 0)
            {
                int temp = 1;
                DataTable projecteurs = recupDonnesDb();
                foreach (DataRow row in projecteurs.Rows)
                {
                    // modifie l'état de la lampe sur la carte arduino
                    RequeteHttp($"http://{ip}/P?lum=0&id={temp}");

                    // crée un logs pour cette modification
                    Logs(idLampe: Int32.Parse($"{row["id"]}"), description: "La lampe est à présent éteinte.");
                    temp++;
                }

                // modifie la base de données
                requete = $"UPDATE lampe SET etat = '0' WHERE type = 'WIFI'";
                //bdd.exec_commande(requete);

                // arrête la fonction ici
                return;
            }

            // modifie l'état de la lampe sur la carte arduino
            RequeteHttp($"http://{ip}/P?lum=0&id={index}");

            // modifie l'état dans la base de données
            requete = $"UPDATE lampe SET etat = '0' WHERE id = '{id}';";
            //bdd.exec_commande(requete);
        }
        public void ChangerLuminosite(int puissance, int index, int id)
        {
            // vérifie si le logiciel peut communiquer avec la carte esp32
            bool connecte = VerificationConnexionServeur();
            if (connecte == false)
            {
                MessageBox.Show("Impossible de communiquer avec la carte Wifi", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // définition de variable jetable
            string requete;

            // si la modification conçerne l'ensemble des projecteurs wifi
            // change la luminosité de la lampe dans la base de données et sur la carte esp32
            if (index == 0)
            {
                float pourcentage = (float)(Math.Floor(((float)(puissance) / 255) * 100));
                int temp = 1;
                DataTable projecteurs = recupDonnesDb();
                foreach (DataRow row in projecteurs.Rows)
                {
                    // modifie l'état de la lampe sur la carte arduino
                    RequeteHttp($"http://{ip}/P?lum={puissance}&id={temp}");

                    // crée un logs pour cette modification
                    Logs(idLampe: Int32.Parse($"{row["id"]}"), description: $"Luminosité modifiée, nouvelle valeur : {pourcentage}%");
                    temp++;
                }

                // modifie la base de données
                requete = $"UPDATE lampe SET luminosite = '{puissance}' WHERE type = 'WIFI'";
                //bdd.exec_commande(requete);

                // arrête la fonction ici
                return;
            }

            // modifie la luminosité de la lampe sur la carte arduino
            RequeteHttp($"http://{ip}/P?lum={puissance}&id={index}");

            // modifie la luminosité dans la base de données
            requete = $"UPDATE lampe SET luminosite = '{puissance}' WHERE id = '{id}';";
            //bdd.exec_commande(requete);
        }
        public void Logs(int idLampe, string description)
        {
            //bdd.exec_commande($"INSERT INTO logs(`lampe_id`, `description`, `source`) VALUES ('{idLampe}','{description}','Application Logiciel');");
        }

        // vérifie si il est possible de communiquer avec la carte esp32
        public bool VerificationConnexionServeur()
        {
            Ping ping = new Ping();
            PingReply reply = ping.Send(ip);

            if (reply.Status == IPStatus.Success)
                return true;
            else
                return false;
        }

        // récupère les données de tous les projecteurs WIFI de la base de données
        public DataTable recupDonnesDb()
        {
            string requete = $"SELECT * FROM `lampe` WHERE type = 'WIFI';";
            DataTable dt = new DataTable();

            return dt;
        }

        private void RequeteHttp(string url)
        {
            WebRequest request = WebRequest.Create(url);
            request.Method = "POST";

            var webResponse = request.GetResponse();
            //var webStream = webResponse.GetResponseStream();
            //var reader = new StreamReader(webStream);
            //var data = reader.ReadToEnd();
        }

        public Dictionary<int, int> RecupOrdreProjecteurs()
        {
            Dictionary<int, int> listes = new Dictionary<int, int>();

            DataTable donnes = recupDonnesDb();
            int index = 1;
            foreach (DataRow row in donnes.Rows)
            {
                listes.Add(Int32.Parse($"{row["id"]}"), index);
                index++;
            }

            return listes;
        }
    }
}
