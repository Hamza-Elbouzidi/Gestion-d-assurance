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
    public partial class Réinitialiser_mot_de_passe : Form
    {
        //SqlCommandBuilder cmd = new SqlCommandBuilder();
        //SqlDataAdapter dr = new SqlDataAdapter();
        public Réinitialiser_mot_de_passe()
        {
            InitializeComponent();
        }


        //Chaine de connexion
        static string ch = @"Data Source=DESKTOP-2CE72MO\SQLEXPRESS;Initial Catalog=AtlantaSanad;Integrated Security=True";
        SqlConnection con = new SqlConnection(ch);
        DataSet ds = new DataSet();

        private void Réinitialiser_mot_de_passe_Load(object sender, EventArgs e)
        {
            string req = "select * from Connexion ";
            SqlDataAdapter dr = new SqlDataAdapter(req, con);
            dr.Fill(ds, "Connexion");
        }

        //Button Vider
        private void Vider_Click(object sender, EventArgs e)
        {
            nom.Text = "";
            reference.Text = "";
            nouveamdp.Text = "";
            confirmation.Text = "";


        }
        //Button enregistrer//
        private void Confirmer_Click(object sender, EventArgs e)
        {
            string req = "select * from Connexion";
            SqlDataAdapter dr = new SqlDataAdapter(req, con);
            SqlCommandBuilder cmd = new SqlCommandBuilder(dr);
            dr.Update(ds, "Connexion");
            MessageBox.Show("Mot De Passe Confirmé");
            
        }

        //Button Validation pour changement du mdp//
        private void Valider_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < ds.Tables["Connexion"].Rows.Count; i++)
            {

              
                if (nom.Text == ds.Tables["Connexion"].Rows[i][2].ToString() && reference.Text == ds.Tables["Connexion"].Rows[i][3].ToString())
                {
                    ds.Tables["Connexion"].Rows[i][1] = confirmation.Text;
                    MessageBox.Show("Le Mot de Passe est Modifié Veuiller Confirmer le Changement ");

                }
            }
        }
    }
}
       
    
