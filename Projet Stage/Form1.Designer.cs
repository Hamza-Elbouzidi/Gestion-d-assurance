namespace Projet_Stage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.atlantaSanadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connexionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deconnecterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.laGestionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDeClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDeVehiculesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDeConducteurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.form2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.AliceBlue;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.atlantaSanadToolStripMenuItem,
            this.laGestionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(637, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // atlantaSanadToolStripMenuItem
            // 
            this.atlantaSanadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connexionToolStripMenuItem,
            this.deconnecterToolStripMenuItem});
            this.atlantaSanadToolStripMenuItem.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.atlantaSanadToolStripMenuItem.Name = "atlantaSanadToolStripMenuItem";
            this.atlantaSanadToolStripMenuItem.Size = new System.Drawing.Size(118, 25);
            this.atlantaSanadToolStripMenuItem.Text = "AtlantaSanad";
            this.atlantaSanadToolStripMenuItem.Click += new System.EventHandler(this.atlantaSanadToolStripMenuItem_Click);
            // 
            // connexionToolStripMenuItem
            // 
            this.connexionToolStripMenuItem.Name = "connexionToolStripMenuItem";
            this.connexionToolStripMenuItem.Size = new System.Drawing.Size(164, 26);
            this.connexionToolStripMenuItem.Text = "Connécter";
            this.connexionToolStripMenuItem.Click += new System.EventHandler(this.connexionToolStripMenuItem_Click);
            // 
            // deconnecterToolStripMenuItem
            // 
            this.deconnecterToolStripMenuItem.Name = "deconnecterToolStripMenuItem";
            this.deconnecterToolStripMenuItem.Size = new System.Drawing.Size(164, 26);
            this.deconnecterToolStripMenuItem.Text = "Déconnecter";
            this.deconnecterToolStripMenuItem.Click += new System.EventHandler(this.deconnecterToolStripMenuItem_Click);
            // 
            // laGestionToolStripMenuItem
            // 
            this.laGestionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionDeClientToolStripMenuItem,
            this.gestionDeVehiculesToolStripMenuItem,
            this.gestionDeConducteurToolStripMenuItem,
            this.form2ToolStripMenuItem});
            this.laGestionToolStripMenuItem.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laGestionToolStripMenuItem.Name = "laGestionToolStripMenuItem";
            this.laGestionToolStripMenuItem.Size = new System.Drawing.Size(94, 25);
            this.laGestionToolStripMenuItem.Text = "La Gestion";
            // 
            // gestionDeClientToolStripMenuItem
            // 
            this.gestionDeClientToolStripMenuItem.Name = "gestionDeClientToolStripMenuItem";
            this.gestionDeClientToolStripMenuItem.Size = new System.Drawing.Size(238, 26);
            this.gestionDeClientToolStripMenuItem.Text = "Gestion de Client";
            this.gestionDeClientToolStripMenuItem.Click += new System.EventHandler(this.gestionDeClientToolStripMenuItem_Click);
            // 
            // gestionDeVehiculesToolStripMenuItem
            // 
            this.gestionDeVehiculesToolStripMenuItem.Name = "gestionDeVehiculesToolStripMenuItem";
            this.gestionDeVehiculesToolStripMenuItem.Size = new System.Drawing.Size(238, 26);
            this.gestionDeVehiculesToolStripMenuItem.Text = "Gestion de Vehicules";
            this.gestionDeVehiculesToolStripMenuItem.Click += new System.EventHandler(this.gestionDeVehiculesToolStripMenuItem_Click);
            // 
            // gestionDeConducteurToolStripMenuItem
            // 
            this.gestionDeConducteurToolStripMenuItem.Name = "gestionDeConducteurToolStripMenuItem";
            this.gestionDeConducteurToolStripMenuItem.Size = new System.Drawing.Size(238, 26);
            this.gestionDeConducteurToolStripMenuItem.Text = "Gestion de Conducteur ";
            this.gestionDeConducteurToolStripMenuItem.Click += new System.EventHandler(this.gestionDeConducteurToolStripMenuItem_Click);
            // 
            // form2ToolStripMenuItem
            // 
            this.form2ToolStripMenuItem.Name = "form2ToolStripMenuItem";
            this.form2ToolStripMenuItem.Size = new System.Drawing.Size(238, 26);
            this.form2ToolStripMenuItem.Text = "Imprimer ";
            this.form2ToolStripMenuItem.Click += new System.EventHandler(this.form2ToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PowderBlue;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(12, 27);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button1.Size = new System.Drawing.Size(610, 285);
            this.button1.TabIndex = 1;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(637, 329);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Consolas", 8.25F);
            this.ForeColor = System.Drawing.Color.RoyalBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Acceuil";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem atlantaSanadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connexionToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.ToolStripMenuItem deconnecterToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem gestionDeClientToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem gestionDeVehiculesToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem laGestionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDeConducteurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem form2ToolStripMenuItem;
    }
}

