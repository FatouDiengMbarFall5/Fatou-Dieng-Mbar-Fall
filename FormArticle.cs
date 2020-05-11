
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
    public partial class FormArticle : Form
    {
        private GescomServiceEntity service = new GescomServiceEntity();
        public FormArticle()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormArticle_Load(object sender, EventArgs e)
        {
            service.ListerArticle(dtgvArticle);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            Article article = new Article()
            {
                Reference = textReference.Text,
                Libelle = textLibelle.Text,
                Stock= float.Parse(textStock.Text),
                Prix = float.Parse(textPrix.Text),
                Categorie = cboCategorie.SelectedItem.ToString()

            };
            MessageBox.Show("Un Article Ajouté ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            service.CreerArticle(article);
            service.ListerArticle(dtgvArticle);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textReference.Clear();
            textLibelle.Clear();
            textStock.Clear();
            textPrix.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMenu ss = new FormMenu();
            ss.Show();
        }
    }
}
