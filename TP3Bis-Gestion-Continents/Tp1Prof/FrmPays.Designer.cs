namespace Tp3Eleve
{
    partial class FrmPays
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Label5 = new System.Windows.Forms.Label();
            this.lstrpays = new System.Windows.Forms.ComboBox();
            this.lblCont = new System.Windows.Forms.Label();
            this.Button1 = new System.Windows.Forms.Button();
            this.Label7 = new System.Windows.Forms.Label();
            this.txtchange = new System.Windows.Forms.TextBox();
            this.cmdmonnaie = new System.Windows.Forms.Button();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.lstmonnaie = new System.Windows.Forms.ComboBox();
            this.txtsuperficie = new System.Windows.Forms.TextBox();
            this.txthabitant = new System.Windows.Forms.TextBox();
            this.txtnom = new System.Windows.Forms.TextBox();
            this.cmdcreer = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(241, 79);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(72, 13);
            this.Label5.TabIndex = 39;
            this.Label5.Text = "Tous les pays";
            // 
            // lstrpays
            // 
            this.lstrpays.FormattingEnabled = true;
            this.lstrpays.Location = new System.Drawing.Point(234, 95);
            this.lstrpays.Name = "lstrpays";
            this.lstrpays.Size = new System.Drawing.Size(115, 21);
            this.lstrpays.TabIndex = 38;
            this.lstrpays.SelectedIndexChanged += new System.EventHandler(this.lstrpays_SelectedIndexChanged);
            // 
            // lblCont
            // 
            this.lblCont.AutoSize = true;
            this.lblCont.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCont.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblCont.Location = new System.Drawing.Point(241, 22);
            this.lblCont.Name = "lblCont";
            this.lblCont.Size = new System.Drawing.Size(0, 16);
            this.lblCont.TabIndex = 37;
            // 
            // Button1
            // 
            this.Button1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button1.Location = new System.Drawing.Point(364, 169);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(108, 40);
            this.Button1.TabIndex = 36;
            this.Button1.Text = "Retour au continent";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Location = new System.Drawing.Point(32, 247);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(94, 13);
            this.Label7.TabIndex = 35;
            this.Label7.Text = "Taux de change : ";
            // 
            // txtchange
            // 
            this.txtchange.Location = new System.Drawing.Point(132, 244);
            this.txtchange.Name = "txtchange";
            this.txtchange.Size = new System.Drawing.Size(54, 20);
            this.txtchange.TabIndex = 34;
            // 
            // cmdmonnaie
            // 
            this.cmdmonnaie.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdmonnaie.Location = new System.Drawing.Point(364, 113);
            this.cmdmonnaie.Name = "cmdmonnaie";
            this.cmdmonnaie.Size = new System.Drawing.Size(108, 40);
            this.cmdmonnaie.TabIndex = 33;
            this.cmdmonnaie.Text = "Modification du pays";
            this.cmdmonnaie.UseVisualStyleBackColor = true;
            this.cmdmonnaie.Click += new System.EventHandler(this.cmdmonnaie_Click);
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(24, 169);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(57, 13);
            this.Label6.TabIndex = 32;
            this.Label6.Text = "Monnaie : ";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(24, 136);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(63, 13);
            this.Label4.TabIndex = 31;
            this.Label4.Text = "Superficie : ";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(24, 94);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(84, 13);
            this.Label3.TabIndex = 30;
            this.Label3.Text = "Nb d\'habitants : ";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(24, 55);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(38, 13);
            this.Label2.TabIndex = 29;
            this.Label2.Text = "Nom : ";
            // 
            // lstmonnaie
            // 
            this.lstmonnaie.FormattingEnabled = true;
            this.lstmonnaie.Location = new System.Drawing.Point(111, 169);
            this.lstmonnaie.Name = "lstmonnaie";
            this.lstmonnaie.Size = new System.Drawing.Size(84, 21);
            this.lstmonnaie.TabIndex = 28;
            // 
            // txtsuperficie
            // 
            this.txtsuperficie.Location = new System.Drawing.Point(111, 133);
            this.txtsuperficie.Name = "txtsuperficie";
            this.txtsuperficie.Size = new System.Drawing.Size(55, 20);
            this.txtsuperficie.TabIndex = 27;
            // 
            // txthabitant
            // 
            this.txthabitant.Location = new System.Drawing.Point(111, 91);
            this.txthabitant.Name = "txthabitant";
            this.txthabitant.Size = new System.Drawing.Size(55, 20);
            this.txthabitant.TabIndex = 26;
            // 
            // txtnom
            // 
            this.txtnom.Location = new System.Drawing.Point(111, 52);
            this.txtnom.Name = "txtnom";
            this.txtnom.Size = new System.Drawing.Size(100, 20);
            this.txtnom.TabIndex = 25;
            // 
            // cmdcreer
            // 
            this.cmdcreer.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdcreer.Location = new System.Drawing.Point(364, 49);
            this.cmdcreer.Name = "cmdcreer";
            this.cmdcreer.Size = new System.Drawing.Size(108, 25);
            this.cmdcreer.TabIndex = 24;
            this.cmdcreer.Text = "Créer le pays";
            this.cmdcreer.UseVisualStyleBackColor = true;
            this.cmdcreer.Click += new System.EventHandler(this.cmdcreer_Click);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Label1.Location = new System.Drawing.Point(127, 20);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(83, 19);
            this.Label1.TabIndex = 23;
            this.Label1.Text = "Mon pays";
            // 
            // FrmPays
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 310);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.lstrpays);
            this.Controls.Add(this.lblCont);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.txtchange);
            this.Controls.Add(this.cmdmonnaie);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.lstmonnaie);
            this.Controls.Add(this.txtsuperficie);
            this.Controls.Add(this.txthabitant);
            this.Controls.Add(this.txtnom);
            this.Controls.Add(this.cmdcreer);
            this.Controls.Add(this.Label1);
            this.Name = "FrmPays";
            this.Text = "FrmPays";
            this.Load += new System.EventHandler(this.FrmPays_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.ComboBox lstrpays;
        internal System.Windows.Forms.Label lblCont;
        internal System.Windows.Forms.Button Button1;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.TextBox txtchange;
        internal System.Windows.Forms.Button cmdmonnaie;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.ComboBox lstmonnaie;
        internal System.Windows.Forms.TextBox txtsuperficie;
        internal System.Windows.Forms.TextBox txthabitant;
        internal System.Windows.Forms.TextBox txtnom;
        internal System.Windows.Forms.Button cmdcreer;
        internal System.Windows.Forms.Label Label1;
    }
}