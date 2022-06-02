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
    public partial class Gestion_de_Client : Form
    {

        SqlCommandBuilder cmd = new SqlCommandBuilder();
        SqlDataAdapter dr = new SqlDataAdapter();
        public Gestion_de_Client()
        {
            InitializeComponent();
        }
        //Chaine de connexion
        static string ch = @"Data Source=DESKTOP-2CE72MO\SQLEXPRESS;Initial Catalog=AtlantaSanad;Integrated Security=True";
        SqlConnection con = new SqlConnection(ch);
        DataSet ds = new DataSet();


        
        private void NomTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        //Button Ajouter
        private void Ajout_Click(object sender, EventArgs e)

        {

            int p = 0;

            if (CodeTextBox.Text == "" || NomTextBox.Text == "" || CinTextBox.Text == "" || N_PatanteTextBox.Text == "" || N_RcTextBox.Text == "" || AdresseTextBox.Text == "" ||
                TélephoneTextBox.Text == "" || ActivitéTextBox.Text == "" || N_CnssTextBox.Text == "" || EmailTextBox.Text == "" || QualitécomboBox.Text == "" || ProfessioncomboBox.Text == "")
            {
                MessageBox.Show("Tous les Champs doit etre insére");
            }
            else
            {
                int t = 0;
               
                for ( int i=0;i< ds.Tables["Client"].Rows.Count; i++)
                {
                   
                    if (CodeTextBox.Text == ds.Tables["Client"].Rows[i][0].ToString())
                    {
                        t = 1;
                        break;
                        
                    }
                }
                {
                    if(t == 0)
                
               
                {
                        DataRow l;
                        l = ds.Tables["Client"].NewRow();
                        l[0] =  CodeTextBox.Text;
                        l[1] =  NomTextBox.Text;
                        l[2] =  CinTextBox.Text;
                        l[3] =  N_PatanteTextBox.Text;
                        l[4] =  N_RcTextBox.Text;
                        l[5] =  AdresseTextBox.Text;
                        l[6] =  int.Parse(TélephoneTextBox.Text);
                        l[7] =  ActivitéTextBox.Text;
                        l[8] =  N_CnssTextBox.Text;
                        l[9] =  EmailTextBox.Text;
                        l[10]=  QualitécomboBox.Text;
                        l[11]=  ProfessioncomboBox.Text;
                        ds.Tables["Client"].Rows.Add(l);
                        MessageBox.Show("Bien Ajouter");
                        p = 1;
                        
                    }
                    if (p==0)
                    {
                        MessageBox.Show("Ce Code Déja Existe"); 
                    }
            }
             }
    }

        //Button Modifier
        private void Modif_Click(object sender, EventArgs e)
        {
            int p = 0;

            for (int i = 0; i < ds.Tables["Client"].Rows.Count; i++) 
                {

              
                if (CodeTextBox.Text == ds.Tables["Client"].Rows[i][0].ToString())
                {
                    ds.Tables["Client"].Rows[i][1] =  NomTextBox.Text;
                    ds.Tables["Client"].Rows[i][2] =  CinTextBox.Text;
                    ds.Tables["Client"].Rows[i][3] =  N_PatanteTextBox.Text;
                    ds.Tables["Client"].Rows[i][4] =  N_RcTextBox.Text;
                    ds.Tables["Client"].Rows[i][5] =  AdresseTextBox.Text;
                    ds.Tables["Client"].Rows[i][6] =  int.Parse(TélephoneTextBox.Text);
                    ds.Tables["Client"].Rows[i][7] =  ActivitéTextBox.Text;
                    ds.Tables["Client"].Rows[i][8] =  N_CnssTextBox.Text;
                    ds.Tables["Client"].Rows[i][9] =  EmailTextBox.Text;
                    ds.Tables["Client"].Rows[i][10]=  QualitécomboBox.Text;
                    ds.Tables["Client"].Rows[i][11]=  ProfessioncomboBox.Text;
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

        //Button Supprimer
        private void Supprim_Click(object sender, EventArgs e)
        {
            int p = 0;

            for (int i =0; i<ds.Tables["Client"].Rows.Count;i++)
            {
                if (CodeTextBox.Text == ds.Tables["CLient"].Rows[i][0].ToString())
                {
                    ds.Tables["Client"].Rows[i].Delete();
                    MessageBox.Show("Les Champs de Ce Code Sont Supprimé");
                    p = 1;
                    break;
                }
            }
            if ( p == 0)
            {
                        MessageBox.Show("Ce Code n'existe Pas");
                
            }

        }
    


        //Button Nouveau
        private void Vid_Click(object sender, EventArgs e)
        {
            CodeTextBox.Text ="";
            NomTextBox.Text= "";
            CinTextBox.Text= "";
            N_PatanteTextBox.Text= "";
            N_RcTextBox.Text= "";
            AdresseTextBox.Text= "";
            TélephoneTextBox.Text= "";
            ActivitéTextBox.Text= "";
            N_CnssTextBox.Text= "";
            EmailTextBox.Text= "";
            QualitécomboBox.Text= "";
            ProfessioncomboBox.Text= "";

        }
        // Button Enregistrer
        private void Enregistrer_Click(object sender, EventArgs e)
        {
            string req = "select * from Client";
            SqlDataAdapter dr = new SqlDataAdapter(req, con);
            SqlCommandBuilder cmd = new SqlCommandBuilder(dr);
            dr.Update(ds, "Client");
            MessageBox.Show("Les Champs sont Enregistrer");
        }
        //Button Rechercher
        private void Rechercher_Click(object sender, EventArgs e)
        {
          
            int p = -1;
            for (int i = 0; i < ds.Tables["Client"].Rows.Count; i++)
            {
                if (CodeTextBox.Text == ds.Tables["Client"].Rows[i][0].ToString())
                {
                    p = i;
                    break;
                }


            }
            if (p == -1)
            {
                MessageBox.Show("Code Client Introuvable");

            }
            else
            {
                NomTextBox.Text = ds.Tables["Client"].Rows[p][1].ToString();
                CinTextBox.Text = ds.Tables["Client"].Rows[p][2].ToString();
                N_PatanteTextBox.Text = ds.Tables["Client"].Rows[p][3].ToString();
                N_RcTextBox.Text = ds.Tables["Client"].Rows[p][4].ToString();
                AdresseTextBox.Text = ds.Tables["Client"].Rows[p][5].ToString();
                TélephoneTextBox.Text = ds.Tables["Client"].Rows[p][6].ToString();
                ActivitéTextBox.Text = ds.Tables["Client"].Rows[p][7].ToString();
                N_CnssTextBox.Text = ds.Tables["Client"].Rows[p][8].ToString();
                EmailTextBox.Text = ds.Tables["Client"].Rows[p][9].ToString();
                QualitécomboBox.Text = ds.Tables["Client"].Rows[p][10].ToString();
                ProfessioncomboBox.Text = ds.Tables["Client"].Rows[p][11].ToString();
            }


        }

        //Remplissage de combobox
        private void Gestion_de_Client_Load(object sender, EventArgs e)
        {
            QualitécomboBox.Items.Add("Honnêteté");
            QualitécomboBox.Items.Add("Empathie");
            QualitécomboBox.Items.Add("Optimisme");
            QualitécomboBox.Items.Add("Force de persuasion");
            QualitécomboBox.Items.Add("Persévérance");
            QualitécomboBox.Items.Add("Rigueur");


            ProfessioncomboBox.Items.Add("Ingénieur industriel");
            ProfessioncomboBox.Items.Add("Comptable");
            ProfessioncomboBox.Items.Add("Manager des opérations");
            ProfessioncomboBox.Items.Add("Responsable financier");
            ProfessioncomboBox.Items.Add("Physiothérapeute");
            ProfessioncomboBox.Items.Add("Police");
            ProfessioncomboBox.Items.Add("Médecin");
            ProfessioncomboBox.Items.Add("Armée");
           
            //string req = "select * from Client";
            //SqlDataAdapter dr = new SqlDataAdapter(req, con);
            //dr.Fill(ds, "Client");




            //Remplissage DataGridView//
            {
                string req1 = "select * from Client";
                SqlDataAdapter dr1 = new SqlDataAdapter(req1, con);
                dr1.Fill(ds, "Client");

                dataGridView1.DataSource = ds.Tables["Client"];
                    
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void QualitécomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

}



