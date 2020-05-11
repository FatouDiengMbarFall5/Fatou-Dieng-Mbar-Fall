using GestionCommercial.entity;
using GestionCommercial.services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionCommercial
{
    public partial class FormCommande : Form
    {
        private GescomServiceEntity service = new GescomServiceEntity();

        public FormCommande()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            Client clt = new Client()
            {

                Nom = txtnom.Text,
                Prenom = txtprenom.Text,
                Telephone = txttelephone.Text,
                Adresse = txtadresse.Text,

            };
            MessageBox.Show("Un Client Ajouté ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            service.CreerClient(clt);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click_2(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormCommande_Load(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMenu ss = new FormMenu();
            ss.Show();
        }
    }
}
