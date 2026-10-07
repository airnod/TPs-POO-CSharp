using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using tp3bisdll;

namespace Tp3Eleve
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtnom.Focus();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            // Créer un continent
            if (string.IsNullOrWhiteSpace(txtnom.Text))
            {
                MessageBox.Show("Veuillez renseigner un nom de continent.");
                return;
            }
            varglobale.unContinent = new continent(txtnom.Text);
            Label7.Text = varglobale.unContinent.getnom();
            MessageBox.Show("Le continent " + txtnom.Text + " a été créé.");
        }

        private void cmdcreer_Click(object sender, EventArgs e)
        {
            // Ajouter - Modifier un pays (ouverture de FrmPays)
            if (varglobale.unContinent == null)
            {
                MessageBox.Show("Veuillez d'abord créer un continent avant d'y ajouter des pays.");
                return;
            }
            FrmPays frm = new FrmPays();
            frm.ShowDialog();

            // Rafraîchir l'affichage après fermeture
            Button2_Click(sender, e);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            // Liste des pays dans le grid
            grd.Rows.Clear();
            if (varglobale.unContinent != null && varglobale.unContinent.getlespays() != null)
            {
                foreach (pays unP in varglobale.unContinent.getlespays())
                {
                    grd.Rows.Add(unP.getnom() + " - " + unP.getmonnaie().getnom() + " (" + unP.gethabitant() + " hab)");
                }
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            // Nombre d'habitants du continent
            if (varglobale.unContinent == null)
            {
                MessageBox.Show("Veuillez d'abord créer un continent.");
                return;
            }
            Label6.Text = "Nb hab dans " + varglobale.unContinent.getnom() + " : " + varglobale.unContinent.nbHabitants();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            // Superficie du continent
            if (varglobale.unContinent == null)
            {
                MessageBox.Show("Veuillez d'abord créer un continent.");
                return;
            }
            Label6.Text = "Superficie de " + varglobale.unContinent.getnom() + " : " + varglobale.unContinent.superficieTotale();
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            // Nombre d'habitants moyen par pays
            if (varglobale.unContinent == null)
            {
                MessageBox.Show("Veuillez d'abord créer un continent.");
                return;
            }
            Label6.Text = "Nb d'hab moyen par pays dans " + varglobale.unContinent.getnom() + " : " + varglobale.unContinent.nbHabitantsMoyen();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            // Plus grand pays du continent
            if (varglobale.unContinent == null)
            {
                MessageBox.Show("Veuillez d'abord créer un continent.");
                return;
            }
            pays pg = varglobale.unContinent.plusgrandPays();
            if (pg != null)
            {
                Label6.Text = "Plus grand pays : " + pg.getnom() + " (" + pg.gethabitant() + " hab)";
            }
            else
            {
                Label6.Text = "Aucun pays enregistré.";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Rechercher un pays
            if (varglobale.unContinent == null)
            {
                MessageBox.Show("Veuillez d'abord créer un continent.");
                return;
            }
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Veuillez saisir un nom de pays à rechercher.");
                return;
            }

            pays p = varglobale.unContinent.rechpays(textBox1.Text);
            if (p != null)
            {
                Label6.Text = p.ToString();
            }
            else
            {
                Label6.Text = "INCONNU";
            }
        }

        private void grd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}
