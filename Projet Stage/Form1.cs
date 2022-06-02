using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet_Stage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        private void Form1_Load(object sender, EventArgs e)
        {
            laGestionToolStripMenuItem.Enabled = false;
            deconnecterToolStripMenuItem.Enabled = false;
        }

        private void connexionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login lg = new Login(this);
            lg.Show();
           
        }

        private void gestionDeClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Gestion_de_Client gs = new Gestion_de_Client();
            gs.Show();
        }

        private void deconnecterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            laGestionToolStripMenuItem.Enabled = false;
            deconnecterToolStripMenuItem.Enabled = false;


        }

        private void gestionDeVehiculesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Gestion_des_Vehicules gv = new Gestion_des_Vehicules();
            gv.Show();
        }

        private void gestionDeConducteurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Gestion_de_conducteur gc = new Gestion_de_conducteur();
            gc.Show();
        }

        private void atlantaSanadToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void imprimmerToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void form2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Imprimer f2 = new Imprimer();
            f2.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
