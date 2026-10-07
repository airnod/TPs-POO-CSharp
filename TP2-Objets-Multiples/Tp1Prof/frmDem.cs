using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using tp2dll;


namespace Tp1Prof
{
    public partial class Form1 : Form
    {
        pays unPays;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //  Chargement des 2 cbo
            cboContinent.Items.Add("Europe");
            cboContinent.Items.Add("Amérique");
            cboMonnaie.Items.Add("euro");
            cboMonnaie.Items.Add("dollar");

        }
        

        private void cmdcreer_Click(object sender, EventArgs e)
        {
            //  Création de l'objet unPays
            unPays = new pays(txtnom.Text,cboContinent.Text,Convert.ToInt32(txthabitant.Text),Convert.ToSingle(txtsuperficie.Text),
                new monnaie(cboMonnaie.Text,Convert.ToSingle(txtchange.Text)));

        }

        private void cmdcaract_Click(object sender, EventArgs e)
        {
            //  Affichage des caractéristiques de l'objet unPays dans le label lblCaract
            lblCaract.Text= "nom " + unPays.getnom() + "\n nb hab " + unPays.gethabitant() + "\nsuperficie " + unPays.getsuperficie() +
                "\ncontinent " + unPays.getcontinent() + "\nmonnaie " + unPays.getmonnaie().getnom()+ "\ntaux change " +
                unPays.getmonnaie().getchange();

        }

        private void cmdmonnaie_Click(object sender, EventArgs e)
        {
            //  Modification de la monnaie & du taux de change de l'objet unPays
            unPays.getmonnaie().setchange(Convert.ToInt32(txtchange.Text));
            unPays.getmonnaie().setnom(cboMonnaie.Text);

        }
    }
}

