namespace Projet_Stage
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LoginTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.connecter = new System.Windows.Forms.Button();
            this.annule = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.changemdp = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F);
            this.label1.Location = new System.Drawing.Point(255, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F);
            this.label2.Location = new System.Drawing.Point(233, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mot de Passe";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // LoginTextBox
            // 
            this.LoginTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LoginTextBox.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F);
            this.LoginTextBox.Location = new System.Drawing.Point(192, 67);
            this.LoginTextBox.Multiline = true;
            this.LoginTextBox.Name = "LoginTextBox";
            this.LoginTextBox.Size = new System.Drawing.Size(180, 26);
            this.LoginTextBox.TabIndex = 2;
            this.LoginTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PasswordTextBox.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F);
            this.PasswordTextBox.Location = new System.Drawing.Point(192, 146);
            this.PasswordTextBox.Multiline = true;
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '*';
            this.PasswordTextBox.Size = new System.Drawing.Size(180, 26);
            this.PasswordTextBox.TabIndex = 3;
            this.PasswordTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // connecter
            // 
            this.connecter.FlatAppearance.BorderSize = 0;
            this.connecter.Font = new System.Drawing.Font("Franklin Gothic Medium", 16F);
            this.connecter.Location = new System.Drawing.Point(150, 193);
            this.connecter.Name = "connecter";
            this.connecter.Size = new System.Drawing.Size(111, 41);
            this.connecter.TabIndex = 4;
            this.connecter.Text = "Connecté";
            this.connecter.UseVisualStyleBackColor = true;
            this.connecter.Click += new System.EventHandler(this.connecter_Click);
            // 
            // annule
            // 
            this.annule.FlatAppearance.BorderSize = 0;
            this.annule.Font = new System.Drawing.Font("Franklin Gothic Medium", 16F);
            this.annule.Location = new System.Drawing.Point(304, 193);
            this.annule.Name = "annule";
            this.annule.Size = new System.Drawing.Size(111, 41);
            this.annule.TabIndex = 5;
            this.annule.Text = "Annuler";
            this.annule.UseVisualStyleBackColor = true;
            this.annule.Click += new System.EventHandler(this.annule_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label3.Location = new System.Drawing.Point(135, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Mot de Passe Oublié !";
            // 
            // changemdp
            // 
            this.changemdp.FlatAppearance.BorderSize = 0;
            this.changemdp.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changemdp.Location = new System.Drawing.Point(274, 255);
            this.changemdp.Name = "changemdp";
            this.changemdp.Size = new System.Drawing.Size(141, 26);
            this.changemdp.TabIndex = 8;
            this.changemdp.Text = "Changer Mot de Passe ";
            this.changemdp.UseVisualStyleBackColor = true;
            this.changemdp.Click += new System.EventHandler(this.changemdp_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 57);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(144, 129);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(468, 305);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.changemdp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.annule);
            this.Controls.Add(this.connecter);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.LoginTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox LoginTextBox;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Button connecter;
        private System.Windows.Forms.Button annule;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button changemdp;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}