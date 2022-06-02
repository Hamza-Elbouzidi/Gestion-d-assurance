namespace Projet_Stage
{
    partial class Gestion_des_Vehicules
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gestion_des_Vehicules));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.immatricualtion = new System.Windows.Forms.TextBox();
            this.chassis = new System.Windows.Forms.TextBox();
            this.Marque = new System.Windows.Forms.TextBox();
            this.carrosserie = new System.Windows.Forms.TextBox();
            this.Remorque = new System.Windows.Forms.TextBox();
            this.Ajouter = new System.Windows.Forms.Button();
            this.Modifier = new System.Windows.Forms.Button();
            this.Supprimer = new System.Windows.Forms.Button();
            this.Rechercher = new System.Windows.Forms.Button();
            this.Enregistrer = new System.Windows.Forms.Button();
            this.Nouveau = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "N° d\'immatricualtion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "N°de Chassis";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Marque ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Type de carrosserie";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "Remorque";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // immatricualtion
            // 
            this.immatricualtion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.immatricualtion.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F);
            this.immatricualtion.Location = new System.Drawing.Point(189, 33);
            this.immatricualtion.Multiline = true;
            this.immatricualtion.Name = "immatricualtion";
            this.immatricualtion.Size = new System.Drawing.Size(126, 30);
            this.immatricualtion.TabIndex = 5;
            this.immatricualtion.TextChanged += new System.EventHandler(this.immatricualtion_TextChanged);
            // 
            // chassis
            // 
            this.chassis.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.chassis.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F);
            this.chassis.Location = new System.Drawing.Point(189, 82);
            this.chassis.Multiline = true;
            this.chassis.Name = "chassis";
            this.chassis.Size = new System.Drawing.Size(126, 28);
            this.chassis.TabIndex = 6;
            // 
            // Marque
            // 
            this.Marque.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Marque.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F);
            this.Marque.Location = new System.Drawing.Point(189, 131);
            this.Marque.Multiline = true;
            this.Marque.Name = "Marque";
            this.Marque.Size = new System.Drawing.Size(126, 28);
            this.Marque.TabIndex = 7;
            // 
            // carrosserie
            // 
            this.carrosserie.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.carrosserie.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F);
            this.carrosserie.Location = new System.Drawing.Point(189, 170);
            this.carrosserie.Multiline = true;
            this.carrosserie.Name = "carrosserie";
            this.carrosserie.Size = new System.Drawing.Size(126, 28);
            this.carrosserie.TabIndex = 8;
            // 
            // Remorque
            // 
            this.Remorque.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Remorque.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F);
            this.Remorque.Location = new System.Drawing.Point(189, 209);
            this.Remorque.Multiline = true;
            this.Remorque.Name = "Remorque";
            this.Remorque.Size = new System.Drawing.Size(126, 28);
            this.Remorque.TabIndex = 9;
            // 
            // Ajouter
            // 
            this.Ajouter.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F);
            this.Ajouter.Image = ((System.Drawing.Image)(resources.GetObject("Ajouter.Image")));
            this.Ajouter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Ajouter.Location = new System.Drawing.Point(366, 7);
            this.Ajouter.Name = "Ajouter";
            this.Ajouter.Size = new System.Drawing.Size(124, 35);
            this.Ajouter.TabIndex = 10;
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
            this.Modifier.Location = new System.Drawing.Point(366, 48);
            this.Modifier.Name = "Modifier";
            this.Modifier.Size = new System.Drawing.Size(124, 35);
            this.Modifier.TabIndex = 11;
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
            this.Supprimer.Location = new System.Drawing.Point(366, 89);
            this.Supprimer.Name = "Supprimer";
            this.Supprimer.Size = new System.Drawing.Size(124, 36);
            this.Supprimer.TabIndex = 12;
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
            this.Rechercher.Location = new System.Drawing.Point(366, 133);
            this.Rechercher.Name = "Rechercher";
            this.Rechercher.Size = new System.Drawing.Size(124, 36);
            this.Rechercher.TabIndex = 13;
            this.Rechercher.Text = "Rechercher";
            this.Rechercher.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Rechercher.UseVisualStyleBackColor = true;
            this.Rechercher.Click += new System.EventHandler(this.Rechercher_Click);
            // 
            // Enregistrer
            // 
            this.Enregistrer.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F);
            this.Enregistrer.Image = ((System.Drawing.Image)(resources.GetObject("Enregistrer.Image")));
            this.Enregistrer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Enregistrer.Location = new System.Drawing.Point(366, 175);
            this.Enregistrer.Name = "Enregistrer";
            this.Enregistrer.Size = new System.Drawing.Size(124, 33);
            this.Enregistrer.TabIndex = 14;
            this.Enregistrer.Text = "Enregistrer";
            this.Enregistrer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Enregistrer.UseVisualStyleBackColor = true;
            this.Enregistrer.Click += new System.EventHandler(this.Enregistrer_Click);
            // 
            // Nouveau
            // 
            this.Nouveau.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F);
            this.Nouveau.Image = ((System.Drawing.Image)(resources.GetObject("Nouveau.Image")));
            this.Nouveau.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Nouveau.Location = new System.Drawing.Point(366, 214);
            this.Nouveau.Name = "Nouveau";
            this.Nouveau.Size = new System.Drawing.Size(124, 36);
            this.Nouveau.TabIndex = 15;
            this.Nouveau.Text = "Nouveau";
            this.Nouveau.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Nouveau.UseVisualStyleBackColor = true;
            this.Nouveau.Click += new System.EventHandler(this.Nouveau_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(214)))), ((int)(((byte)(228)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 278);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.Size = new System.Drawing.Size(478, 106);
            this.dataGridView1.TabIndex = 16;
            // 
            // Gestion_des_Vehicules
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(502, 396);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Nouveau);
            this.Controls.Add(this.Enregistrer);
            this.Controls.Add(this.Rechercher);
            this.Controls.Add(this.Supprimer);
            this.Controls.Add(this.Modifier);
            this.Controls.Add(this.Ajouter);
            this.Controls.Add(this.Remorque);
            this.Controls.Add(this.carrosserie);
            this.Controls.Add(this.Marque);
            this.Controls.Add(this.chassis);
            this.Controls.Add(this.immatricualtion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Consolas", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Gestion_des_Vehicules";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion_des_Vehicules";
            this.Load += new System.EventHandler(this.Gestion_des_Vehicules_Load);
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
        private System.Windows.Forms.TextBox immatricualtion;
        private System.Windows.Forms.TextBox chassis;
        private System.Windows.Forms.TextBox Marque;
        private System.Windows.Forms.TextBox carrosserie;
        private System.Windows.Forms.TextBox Remorque;
        private System.Windows.Forms.Button Modifier;
        private System.Windows.Forms.Button Supprimer;
        private System.Windows.Forms.Button Rechercher;
        private System.Windows.Forms.Button Enregistrer;
        public System.Windows.Forms.Button Ajouter;
        private System.Windows.Forms.Button Nouveau;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}