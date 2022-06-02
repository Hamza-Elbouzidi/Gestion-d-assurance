namespace Projet_Stage
{
    partial class Réinitialiser_mot_de_passe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Réinitialiser_mot_de_passe));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nom = new System.Windows.Forms.TextBox();
            this.reference = new System.Windows.Forms.TextBox();
            this.nouveamdp = new System.Windows.Forms.TextBox();
            this.confirmation = new System.Windows.Forms.TextBox();
            this.Valider = new System.Windows.Forms.Button();
            this.Confirmer = new System.Windows.Forms.Button();
            this.Vider = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F);
            this.label1.Location = new System.Drawing.Point(13, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom Complet :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F);
            this.label2.Location = new System.Drawing.Point(13, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Reference :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F);
            this.label3.Location = new System.Drawing.Point(9, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Le Nouveau Mot de Passe :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F);
            this.label4.Location = new System.Drawing.Point(9, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(205, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Confirmer Le Mot de Passe  :";
            // 
            // nom
            // 
            this.nom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nom.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F);
            this.nom.Location = new System.Drawing.Point(220, 40);
            this.nom.Multiline = true;
            this.nom.Name = "nom";
            this.nom.Size = new System.Drawing.Size(225, 32);
            this.nom.TabIndex = 4;
            // 
            // reference
            // 
            this.reference.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.reference.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F);
            this.reference.Location = new System.Drawing.Point(220, 78);
            this.reference.Multiline = true;
            this.reference.Name = "reference";
            this.reference.Size = new System.Drawing.Size(225, 31);
            this.reference.TabIndex = 5;
            // 
            // nouveamdp
            // 
            this.nouveamdp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nouveamdp.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F);
            this.nouveamdp.Location = new System.Drawing.Point(220, 115);
            this.nouveamdp.Multiline = true;
            this.nouveamdp.Name = "nouveamdp";
            this.nouveamdp.PasswordChar = '*';
            this.nouveamdp.Size = new System.Drawing.Size(225, 32);
            this.nouveamdp.TabIndex = 6;
            // 
            // confirmation
            // 
            this.confirmation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.confirmation.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F);
            this.confirmation.Location = new System.Drawing.Point(220, 153);
            this.confirmation.Multiline = true;
            this.confirmation.Name = "confirmation";
            this.confirmation.PasswordChar = '*';
            this.confirmation.Size = new System.Drawing.Size(225, 31);
            this.confirmation.TabIndex = 7;
            // 
            // Valider
            // 
            this.Valider.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F);
            this.Valider.Image = ((System.Drawing.Image)(resources.GetObject("Valider.Image")));
            this.Valider.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Valider.Location = new System.Drawing.Point(182, 199);
            this.Valider.Name = "Valider";
            this.Valider.Size = new System.Drawing.Size(109, 35);
            this.Valider.TabIndex = 8;
            this.Valider.Text = "Modifier";
            this.Valider.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Valider.UseVisualStyleBackColor = true;
            this.Valider.Click += new System.EventHandler(this.Valider_Click);
            // 
            // Confirmer
            // 
            this.Confirmer.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F);
            this.Confirmer.Image = ((System.Drawing.Image)(resources.GetObject("Confirmer.Image")));
            this.Confirmer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Confirmer.Location = new System.Drawing.Point(294, 199);
            this.Confirmer.Name = "Confirmer";
            this.Confirmer.Size = new System.Drawing.Size(109, 35);
            this.Confirmer.TabIndex = 9;
            this.Confirmer.Text = "Confirmer";
            this.Confirmer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Confirmer.UseVisualStyleBackColor = true;
            this.Confirmer.Click += new System.EventHandler(this.Confirmer_Click);
            // 
            // Vider
            // 
            this.Vider.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F);
            this.Vider.Image = ((System.Drawing.Image)(resources.GetObject("Vider.Image")));
            this.Vider.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Vider.Location = new System.Drawing.Point(67, 199);
            this.Vider.Name = "Vider";
            this.Vider.Size = new System.Drawing.Size(109, 35);
            this.Vider.TabIndex = 10;
            this.Vider.Text = "Vider";
            this.Vider.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Vider.UseVisualStyleBackColor = true;
            this.Vider.Click += new System.EventHandler(this.Vider_Click);
            // 
            // Réinitialiser_mot_de_passe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(457, 258);
            this.Controls.Add(this.Vider);
            this.Controls.Add(this.Confirmer);
            this.Controls.Add(this.Valider);
            this.Controls.Add(this.confirmation);
            this.Controls.Add(this.nouveamdp);
            this.Controls.Add(this.reference);
            this.Controls.Add(this.nom);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Consolas", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Réinitialiser_mot_de_passe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Changer Mot de Passe";
            this.Load += new System.EventHandler(this.Réinitialiser_mot_de_passe_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nom;
        private System.Windows.Forms.TextBox reference;
        private System.Windows.Forms.TextBox nouveamdp;
        private System.Windows.Forms.TextBox confirmation;
        private System.Windows.Forms.Button Valider;
        private System.Windows.Forms.Button Confirmer;
        private System.Windows.Forms.Button Vider;
    }
}