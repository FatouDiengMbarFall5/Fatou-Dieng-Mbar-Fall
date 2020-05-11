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
    public partial class FormInscription : Form
    {
        private GescomServiceEntity service = new GescomServiceEntity();

        public FormInscription()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void txtPrenom_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void txtLogin_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FormInscription_Load(object sender, EventArgs e)
        {
            service.ListerUser(dtgvUser);
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            Utilisateur user = new Utilisateur()
            {

                Login =txtLogin.Text,
                Pwd=txtPwd.Text,
                Nom=txtNom.Text,
                Prenom=txtPrenom.Text,
                Profil=cboProfil.SelectedItem.ToString()
            };
            MessageBox.Show("Un Utilisateur Ajouté ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            service.CreerUser(user);
            service.ListerUser(dtgvUser);
        
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtLogin.Clear();
            txtPwd.Clear();
            txtNom.Clear();
            txtPrenom.Clear();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMenu ss = new FormMenu();
            ss.Show();
        }
    }
}
