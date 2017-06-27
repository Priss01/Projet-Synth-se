namespace GestionSalaraies
{
    partial class FrmSalaries
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
            this.components = new System.ComponentModel.Container();
            this.gbDetailSalarié = new System.Windows.Forms.GroupBox();
            this.chkCommercial = new System.Windows.Forms.CheckBox();
            this.txtDatenaisance = new System.Windows.Forms.MaskedTextBox();
            this.grpBoxCommerciaux = new System.Windows.Forms.GroupBox();
            this.txtTxCom = new System.Windows.Forms.TextBox();
            this.txtCA = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTxCS = new System.Windows.Forms.TextBox();
            this.txtSalaireB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBPrenom = new System.Windows.Forms.TextBox();
            this.pnlBoutons = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnValider = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.txtNomS = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMatricule = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbSalarié = new System.Windows.Forms.ComboBox();
            this.btnNouveauS = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.gbDetailSalarié.SuspendLayout();
            this.grpBoxCommerciaux.SuspendLayout();
            this.pnlBoutons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbDetailSalarié
            // 
            this.gbDetailSalarié.Controls.Add(this.chkCommercial);
            this.gbDetailSalarié.Controls.Add(this.txtDatenaisance);
            this.gbDetailSalarié.Controls.Add(this.grpBoxCommerciaux);
            this.gbDetailSalarié.Controls.Add(this.label8);
            this.gbDetailSalarié.Controls.Add(this.label7);
            this.gbDetailSalarié.Controls.Add(this.txtTxCS);
            this.gbDetailSalarié.Controls.Add(this.txtSalaireB);
            this.gbDetailSalarié.Controls.Add(this.label6);
            this.gbDetailSalarié.Controls.Add(this.textBPrenom);
            this.gbDetailSalarié.Controls.Add(this.pnlBoutons);
            this.gbDetailSalarié.Controls.Add(this.txtNomS);
            this.gbDetailSalarié.Controls.Add(this.label4);
            this.gbDetailSalarié.Controls.Add(this.label3);
            this.gbDetailSalarié.Controls.Add(this.txtMatricule);
            this.gbDetailSalarié.Controls.Add(this.label2);
            this.gbDetailSalarié.Location = new System.Drawing.Point(24, 91);
            this.gbDetailSalarié.Margin = new System.Windows.Forms.Padding(2);
            this.gbDetailSalarié.Name = "gbDetailSalarié";
            this.gbDetailSalarié.Padding = new System.Windows.Forms.Padding(2);
            this.gbDetailSalarié.Size = new System.Drawing.Size(359, 343);
            this.gbDetailSalarié.TabIndex = 7;
            this.gbDetailSalarié.TabStop = false;
            this.gbDetailSalarié.Text = "Détails Salarié";
            // 
            // chkCommercial
            // 
            this.chkCommercial.AutoSize = true;
            this.chkCommercial.Location = new System.Drawing.Point(129, 179);
            this.chkCommercial.Name = "chkCommercial";
            this.chkCommercial.Size = new System.Drawing.Size(159, 17);
            this.chkCommercial.TabIndex = 13;
            this.chkCommercial.Text = "Le salarié est un commercial";
            this.chkCommercial.UseVisualStyleBackColor = true;
            this.chkCommercial.CheckedChanged += new System.EventHandler(this.chkCommercial_CheckedChanged);
            // 
            // txtDatenaisance
            // 
            this.txtDatenaisance.Location = new System.Drawing.Point(129, 93);
            this.txtDatenaisance.Mask = "00/00/0000";
            this.txtDatenaisance.Name = "txtDatenaisance";
            this.txtDatenaisance.Size = new System.Drawing.Size(132, 20);
            this.txtDatenaisance.TabIndex = 12;
            this.txtDatenaisance.ValidatingType = typeof(System.DateTime);
            // 
            // grpBoxCommerciaux
            // 
            this.grpBoxCommerciaux.Controls.Add(this.txtTxCom);
            this.grpBoxCommerciaux.Controls.Add(this.txtCA);
            this.grpBoxCommerciaux.Controls.Add(this.label9);
            this.grpBoxCommerciaux.Controls.Add(this.label5);
            this.grpBoxCommerciaux.Location = new System.Drawing.Point(17, 202);
            this.grpBoxCommerciaux.Name = "grpBoxCommerciaux";
            this.grpBoxCommerciaux.Size = new System.Drawing.Size(325, 70);
            this.grpBoxCommerciaux.TabIndex = 11;
            this.grpBoxCommerciaux.TabStop = false;
            this.grpBoxCommerciaux.Text = "Commerciaux";
            // 
            // txtTxCom
            // 
            this.txtTxCom.Location = new System.Drawing.Point(109, 45);
            this.txtTxCom.Name = "txtTxCom";
            this.txtTxCom.Size = new System.Drawing.Size(132, 20);
            this.txtTxCom.TabIndex = 3;
            // 
            // txtCA
            // 
            this.txtCA.Location = new System.Drawing.Point(109, 19);
            this.txtCA.Name = "txtCA";
            this.txtCA.Size = new System.Drawing.Size(132, 20);
            this.txtCA.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(26, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Tx Commission";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Chiffre d\'affaire";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 144);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Taux CS :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 120);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Salaire Brut :";
            // 
            // txtTxCS
            // 
            this.txtTxCS.Location = new System.Drawing.Point(129, 141);
            this.txtTxCS.Margin = new System.Windows.Forms.Padding(2);
            this.txtTxCS.Name = "txtTxCS";
            this.txtTxCS.PasswordChar = '*';
            this.txtTxCS.Size = new System.Drawing.Size(132, 20);
            this.txtTxCS.TabIndex = 8;
            // 
            // txtSalaireB
            // 
            this.txtSalaireB.Location = new System.Drawing.Point(129, 117);
            this.txtSalaireB.Margin = new System.Windows.Forms.Padding(2);
            this.txtSalaireB.Name = "txtSalaireB";
            this.txtSalaireB.PasswordChar = '*';
            this.txtSalaireB.Size = new System.Drawing.Size(132, 20);
            this.txtSalaireB.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 72);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Prenom :";
            // 
            // textBPrenom
            // 
            this.textBPrenom.Location = new System.Drawing.Point(129, 69);
            this.textBPrenom.Margin = new System.Windows.Forms.Padding(2);
            this.textBPrenom.Name = "textBPrenom";
            this.textBPrenom.PasswordChar = '*';
            this.textBPrenom.Size = new System.Drawing.Size(132, 20);
            this.textBPrenom.TabIndex = 5;
            // 
            // pnlBoutons
            // 
            this.pnlBoutons.Controls.Add(this.button1);
            this.pnlBoutons.Controls.Add(this.btnValider);
            this.pnlBoutons.Controls.Add(this.btnAnnuler);
            this.pnlBoutons.Controls.Add(this.btnModifier);
            this.pnlBoutons.Location = new System.Drawing.Point(17, 287);
            this.pnlBoutons.Margin = new System.Windows.Forms.Padding(2);
            this.pnlBoutons.Name = "pnlBoutons";
            this.pnlBoutons.Size = new System.Drawing.Size(325, 52);
            this.pnlBoutons.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(238, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(63, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Supprimer";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(158, 17);
            this.btnValider.Margin = new System.Windows.Forms.Padding(2);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(56, 23);
            this.btnValider.TabIndex = 0;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAnnuler.Location = new System.Drawing.Point(80, 17);
            this.btnAnnuler.Margin = new System.Windows.Forms.Padding(2);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(56, 23);
            this.btnAnnuler.TabIndex = 0;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(8, 17);
            this.btnModifier.Margin = new System.Windows.Forms.Padding(2);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(56, 23);
            this.btnModifier.TabIndex = 0;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            // 
            // txtNomS
            // 
            this.txtNomS.Location = new System.Drawing.Point(129, 45);
            this.txtNomS.Margin = new System.Windows.Forms.Padding(2);
            this.txtNomS.Name = "txtNomS";
            this.txtNomS.Size = new System.Drawing.Size(132, 20);
            this.txtNomS.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 48);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nom :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 96);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Data de Naissance :";
            // 
            // txtMatricule
            // 
            this.txtMatricule.Location = new System.Drawing.Point(129, 21);
            this.txtMatricule.Margin = new System.Windows.Forms.Padding(2);
            this.txtMatricule.Name = "txtMatricule";
            this.txtMatricule.Size = new System.Drawing.Size(132, 20);
            this.txtMatricule.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 24);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Matricule :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Choisir un salarié :";
            // 
            // cbSalarié
            // 
            this.cbSalarié.FormattingEnabled = true;
            this.cbSalarié.Location = new System.Drawing.Point(133, 21);
            this.cbSalarié.Margin = new System.Windows.Forms.Padding(2);
            this.cbSalarié.Name = "cbSalarié";
            this.cbSalarié.Size = new System.Drawing.Size(166, 21);
            this.cbSalarié.TabIndex = 5;
            // 
            // btnNouveauS
            // 
            this.btnNouveauS.Location = new System.Drawing.Point(309, 20);
            this.btnNouveauS.Margin = new System.Windows.Forms.Padding(2);
            this.btnNouveauS.Name = "btnNouveauS";
            this.btnNouveauS.Size = new System.Drawing.Size(74, 20);
            this.btnNouveauS.TabIndex = 4;
            this.btnNouveauS.Text = "Nouveau";
            this.btnNouveauS.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(133, 62);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(166, 20);
            this.textBox1.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(21, 65);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Recherche rapide";
            // 
            // FrmSalaries
            // 
            this.AcceptButton = this.btnValider;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnAnnuler;
            this.ClientSize = new System.Drawing.Size(523, 445);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.gbDetailSalarié);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbSalarié);
            this.Controls.Add(this.btnNouveauS);
            this.Name = "FrmSalaries";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmSalaries";
            this.Load += new System.EventHandler(this.FrmSalaries_Load);
            this.gbDetailSalarié.ResumeLayout(false);
            this.gbDetailSalarié.PerformLayout();
            this.grpBoxCommerciaux.ResumeLayout(false);
            this.grpBoxCommerciaux.PerformLayout();
            this.pnlBoutons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDetailSalarié;
        private System.Windows.Forms.Panel pnlBoutons;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.TextBox txtNomS;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMatricule;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbSalarié;
        private System.Windows.Forms.Button btnNouveauS;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTxCS;
        private System.Windows.Forms.TextBox txtSalaireB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBPrenom;
        private System.Windows.Forms.GroupBox grpBoxCommerciaux;
        private System.Windows.Forms.TextBox txtTxCom;
        private System.Windows.Forms.TextBox txtCA;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox txtDatenaisance;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.CheckBox chkCommercial;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox1;
    }
}