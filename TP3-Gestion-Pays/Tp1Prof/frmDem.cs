using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Tp3;

namespace Tp3
{
    public partial class Form1 : Form
    {
        List<pays> lesPays = new List<pays>();

        public Form1()
        {
            InitializeComponent();
            grdPays.CellClick += grdPays_CellContentClick;
        }

        private void lstmonnaie_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtchange.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lstmonnaie.Items.Add("Euro");
            lstmonnaie.Items.Add("Livre S");
            lstmonnaie.Items.Add("FS");
            lstmonnaie.SelectedIndex = 0;
        }

        private void cmdcreer_Click(object sender, EventArgs e)
        {
            try
            {
                monnaie uneMonnaie = new monnaie(lstmonnaie.Text, Convert.ToSingle(txtchange.Text));
                pays unP = new pays(txtnom.Text, Convert.ToInt32(txthabitant.Text), uneMonnaie);
                lesPays.Add(unP);

                MessageBox.Show("Le pays a été créé");
                txtchange.Text = "";
                txtnom.Text = "";
                txthabitant.Text = "";
                lstmonnaie.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la création : " + ex.Message);
            }
        }

        private void cmdmonnaie_Click(object sender, EventArgs e)
        {
            // Affichage des pays créés dans le grid
            grdPays.Rows.Clear();
            foreach (pays unP in lesPays)
            {
                grdPays.Rows.Add(unP.getnom());
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            // Nombre d'habitants total des pays créés
            int nbhab = 0;
            foreach (pays unP in lesPays)
            {
                nbhab += unP.gethabitant();
            }
            lblInfo.Text = "Nombre total d'habitants : " + nbhab;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            // Plus grand pays (ayant le plus grand nombre d'habitants)
            if (lesPays.Count == 0)
            {
                lblInfo.Text = "Aucun pays créé.";
                return;
            }

            pays paysMax = lesPays[0];
            foreach (pays unP in lesPays)
            {
                if (unP.gethabitant() > paysMax.gethabitant())
                {
                    paysMax = unP;
                }
            }
            lblInfo.Text = "Plus grand pays : " + paysMax.getnom() + " : " + paysMax.gethabitant() + " habitants";
        }

        private void grdPays_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Affichage dans le label des caractéristiques du pays sélectionné
            if (e.RowIndex >= 0 && e.RowIndex < lesPays.Count)
            {
                pays p = lesPays[e.RowIndex];
                lblInfo.Text = p.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Affichage dans un label des pays possédant une monnaie sélectionnée
            string resultat = "";
            foreach (pays unP in lesPays)
            {
                if (unP.getsamonnaie() != null && unP.getsamonnaie().getnom().Equals(lstmonnaie.Text, StringComparison.OrdinalIgnoreCase))
                {
                    resultat += unP.getnom() + " ";
                }
            }

            if (string.IsNullOrWhiteSpace(resultat))
            {
                lblInfo.Text = "Aucun pays avec la monnaie " + lstmonnaie.Text;
            }
            else
            {
                lblInfo.Text = "Pays possédant la monnaie " + lstmonnaie.Text + " : " + resultat;
            }
        }
    }
}