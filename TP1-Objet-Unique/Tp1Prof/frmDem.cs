using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using tp1dll;


namespace Tp1Prof
{
    public partial class Form1 : Form
    {
        // Déclaration d'un objet pays
        pays unpays;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Chargement des cbo Continent & Monnaie
            cboContinent.Items.Add("Europe");
            cboContinent.Items.Add("Amérique");
            cboMonnaie.Items.Add("euro");
            cboMonnaie.Items.Add("dollar");

        }

        private void cmdcreer_Click(object sender, EventArgs e)
        {
            // Création d'un objet pays
            unpays = new pays(txtnom.Text,cboContinent.Text,Convert.ToInt32(txthabitant.Text),Convert.ToSingle (txtsuperficie.Text),cboMonnaie.Text);

            MessageBox.Show("Le pays a été créé");
        }

        private void cmdcaract_Click(object sender, EventArgs e)
        {
            // Affichage des caractéristiques du pays dans le label lblCaract
            lblCaract.Text = "nom " + unpays.getnom() + "\n nb hab "  + unpays.gethabitant() + "superficie " + unpays.getsuperficie() + "continent " + unpays.getcontinent() + "monnaie " + unpays.getmonnaie();


        }

        private void cmdsuperfhab_Click(object sender, EventArgs e)
        {
            // Affichage de la superficie par habitant dans le label lblCaract
            lblCaract.Text = "";
            lblCaract.Text = "superficie par habitant" + unpays.supefhab();

        }

        private void cmdnbhab_Click(object sender, EventArgs e)
        {
            // Modification du nb d'habitants du pays
            unpays.sethabitant(Convert.ToInt32 (txthabitant.Text));

            MessageBox.Show("Modification effectuée.");
        }

        private void cmdmonnaie_Click(object sender, EventArgs e)
        {
            // Modification de la monnaie du pays
            unpays.setmonnaie(cboMonnaie.Text);

            MessageBox.Show("Modification effectuée.");
        }

    }
}

