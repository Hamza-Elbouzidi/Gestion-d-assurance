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
    public partial class Gestion_de_conducteur : Form
    {
        public Gestion_de_conducteur()
        {
            InitializeComponent();
        }
        //Chaine de connexion
        static string ch = @"Data Source=DESKTOP-2CE72MO\SQLEXPRESS;Initial Catalog=AtlantaSanad;Integrated Security=True";
        SqlConnection con = new SqlConnection(ch);
        DataSet ds = new DataSet();

        



        //Remplissage DataGridView//
        private void Gestion_de_conducteur_Load(object sender, EventArgs e)
        {
            string req = "select * from Conducteur";
            SqlDataAdapter dr = new SqlDataAdapter(req, con);
            dr.Fill(ds, "Conducteur");

            dataGridView1.DataSource = ds.Tables["Conducteur"];
         
        }

        //Button Rechercher //
        private void Rechercher_Click(object sender, EventArgs e)
        {

         
            int p = -1;
            for (int i = 0; i < ds.Tables["Conducteur"].Rows.Count; i++)
            {
                if (Permis.Text == ds.Tables["Conducteur"].Rows[i][0].ToString())
                {
                    p = i;
                    break;
                }


            }
            if (p == -1)
            {
                MessageBox.Show("Ce Coducteur n'existe pas ");

            }
            else
            {
                Permis.Text = ds.Tables["Conducteur"].Rows[p][0].ToString();
                nom.Text = ds.Tables["Conducteur"].Rows[p][1].ToString();
                prenom.Text = ds.Tables["Conducteur"].Rows[p][2].ToString();
                datenaissance.Text = ds.Tables["Conducteur"].Rows[p][3].ToString();
                lieu.Text = ds.Tables["Conducteur"].Rows[p][4].ToString();
                ville_delivre.Text = ds.Tables["Conducteur"].Rows[p][5].ToString();
                textBox1.Text = ds.Tables["Conducteur"].Rows[p][6].ToString();

            }
        }


        //Button Ajouter //
        private void Ajouter_Click(object sender, EventArgs e)
        {
            int p = 0;

            if (Permis.Text == "" || textBox1.Text == "" || nom.Text == "" || prenom.Text == "" || datenaissance.Text == "" || lieu.Text == "" ||
                ville_delivre.Text == "" )
            {
                MessageBox.Show("Tous les Champs doit etre insére");
            }
            else
            {
                int t = 0;
                string req = "select * from Conducteur ";
                SqlDataAdapter dr = new SqlDataAdapter(req, con);
                dr.Fill(ds, "Conducteur");
                for (int i = 0; i < ds.Tables["Conducteur"].Rows.Count; i++)
                {

                    if (Permis.Text == ds.Tables["Conducteur"].Rows[i][0].ToString())
                    {
                        t = 1; break;
                    }
                }
                {
                    if (t == 0)


                    {
                        DataRow l;
                        l = ds.Tables["Conducteur"].NewRow();
                        l[0] = Permis.Text;
                        l[1] = nom.Text;
                        l[2] = prenom.Text;
                        l[3] = datenaissance.Text;
                        l[4] = lieu.Text;
                        l[5] = ville_delivre.Text;
                        l[6] = textBox1.Text;

                        ds.Tables["Conducteur"].Rows.Add(l);
                        MessageBox.Show("Bien Ajouter");
                        p = 1;
                    }
                    if (p == 0)
                    {
                        MessageBox.Show("Ce Conducteur Déja Existe");
                    }
                }
            }

        }

        //Button Enregistrer//
        private void Enregistrer_Click(object sender, EventArgs e)
        {
            string req = "select * from Conducteur";
            SqlDataAdapter dr = new SqlDataAdapter(req, con);
            SqlCommandBuilder cmd = new SqlCommandBuilder(dr);
            dr.Update(ds, "Conducteur");
            MessageBox.Show("Les Champs sont Enregistrer");
        }


        //Button Modifier
        private void Modifier_Click(object sender, EventArgs e)
        {
            int p = 0;

            for (int i = 0; i < ds.Tables["Conducteur"].Rows.Count; i++)
            {

               
                if (Permis.Text == ds.Tables["Conducteur"].Rows[i][0].ToString())
                {
                    ds.Tables["Conducteur"].Rows[i][1] = nom.Text;
                    ds.Tables["Conducteur"].Rows[i][2] = prenom.Text;
                    ds.Tables["Conducteur"].Rows[i][3] = datenaissance.Text;
                    ds.Tables["Conducteur"].Rows[i][4] = lieu.Text;
                    ds.Tables["Conducteur"].Rows[i][5] = ville_delivre.Text;
                    ds.Tables["Conducteur"].Rows[i][6] = textBox1.Text;
                    MessageBox.Show("Modifier Avec Succes");
                    p = 1;
                    break;
                }
              
                

            }
            if (p == 0) 
            {
                MessageBox.Show("Vérifier Que tous les champs sont Convenable");
            }

        }
        //Button Supprimer//
        private void Supprimer_Click(object sender, EventArgs e)
        {
            int p = 0;

            for (int i = 0; i < ds.Tables["Conducteur"].Rows.Count; i++)
            {
                if (Permis.Text == ds.Tables["Conducteur"].Rows[i][0].ToString())
                {
                    ds.Tables["Conducteur"].Rows[i].Delete();
                    MessageBox.Show("Les Champs de Ce Conducteur Sont Supprimé");
                    p = 1;
                    break;
                }
            }
            if (p == 0)
            {
                MessageBox.Show("Ce Conducteur n'existe Pas");

            }

        }

        private void Nouveau_Click(object sender, EventArgs e)
        {
            Permis.Text = "";
            nom.Text = "";
            prenom.Text = "";
            datenaissance.Text = "";
            lieu.Text = "";
            ville_delivre.Text = "";
            textBox1.Text = "";
            
        }
    }
}
