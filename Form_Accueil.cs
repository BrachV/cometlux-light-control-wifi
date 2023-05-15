using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Net;
using System.Reflection;
using System.Windows.Forms;

namespace LightControlWifi
{
    public partial class Form_Accueil : Form
    {

        C_ESP32 esp32 = new C_ESP32();
        Dictionary<int, int> indexComboboxVersId = new Dictionary<int, int>();
        private int index = -1;

        public Form_Accueil()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e){}

        private void button1_Click_1(object sender, EventArgs e)
        {
            // si aucun projecteur n'est sélectionné
            if (index == -1)
            {
                MessageBox.Show("Merci de sélectionner un projecteur.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // si tous les projecteurs sont choisis
            if (index == 0) esp32.Allumer(index, indexComboboxVersId[index]);
            // sinon (un seul projecteur)
            else
            {
                esp32.Allumer(index, indexComboboxVersId[index]);
                esp32.Logs(indexComboboxVersId[index], description: "La lampe est à présent allumé.");
            }
        }

        private void bEteindre_Click(object sender, EventArgs e)
        {
            if (index == -1)
            {
                MessageBox.Show("Merci de sélectionner un projecteur.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // si tous les projecteurs sont choisis
            if (index == 0) esp32.Eteindre(index, indexComboboxVersId[index]);
            // sinon (un seul projecteur)
            else
            {
                esp32.Eteindre(index, indexComboboxVersId[index]);
                esp32.Logs(indexComboboxVersId[index], description: "La lampe est à présent allumé.");
            }
        }

        private void bAppliquer_Click(object sender, EventArgs e)
        {
            if (index == -1)
            {
                MessageBox.Show("Merci de sélectionner un projecteur.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int puissance = track_puissanceEclairage.Value;
            float pourcentage = (float)(Math.Floor(((float)(puissance) / 255) * 100));

            // si tous les projecteurs sont choisis
            if (index == 0) esp32.ChangerLuminosite(puissance, index, indexComboboxVersId[index]);
            // sinon (un seul projecteur)
            else
            {
                esp32.ChangerLuminosite(puissance, index, indexComboboxVersId[index]);
                esp32.Logs(idLampe: indexComboboxVersId[index], description: $"Luminosité modifiée, nouvelle valeur : {pourcentage}%");
            }
        }


        private void comboBox_projecteurs_SelectedIndexChanged(object sender, EventArgs e)
        {
            index = comboBox_projecteurs.SelectedIndex;
        }

        private void Form_Accueil_Load(object sender, EventArgs e)
        {
            // importe 
            comboBox_projecteurs.Items.Add("Tous les projecteurs");
            indexComboboxVersId.Add(0, 0);

            DataTable donnes = esp32.recupDonnesDb();
            if (donnes == null)
            {
                MessageBox.Show("Impossible de communiquer avec le serveur.");
                this.Close();
                return;
            }
            int index = 1;
            foreach (DataRow row in donnes.Rows)
            {
                comboBox_projecteurs.Items.Add(row["nom"]);
                indexComboboxVersId.Add(index, Int32.Parse($"{row["id"]}"));
                index++;
            }
        }

        private void label2_Click(object sender, EventArgs e){}
        private void pictureBox1_Click_1(object sender, EventArgs e){}
        private void track_puissanceEclairage_Scroll(object sender, EventArgs e) { }
        private void imageOff_Click(object sender, EventArgs e) { }
        private void pictureBox1_Click(object sender, EventArgs e) { }


    }
}
