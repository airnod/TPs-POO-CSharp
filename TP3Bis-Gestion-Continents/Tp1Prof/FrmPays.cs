using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using tp3bisdll;

namespace Tp3Eleve
{
    public partial class FrmPays : Form
    {
        public FrmPays()
        {
            InitializeComponent();
        }

        pays unpays;

        private void FrmPays_Load(object sender, EventArgs e)
        {
            lstrpays.Items.Clear();
            if (varglobale.unContinent != null && varglobale.unContinent.getlespays() != null)
            {
                foreach (pays p in varglobale.unContinent.getlespays())
                {
                    lstrpays.Items.Add(p.getnom());
                }
            }

            lstmonnaie.Items.Clear();
            lstmonnaie.Items.Add("euro");
            lstmonnaie.Items.Add("dollar");
            lstmonnaie.Items.Add("livre s");
            lstmonnaie.Items.Add("fs");
            lstmonnaie.SelectedIndex = 0;
        }

        private void lstrpays_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstrpays.SelectedIndex >= 0 && varglobale.unContinent != null && lstrpays.SelectedIndex < varglobale.unContinent.getlespays().Count)
            {
                unpays = varglobale.unContinent.getlespays()[lstrpays.SelectedIndex];
                txtnom.Text = unpays.getnom();
                txthabitant.Text = unpays.gethabitant().ToString();
                txtsuperficie.Text = unpays.getsuperficie().ToString();
                if (unpays.getmonnaie() != null)
                {
                    lstmonnaie.Text = unpays.getmonnaie().getnom();
                    txtchange.Text = unpays.getmonnaie().getchange().ToString();
                }
            }
        }

        private void cmdcreer_Click(object sender, EventArgs e)
        {
            try
            {
                if (varglobale.unContinent == null)
                {
                    MessageBox.Show("Veuillez d'abord créer un continent.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtnom.Text))
                {
                    MessageBox.Show("Veuillez saisir un nom de pays.");
                    return;
                }

                monnaie m = new monnaie(lstmonnaie.Text, Convert.ToSingle(txtchange.Text));
                unpays = new pays(txtnom.Text, Convert.ToInt32(txthabitant.Text), Convert.ToSingle(txtsuperficie.Text), m);
                
                varglobale.unContinent.getlespays().Add(unpays);
                lstrpays.Items.Add(unpays.getnom());

                MessageBox.Show("Le pays a été ajouté au continent.");
                txtnom.Clear();
                txthabitant.Clear();
                txtsuperficie.Clear();
                txtchange.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la création : " + ex.Message);
            }
        }

        private void cmdmonnaie_Click(object sender, EventArgs e)
        {
            try
            {
                if (lstrpays.SelectedIndex >= 0 && varglobale.unContinent != null && lstrpays.SelectedIndex < varglobale.unContinent.getlespays().Count)
                {
                    unpays = varglobale.unContinent.getlespays()[lstrpays.SelectedIndex];
                    unpays.setnom(txtnom.Text);
                    unpays.sethabitant(Convert.ToInt32(txthabitant.Text));
                    unpays.setsuperficie(Convert.ToSingle(txtsuperficie.Text));
                    if (unpays.getmonnaie() != null)
                    {
                        unpays.getmonnaie().setnom(lstmonnaie.Text);
                        unpays.getmonnaie().setchange(Convert.ToSingle(txtchange.Text));
                    }

                    int idx = lstrpays.SelectedIndex;
                    lstrpays.Items[idx] = unpays.getnom();
                    MessageBox.Show("Pays modifié avec succès.");
                }
                else
                {
                    MessageBox.Show("Veuillez sélectionner un pays à modifier.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la modification : " + ex.Message);
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
