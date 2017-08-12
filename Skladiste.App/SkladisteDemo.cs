using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Skladiste.App
{
    public partial class SkladisteDemo : Form
    {

        public SkladisteDemo()
        {
            InitializeComponent();
        }

        private void proizvodiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Proizvodi proizvodi = new Proizvodi();
            proizvodi.MdiParent = this;
            proizvodi.Show();
        }

        private void SkladisteDemo_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
