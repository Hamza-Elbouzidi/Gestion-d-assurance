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
    public partial class Imprimer : Form
    {
        public Imprimer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CrystalReport2 cr2 = new CrystalReport2();
            crystalReportViewer1.ReportSource = cr2;
            crystalReportViewer1.Refresh();
        }

        private void Imprimer_Load(object sender, EventArgs e)
        {

        }
    }
}
