using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Net.NetworkInformation;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public string ip = "http://192.168.0.14";

        public Form1()
        {
            InitializeComponent();
            checkServeurConnection();
        }


private void turnOn_Click(object sender, EventArgs e)
{
    checkServeurConnection(); // est-ce qu'on peut communiquer avec la carte esp32
    string url = ip + "/H"; // ajoute derrière l'adresse ip la requête /H

    var request = WebRequest.Create(url); // crée une requête HTTP
    request.Method = "GET"; // méthode GET

    var webResponse = request.GetResponse(); // attend une réponse
    var webStream = webResponse.GetResponseStream();

    var reader = new StreamReader(webStream);
    var data = reader.ReadToEnd(); // bilan de la requête
}

        private void turnOff_Click(object sender, EventArgs e)
        {
            checkServeurConnection();
            string url = ip + "/L";

            var request = WebRequest.Create(url);
            request.Method = "GET";

            var webResponse = request.GetResponse();
            var webStream = webResponse.GetResponseStream();

            var reader = new StreamReader(webStream);
            var data = reader.ReadToEnd();

        }

        private void trackLuminosite_Scroll(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_Apply_Click(object sender, EventArgs e)
        {
            checkServeurConnection();
            string url = ip + "/P?" + trackLuminosite.Value;

            var request = WebRequest.Create(url);
            request.Method = "POST";

            var webResponse = request.GetResponse();
            var webStream = webResponse.GetResponseStream();

            var reader = new StreamReader(webStream);
            var data = reader.ReadToEnd();
        }

        private void checkServeurConnection()
        {
 
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
