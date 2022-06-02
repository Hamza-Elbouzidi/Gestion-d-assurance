using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Projet_Stage
{
    public partial class Login : Form
    {
        Form1 f1;
        public Login(Form1 f)
        {
            InitializeComponent();
            this.f1 = f;
        }

        //Chaine de connexion
        static string ch = @"Data Source=DESKTOP-2CE72MO\SQLEXPRESS;Initial Catalog=AtlantaSanad;Integrated Security=True";
        SqlConnection con = new SqlConnection(ch);
        DataSet ds = new DataSet();

        //Button Connecter

        static int cmp = 0;
        private void connecter_Click(object sender, EventArgs e)
        {
            string req = "select * from Connexion";
            SqlDataAdapter dr = new SqlDataAdapter(req, con);
            dr.Fill(ds, "Connexion");
            
            for(int i= 0; i<ds.Tables["Connexion"].Rows.Count;i++)
            {
                string l = ds.Tables["Connexion"].Rows[i][0].ToString();
                string p = ds.Tables["Connexion"].Rows[i][1].ToString();
                if (l == LoginTextBox.Text && p == PasswordTextBox.Text)
                {
                    f1.gestionDeClientToolStripMenuItem.Enabled = true;
                    f1.deconnecterToolStripMenuItem.Enabled = true;
                    f1.gestionDeVehiculesToolStripMenuItem.Enabled = true;
                    f1.laGestionToolStripMenuItem.Enabled = true;


                    MessageBox.Show("Connecter");
                    this.Close();
                    break;

                }
                else if (l == LoginTextBox.Text && p != PasswordTextBox.Text) { cmp++; MessageBox.Show("Mot De Passe Incorrect"); PasswordTextBox.Clear(); break; }
                else if (l != LoginTextBox.Text && p == PasswordTextBox.Text) { cmp++; MessageBox.Show("Login Incorrect"); LoginTextBox.Clear(); PasswordTextBox.Clear(); break; }
                else { cmp++; MessageBox.Show("Les Champs Incorrect"); LoginTextBox.Clear(); PasswordTextBox.Clear(); break; } 
                    
                }
            // Pour desactiver le compte apres 4 tenta 
            if (cmp==4)
            {
                connecter.Enabled = false;
            }

        }

        private void annule_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void changemdp_Click(object sender, EventArgs e)
        {
            Réinitialiser_mot_de_passe rs = new Réinitialiser_mot_de_passe();
            rs.Show();
            this.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
