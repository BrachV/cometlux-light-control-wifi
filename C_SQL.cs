using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace LightControlWifi
{
    public class C_SQL
    {
        string user, pass, serveur, sql_base, sql_port;

        static DataSet ds;
        static MySqlConnection cn;
        static MySqlCommand cmd;
        static MySqlDataAdapter da;
        static MySqlCommandBuilder combuilder;

        public C_SQL()
        {
            serveur = "172.0.0.1";
            user = "root";
            pass = "root";
            sql_base = "basedefaut";
        }
        public C_SQL(string s, string u, string p, string b, string p2)
        {
            serveur = s;
            user = u;
            pass = p;
            sql_base = b;
            sql_port = p2;
        }

        public C_SQL(string s, string u, string p, string b)
        {
            serveur = s;
            user = u;
            pass = p;
            sql_base = b;
        }

        public void set_serveur(string v1) { serveur = v1; }
        public void set_user(string v1) { user = v1; }
        public void set_pass(string v1) { pass = v1; }
        public void set_sql_base(string v1) { sql_base = v1; }
        public string get_serveur() { return serveur; }
        public string get_user() { return user; }
        public string get_pass() { return pass; }
        public string get_sql_base() { return sql_base; }

        private string con_string(bool racine)
        {
            string data;
            if (racine == true)
                data = "server=" + serveur + "; user id=" + user + "; password=" + pass + "; database=" + sql_base + "; pooling=false";
            else
                data = "server=" + serveur + "; user id=" + user + "; password=" + pass + "; database=" + sql_base + "; pooling=false" + "; port=" + sql_port;
            return data;
        }
        public bool base_existe()
        {
            try
            {
                cn = new MySqlConnection();
                cn.ConnectionString = con_string(true);
                cn.Open();
                string query = "SHOW DATABASES";
                MySqlCommand c1Command = new MySqlCommand(query, cn);
                MySqlDataReader myReader;
                myReader = c1Command.ExecuteReader();
                int i = 0;
                while (myReader.Read()) if (myReader.GetString(0) == sql_base) { i = 1; break; }
                myReader.Close();
                if (i == 0) { return false; }
                else { return true; }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connexion échouée : " + ex, "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }

        }

        public DataTable exec_commande(string requete)
        {
            try
            {

                cn = new MySqlConnection();
                cn.ConnectionString = con_string(true);
                cn.Open();
                MySqlCommand cmd = new MySqlCommand(requete, cn);
                //MySqlDataReader dr;
                //dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                //dt.Load(dr);
                using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                {
                    da.Fill(dt);
                }
                cn.Close();
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public string[,] exec_commande_lampe(string requete)
        {
            ;
            try
            {
                cn = new MySqlConnection();
                cn.ConnectionString = con_string(true);
                cn.Open();
                MySqlCommand cmd = new MySqlCommand(requete, cn);
                MySqlDataReader dr;
                dr = cmd.ExecuteReader();
                DataTable dt = exec_commande(requete);
                string[,] liste = new string[dt.Rows.Count, 4];
                int i = 0;
                while (dr.Read()) // lis les données
                {
                    liste[i, 0] = dr.GetString("id");
                    liste[i, 1] = dr.GetString("nom");
                    liste[i, 2] = dr.GetString("type");
                    liste[i, 3] = dr.GetString("id_hue");
                    i++;
                }
                cn.Close();
                return liste;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public string exec_commande(string requete, bool verif)
        {
            try
            {

                cn = new MySqlConnection();
                cn.ConnectionString = con_string(true);
                cn.Open();
                MySqlCommand cmd = new MySqlCommand(requete, cn);
                if (cmd.ExecuteScalar() == null)
                {
                    cn.Close();
                    return null;
                }
                else
                {
                    string dt = cmd.ExecuteScalar().ToString();
                    cn.Close();
                    return dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return "echec";
            }
        }
    }
}
