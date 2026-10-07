

namespace Tp1Prof
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.Label7 = new System.Windows.Forms.Label();
            this.txtchange = new System.Windows.Forms.TextBox();
            this.cmdmonnaie = new System.Windows.Forms.Button();
            this.lblCaract = new System.Windows.Forms.Label();
            this.cmdcaract = new System.Windows.Forms.Button();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.cboContinent = new System.Windows.Forms.ComboBox();
            this.cboMonnaie = new System.Windows.Forms.ComboBox();
            this.txtsuperficie = new System.Windows.Forms.TextBox();
            this.txthabitant = new System.Windows.Forms.TextBox();
            this.txtnom = new System.Windows.Forms.TextBox();
            this.cmdcreer = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Location = new System.Drawing.Point(274, 171);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(94, 13);
            this.Label7.TabIndex = 35;
            this.Label7.Text = "Taux de change : ";
            // 
            // txtchange
            // 
            this.txtchange.Location = new System.Drawing.Point(374, 169);
            this.txtchange.Name = "txtchange";
            this.txtchange.Size = new System.Drawing.Size(54, 20);
            this.txtchange.TabIndex = 34;
            // 
            // cmdmonnaie
            // 
            this.cmdmonnaie.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdmonnaie.Location = new System.Drawing.Point(140, 262);
            this.cmdmonnaie.Name = "cmdmonnaie";
            this.cmdmonnaie.Size = new System.Drawing.Size(108, 40);
            this.cmdmonnaie.TabIndex = 33;
            this.cmdmonnaie.Text = "Modification de la monnaie";
            this.cmdmonnaie.UseVisualStyleBackColor = true;
            this.cmdmonnaie.Click += new System.EventHandler(this.cmdmonnaie_Click);
            // 
            // lblCaract
            // 
            this.lblCaract.AutoSize = true;
            this.lblCaract.Location = new System.Drawing.Point(282, 213);
            this.lblCaract.Name = "lblCaract";
            this.lblCaract.Size = new System.Drawing.Size(0, 13);
            this.lblCaract.TabIndex = 32;
            // 
            // cmdcaract
            // 
            this.cmdcaract.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdcaract.Location = new System.Drawing.Point(140, 206);
            this.cmdcaract.Name = "cmdcaract";
            this.cmdcaract.Size = new System.Drawing.Size(108, 40);
            this.cmdcaract.TabIndex = 31;
            this.cmdcaract.Text = "Caractéristiques du pays";
            this.cmdcaract.UseVisualStyleBackColor = true;
            this.cmdcaract.Click += new System.EventHandler(this.cmdcaract_Click);
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(361, 61);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(57, 13);
            this.Label6.TabIndex = 30;
            this.Label6.Text = "Monnaie : ";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(34, 169);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(61, 13);
            this.Label5.TabIndex = 29;
            this.Label5.Text = "Continent : ";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(73, 128);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(63, 13);
            this.Label4.TabIndex = 28;
            this.Label4.Text = "Superficie : ";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(73, 85);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(84, 13);
            this.Label3.TabIndex = 27;
            this.Label3.Text = "Nb d\'habitants : ";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(73, 46);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(38, 13);
            this.Label2.TabIndex = 26;
            this.Label2.Text = "Nom : ";
            // 
            // cboContinent
            // 
            this.cboContinent.FormattingEnabled = true;
            this.cboContinent.Location = new System.Drawing.Point(4, 195);
            this.cboContinent.Name = "cboContinent";
            this.cboContinent.Size = new System.Drawing.Size(106, 21);
            this.cboContinent.TabIndex = 25;
            // 
            // cboMonnaie
            // 
            this.cboMonnaie.FormattingEnabled = true;
            this.cboMonnaie.Location = new System.Drawing.Point(364, 85);
            this.cboMonnaie.Name = "cboMonnaie";
            this.cboMonnaie.Size = new System.Drawing.Size(84, 21);
            this.cboMonnaie.TabIndex = 24;
            // 
            // txtsuperficie
            // 
            this.txtsuperficie.Location = new System.Drawing.Point(160, 124);
            this.txtsuperficie.Name = "txtsuperficie";
            this.txtsuperficie.Size = new System.Drawing.Size(55, 20);
            this.txtsuperficie.TabIndex = 23;
            // 
            // txthabitant
            // 
            this.txthabitant.Location = new System.Drawing.Point(160, 83);
            this.txthabitant.Name = "txthabitant";
            this.txthabitant.Size = new System.Drawing.Size(55, 20);
            this.txthabitant.TabIndex = 22;
            // 
            // txtnom
            // 
            this.txtnom.Location = new System.Drawing.Point(160, 44);
            this.txtnom.Name = "txtnom";
            this.txtnom.Size = new System.Drawing.Size(100, 20);
            this.txtnom.TabIndex = 21;
            // 
            // cmdcreer
            // 
            this.cmdcreer.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdcreer.Location = new System.Drawing.Point(140, 163);
            this.cmdcreer.Name = "cmdcreer";
            this.cmdcreer.Size = new System.Drawing.Size(99, 25);
            this.cmdcreer.TabIndex = 20;
            this.cmdcreer.Text = "Créer le pays";
            this.cmdcreer.UseVisualStyleBackColor = true;
            this.cmdcreer.Click += new System.EventHandler(this.cmdcreer_Click);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Label1.Location = new System.Drawing.Point(228, 11);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(83, 19);
            this.Label1.TabIndex = 19;
            this.Label1.Text = "Mon pays";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 321);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.txtchange);
            this.Controls.Add(this.cmdmonnaie);
            this.Controls.Add(this.lblCaract);
            this.Controls.Add(this.cmdcaract);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.cboContinent);
            this.Controls.Add(this.cboMonnaie);
            this.Controls.Add(this.txtsuperficie);
            this.Controls.Add(this.txthabitant);
            this.Controls.Add(this.txtnom);
            this.Controls.Add(this.cmdcreer);
            this.Controls.Add(this.Label1);
            this.Name = "Form1";
            this.Text = "Demarrage";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.TextBox txtchange;
        internal System.Windows.Forms.Button cmdmonnaie;
        internal System.Windows.Forms.Label lblCaract;
        internal System.Windows.Forms.Button cmdcaract;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.ComboBox cboContinent;
        internal System.Windows.Forms.ComboBox cboMonnaie;
        internal System.Windows.Forms.TextBox txtsuperficie;
        internal System.Windows.Forms.TextBox txthabitant;
        internal System.Windows.Forms.TextBox txtnom;
        internal System.Windows.Forms.Button cmdcreer;
        internal System.Windows.Forms.Label Label1;


    }
}

