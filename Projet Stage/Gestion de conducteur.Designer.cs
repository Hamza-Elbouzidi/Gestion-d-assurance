namespace Projet_Stage
{
    partial class Gestion_de_conducteur
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gestion_de_conducteur));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.nom = new System.Windows.Forms.TextBox();
            this.prenom = new System.Windows.Forms.TextBox();
            this.lieu = new System.Windows.Forms.TextBox();
            this.ville_delivre = new System.Windows.Forms.TextBox();
            this.datenaissance = new System.Windows.Forms.DateTimePicker();
            this.Ajouter = new System.Windows.Forms.Button();
            this.Modifier = new System.Windows.Forms.Button();
            this.Supprimer = new System.Windows.Forms.Button();
            this.Rechercher = new System.Windows.Forms.Button();
            this.Nouveau = new System.Windows.Forms.Button();
            this.Enregistrer = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Permis = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F);
            this.label1.Location = new System.Drawing.Point(12, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F);
            this.label2.Location = new System.Drawing.Point(12, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "N_Permis";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F);
            this.label3.Location = new System.Drawing.Point(12, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "Prenom";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F);
            this.label4.Location = new System.Drawing.Point(12, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 21);
            this.label4.TabIndex = 2;
            this.label4.Text = "Date Naissance ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F);
            this.label5.Location = new System.Drawing.Point(12, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 21);
            this.label5.TabIndex = 3;
            this.label5.Text = "Lieu de Naissance";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F);
            this.label6.Location = new System.Drawing.Point(12, 247);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 21);
            this.label6.TabIndex = 4;
            this.label6.Text = "Ville delivré";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F);
            this.label7.Location = new System.Drawing.Point(13, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 21);
            this.label7.TabIndex = 5;
            this.label7.Text = "Cin Client";
            // 
            // nom
            // 
            this.nom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nom.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F);
            this.nom.Location = new System.Drawing.Point(160, 82);
            this.nom.Multiline = true;
            this.nom.Name = "nom";
            this.nom.Size = new System.Drawing.Size(200, 28);
            this.nom.TabIndex = 8;
            // 
            // prenom
            // 
            this.prenom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.prenom.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F);
            this.prenom.Location = new System.Drawing.Point(160, 122);
            this.prenom.Multiline = true;
            this.prenom.Name = "prenom";
            this.prenom.Size = new System.Drawing.Size(200, 28);
            this.prenom.TabIndex = 9;
            // 
            // lieu
            // 
            this.lieu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lieu.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F);
            this.lieu.ForeColor = System.Drawing.Color.Black;
            this.lieu.Location = new System.Drawing.Point(160, 192);
            this.lieu.Multiline = true;
            this.lieu.Name = "lieu";
            this.lieu.Size = new System.Drawing.Size(200, 28);
            this.lieu.TabIndex = 10;
            // 
            // ville_delivre
            // 
            this.ville_delivre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ville_delivre.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F);
            this.ville_delivre.ForeColor = System.Drawing.Color.Black;
            this.ville_delivre.Location = new System.Drawing.Point(160, 240);
            this.ville_delivre.Multiline = true;
            this.ville_delivre.Name = "ville_delivre";
            this.ville_delivre.Size = new System.Drawing.Size(200, 28);
            this.ville_delivre.TabIndex = 11;
            // 
            // datenaissance
            // 
            this.datenaissance.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datenaissance.Location = new System.Drawing.Point(160, 159);
            this.datenaissance.Name = "datenaissance";
            this.datenaissance.Size = new System.Drawing.Size(200, 21);
            this.datenaissance.TabIndex = 12;
            // 
            // Ajouter
            // 
            this.Ajouter.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F);
            this.Ajouter.Image = ((System.Drawing.Image)(resources.GetObject("Ajouter.Image")));
            this.Ajouter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Ajouter.Location = new System.Drawing.Point(387, 14);
            this.Ajouter.Name = "Ajouter";
            this.Ajouter.Size = new System.Drawing.Size(125, 30);
            this.Ajouter.TabIndex = 13;
            this.Ajouter.Text = "Ajouter";
            this.Ajouter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Ajouter.UseVisualStyleBackColor = true;
            this.Ajouter.Click += new System.EventHandler(this.Ajouter_Click);
            // 
            // Modifier
            // 
            this.Modifier.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F);
            this.Modifier.Image = ((System.Drawing.Image)(resources.GetObject("Modifier.Image")));
            this.Modifier.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Modifier.Location = new System.Drawing.Point(387, 61);
            this.Modifier.Name = "Modifier";
            this.Modifier.Size = new System.Drawing.Size(125, 31);
            this.Modifier.TabIndex = 14;
            this.Modifier.Text = "Modifier";
            this.Modifier.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Modifier.UseVisualStyleBackColor = true;
            this.Modifier.Click += new System.EventHandler(this.Modifier_Click);
            // 
            // Supprimer
            // 
            this.Supprimer.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F);
            this.Supprimer.Image = ((System.Drawing.Image)(resources.GetObject("Supprimer.Image")));
            this.Supprimer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Supprimer.Location = new System.Drawing.Point(387, 107);
            this.Supprimer.Name = "Supprimer";
            this.Supprimer.Size = new System.Drawing.Size(125, 32);
            this.Supprimer.TabIndex = 15;
            this.Supprimer.Text = "Supprimer";
            this.Supprimer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Supprimer.UseVisualStyleBackColor = true;
            this.Supprimer.Click += new System.EventHandler(this.Supprimer_Click);
            // 
            // Rechercher
            // 
            this.Rechercher.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F);
            this.Rechercher.Image = ((System.Drawing.Image)(resources.GetObject("Rechercher.Image")));
            this.Rechercher.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Rechercher.Location = new System.Drawing.Point(387, 152);
            this.Rechercher.Name = "Rechercher";
            this.Rechercher.Size = new System.Drawing.Size(125, 34);
            this.Rechercher.TabIndex = 16;
            this.Rechercher.Text = "Rechercher";
            this.Rechercher.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Rechercher.UseVisualStyleBackColor = true;
            this.Rechercher.Click += new System.EventHandler(this.Rechercher_Click);
            // 
            // Nouveau
            // 
            this.Nouveau.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F);
            this.Nouveau.Image = ((System.Drawing.Image)(resources.GetObject("Nouveau.Image")));
            this.Nouveau.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Nouveau.Location = new System.Drawing.Point(387, 199);
            this.Nouveau.Name = "Nouveau";
            this.Nouveau.Size = new System.Drawing.Size(125, 31);
            this.Nouveau.TabIndex = 17;
            this.Nouveau.Text = "Nouveau";
            this.Nouveau.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Nouveau.UseVisualStyleBackColor = true;
            this.Nouveau.Click += new System.EventHandler(this.Nouveau_Click);
            // 
            // Enregistrer
            // 
            this.Enregistrer.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F);
            this.Enregistrer.Image = ((System.Drawing.Image)(resources.GetObject("Enregistrer.Image")));
            this.Enregistrer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Enregistrer.Location = new System.Drawing.Point(387, 242);
            this.Enregistrer.Name = "Enregistrer";
            this.Enregistrer.Size = new System.Drawing.Size(125, 31);
            this.Enregistrer.TabIndex = 18;
            this.Enregistrer.Text = "Enregistrer";
            this.Enregistrer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Enregistrer.UseVisualStyleBackColor = true;
            this.Enregistrer.Click += new System.EventHandler(this.Enregistrer_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(214)))), ((int)(((byte)(228)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 297);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.Size = new System.Drawing.Size(503, 115);
            this.dataGridView1.TabIndex = 19;
            // 
            // Permis
            // 
            this.Permis.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Permis.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F);
            this.Permis.Location = new System.Drawing.Point(160, 7);
            this.Permis.Multiline = true;
            this.Permis.Name = "Permis";
            this.Permis.Size = new System.Drawing.Size(200, 28);
            this.Permis.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F);
            this.textBox1.Location = new System.Drawing.Point(160, 47);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 28);
            this.textBox1.TabIndex = 20;
            // 
            // Gestion_de_conducteur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(518, 424);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Enregistrer);
            this.Controls.Add(this.Nouveau);
            this.Controls.Add(this.Rechercher);
            this.Controls.Add(this.Supprimer);
            this.Controls.Add(this.Modifier);
            this.Controls.Add(this.Ajouter);
            this.Controls.Add(this.datenaissance);
            this.Controls.Add(this.ville_delivre);
            this.Controls.Add(this.lieu);
            this.Controls.Add(this.prenom);
            this.Controls.Add(this.nom);
            this.Controls.Add(this.Permis);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Consolas", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Gestion_de_conducteur";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion_de_conducteur";
            this.Load += new System.EventHandler(this.Gestion_de_conducteur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox nom;
        private System.Windows.Forms.TextBox prenom;
        private System.Windows.Forms.TextBox lieu;
        private System.Windows.Forms.TextBox ville_delivre;
        private System.Windows.Forms.DateTimePicker datenaissance;
        private System.Windows.Forms.Button Ajouter;
        private System.Windows.Forms.Button Modifier;
        private System.Windows.Forms.Button Supprimer;
        private System.Windows.Forms.Button Rechercher;
        private System.Windows.Forms.Button Nouveau;
        private System.Windows.Forms.Button Enregistrer;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox Permis;
        private System.Windows.Forms.TextBox textBox1;
    }
}