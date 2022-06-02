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
    public partial class Gestion_des_Vehicules : Form
    {
        public Gestion_des_Vehicules()
        {
            InitializeComponent();
        }
        //Chaine de connexion
        static string ch = @"Data Source=DESKTOP-2CE72MO\SQLEXPRESS;Initial Catalog=AtlantaSanad;Integrated Security=True";
        SqlConnection con = new SqlConnection(ch);
        DataSet ds = new DataSet();



        //Remplissage datagridview//
        private void Gestion_des_Vehicules_Load(object sender, EventArgs e)
        {
            string req = "select * from Vehicule";
            SqlDataAdapter dr = new SqlDataAdapter(req, con);
            dr.Fill(ds, "Vehicule");

            dataGridView1.DataSource = ds.Tables["Vehicule"];
        }


        //Button Ajouter//
        private void Ajouter_Click(object sender, EventArgs e)
        {
            {

                int p = 0;

                if (immatricualtion.Text == "" || chassis.Text == "" || Marque.Text == "" || carrosserie.Text == "" || Remorque.Text == "")
                {
                    MessageBox.Show("Tous les Champs doit etre insére");
                }
                else
                {
                    int t = 0;
                    string req = "select * from Vehicule ";
                    SqlDataAdapter dr = new SqlDataAdapter(req, con);
                    dr.Fill(ds, "Vehicule");
                    for (int i = 0; i < ds.Tables["Vehicule"].Rows.Count; i++)
                    {

                        if (immatricualtion.Text == ds.Tables["Vehicule"].Rows[i][0].ToString())
                        {
                            t = 1; break;
                        }
                    }
                    {
                        if (t == 0)


                        {
                            DataRow l;
                            l = ds.Tables["Vehicule"].NewRow();
                            l[0] = immatricualtion.Text;
                            l[1] = chassis.Text;
                            l[2] = Marque.Text;
                            l[3] = carrosserie.Text;
                            l[4] = Remorque.Text;


                            ds.Tables["Vehicule"].Rows.Add(l);
                            MessageBox.Show("Bien Ajouter");
                            p = 1;
                        }
                        if (p == 0)
                        {
                            MessageBox.Show("Cet Vehicule  Déja Existe");
                        }
                    }
                }
            }
        }

        //Button Modifier
        private void Modifier_Click(object sender, EventArgs e)
        {
            int p = 0;

            for (int i = 0; i < ds.Tables["Vehicule"].Rows.Count; i++)
            {

               
                if (immatricualtion.Text == ds.Tables["Vehicule"].Rows[i][0].ToString())
                {
                    ds.Tables["Vehicule"].Rows[i][0] = immatricualtion.Text;
                    ds.Tables["Vehicule"].Rows[i][1] = chassis.Text;
                    ds.Tables["Vehicule"].Rows[i][2] = Marque.Text;
                    ds.Tables["Vehicule"].Rows[i][3] = carrosserie.Text;
                    ds.Tables["Vehicule"].Rows[i][4] = Remorque.Text;
                 

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


        //Button Rechercher//
        private void Rechercher_Click(object sender, EventArgs e)
        {
          
            int p = -1;
            for (int i = 0; i < ds.Tables["Vehicule"].Rows.Count; i++)
            {
                if (immatricualtion.Text == ds.Tables["Vehicule"].Rows[i][0].ToString())
                {
                    p = i;
                    break;
                }


            }
            if (p == -1)
            {
                MessageBox.Show("Matricule de vehicule  Introuvable");

            }
            else
            {
                chassis.Text = ds.Tables["Vehicule"].Rows[p][1].ToString();
                Marque.Text = ds.Tables["Vehicule"].Rows[p][2].ToString();
                carrosserie.Text = ds.Tables["Vehicule"].Rows[p][3].ToString();
                Remorque.Text = ds.Tables["Vehicule"].Rows[p][4].ToString();
        

            }
        }
        //Button Supprimer // 
        private void Supprimer_Click(object sender, EventArgs e)
        {
            int p = 0;

            for (int i = 0; i < ds.Tables["Vehicule"].Rows.Count; i++)
            {
                if (immatricualtion.Text == ds.Tables["Vehicule"].Rows[i][0].ToString())
                {
                    ds.Tables["Vehicule"].Rows[i].Delete();
                    MessageBox.Show("Les Champs de Ce Code Sont Supprimé");
                    p = 1;
                    break;
                }
            }
            if (p == 0)
            {
                MessageBox.Show("Cet Vehicule n'existe pas ");

            }

        }

        // Button Enregistrer // 
        private void Enregistrer_Click(object sender, EventArgs e)
        {
            string req = "select * from Vehicule";
            SqlDataAdapter dr = new SqlDataAdapter(req, con);
            SqlCommandBuilder cmd = new SqlCommandBuilder(dr);
            dr.Update(ds, "Vehicule");
            MessageBox.Show("Les Champs sont Enregistrer");
        }


        //Nouveau//
        private void Nouveau_Click(object sender, EventArgs e)
        {
            immatricualtion.Text = "";
            chassis.Text = "";
            Marque.Text = "";
            carrosserie.Text = "";
            Remorque.Text = "";
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void immatricualtion_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
