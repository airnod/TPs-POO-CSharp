

namespace Tp3
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
            this.lblInfo = new System.Windows.Forms.Label();
            this.Button2 = new System.Windows.Forms.Button();
            this.Button1 = new System.Windows.Forms.Button();
            this.grdPays = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblCont = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.txtchange = new System.Windows.Forms.TextBox();
            this.cmdmonnaie = new System.Windows.Forms.Button();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.lstmonnaie = new System.Windows.Forms.ComboBox();
            this.txthabitant = new System.Windows.Forms.TextBox();
            this.txtnom = new System.Windows.Forms.TextBox();
            this.cmdcreer = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdPays)).BeginInit();
            this.SuspendLayout();
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblInfo.Location = new System.Drawing.Point(81, 479);
            this.lblInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(0, 19);
            this.lblInfo.TabIndex = 46;
            // 
            // Button2
            // 
            this.Button2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button2.Location = new System.Drawing.Point(595, 309);
            this.Button2.Margin = new System.Windows.Forms.Padding(4);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(144, 49);
            this.Button2.TabIndex = 45;
            this.Button2.Text = "Plus grand pays";
            this.Button2.UseVisualStyleBackColor = true;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Button1
            // 
            this.Button1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button1.Location = new System.Drawing.Point(595, 235);
            this.Button1.Margin = new System.Windows.Forms.Padding(4);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(144, 49);
            this.Button1.TabIndex = 44;
            this.Button1.Text = "Nombre d\'habitants";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // grdPays
            // 
            this.grdPays.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdPays.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.grdPays.Location = new System.Drawing.Point(29, 234);
            this.grdPays.Margin = new System.Windows.Forms.Padding(4);
            this.grdPays.Name = "grdPays";
            this.grdPays.RowHeadersWidth = 51;
            this.grdPays.Size = new System.Drawing.Size(527, 197);
            this.grdPays.TabIndex = 43;
            this.grdPays.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdPays_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Nom";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 350;
            // 
            // lblCont
            // 
            this.lblCont.AutoSize = true;
            this.lblCont.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCont.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblCont.Location = new System.Drawing.Point(295, 25);
            this.lblCont.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCont.Name = "lblCont";
            this.lblCont.Size = new System.Drawing.Size(0, 19);
            this.lblCont.TabIndex = 42;
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Location = new System.Drawing.Point(253, 154);
            this.Label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(113, 16);
            this.Label7.TabIndex = 41;
            this.Label7.Text = "Taux de change : ";
            // 
            // txtchange
            // 
            this.txtchange.Location = new System.Drawing.Point(387, 150);
            this.txtchange.Margin = new System.Windows.Forms.Padding(4);
            this.txtchange.Name = "txtchange";
            this.txtchange.Size = new System.Drawing.Size(71, 22);
            this.txtchange.TabIndex = 40;
            // 
            // cmdmonnaie
            // 
            this.cmdmonnaie.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdmonnaie.Location = new System.Drawing.Point(595, 159);
            this.cmdmonnaie.Margin = new System.Windows.Forms.Padding(4);
            this.cmdmonnaie.Name = "cmdmonnaie";
            this.cmdmonnaie.Size = new System.Drawing.Size(144, 49);
            this.cmdmonnaie.TabIndex = 39;
            this.cmdmonnaie.Text = "Liste des pays";
            this.cmdmonnaie.UseVisualStyleBackColor = true;
            this.cmdmonnaie.Click += new System.EventHandler(this.cmdmonnaie_Click);
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(5, 149);
            this.Label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(68, 16);
            this.Label6.TabIndex = 38;
            this.Label6.Text = "Monnaie : ";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(5, 113);
            this.Label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(102, 16);
            this.Label3.TabIndex = 37;
            this.Label3.Text = "Nb d\'habitants : ";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(5, 65);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(45, 16);
            this.Label2.TabIndex = 36;
            this.Label2.Text = "Nom : ";
            // 
            // lstmonnaie
            // 
            this.lstmonnaie.FormattingEnabled = true;
            this.lstmonnaie.Location = new System.Drawing.Point(121, 149);
            this.lstmonnaie.Margin = new System.Windows.Forms.Padding(4);
            this.lstmonnaie.Name = "lstmonnaie";
            this.lstmonnaie.Size = new System.Drawing.Size(111, 24);
            this.lstmonnaie.TabIndex = 35;
            this.lstmonnaie.SelectedIndexChanged += new System.EventHandler(this.lstmonnaie_SelectedIndexChanged);
            // 
            // txthabitant
            // 
            this.txthabitant.Location = new System.Drawing.Point(121, 110);
            this.txthabitant.Margin = new System.Windows.Forms.Padding(4);
            this.txthabitant.Name = "txthabitant";
            this.txthabitant.Size = new System.Drawing.Size(72, 22);
            this.txthabitant.TabIndex = 34;
            // 
            // txtnom
            // 
            this.txtnom.Location = new System.Drawing.Point(121, 62);
            this.txtnom.Margin = new System.Windows.Forms.Padding(4);
            this.txtnom.Name = "txtnom";
            this.txtnom.Size = new System.Drawing.Size(132, 22);
            this.txtnom.TabIndex = 33;
            // 
            // cmdcreer
            // 
            this.cmdcreer.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdcreer.Location = new System.Drawing.Point(595, 100);
            this.cmdcreer.Margin = new System.Windows.Forms.Padding(4);
            this.cmdcreer.Name = "cmdcreer";
            this.cmdcreer.Size = new System.Drawing.Size(144, 31);
            this.cmdcreer.TabIndex = 32;
            this.cmdcreer.Text = "Créer le pays";
            this.cmdcreer.UseVisualStyleBackColor = true;
            this.cmdcreer.Click += new System.EventHandler(this.cmdcreer_Click);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Label1.Location = new System.Drawing.Point(143, 22);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(95, 24);
            this.Label1.TabIndex = 31;
            this.Label1.Text = "Les pays";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(595, 391);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(144, 49);
            this.button3.TabIndex = 47;
            this.button3.Text = "Possesseurs d\'une monnaie";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 631);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.grdPays);
            this.Controls.Add(this.lblCont);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.txtchange);
            this.Controls.Add(this.cmdmonnaie);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.lstmonnaie);
            this.Controls.Add(this.txthabitant);
            this.Controls.Add(this.txtnom);
            this.Controls.Add(this.cmdcreer);
            this.Controls.Add(this.Label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Demarrage";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdPays)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.Label lblInfo;
        internal System.Windows.Forms.Button Button2;
        internal System.Windows.Forms.Button Button1;
        internal System.Windows.Forms.DataGridView grdPays;
        internal System.Windows.Forms.Label lblCont;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.TextBox txtchange;
        internal System.Windows.Forms.Button cmdmonnaie;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.ComboBox lstmonnaie;
        internal System.Windows.Forms.TextBox txthabitant;
        internal System.Windows.Forms.TextBox txtnom;
        internal System.Windows.Forms.Button cmdcreer;
        internal System.Windows.Forms.Label Label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        internal System.Windows.Forms.Button button3;
    }
}

