using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;

namespace klient_UDP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void przycisk_wyslij_Click(object sender, EventArgs e)
        {
            string host = info.Text;
            int port = Convert.ToUInt16(my_port.Value);

            try
            {
                UdpClient klient = new UdpClient(host, port);
                Byte[] dane = Encoding.ASCII.GetBytes(wiadomosc.Text);
                klient.Send(dane, dane.Length);
                info.Items.Add("Wysłanie wiadomości do hosta " + host + ": " + port);
                klient.Close();
            }
            catch(Exception ex)
            {
                info.Items.Add("Błąd : Nie udało się wysłać wiadomości! ");
                MessageBox.Show(ex.ToString(), "Błąd");
            }
        }
    }
}
