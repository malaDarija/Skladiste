using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Skladiste.App
{
    public partial class Prijava : Form
    {
        public Prijava()
        {
            InitializeComponent();
        }

        private void ocistiButton_Click(object sender, EventArgs e)
        {
            korisnickoImeTextBox.Clear();
            lozinkaTextBox.Clear();

            korisnickoImeTextBox.Focus();
        }

        private void prijavaButton_Click(object sender, EventArgs e)
        {
            //TO DO: dodati provjeru korisničkog imena i lozinke (validaciju korisnika)
            SqlConnection konekcija = new SqlConnection("Data Source=DESKTOP-0LIGBMA\\SQLEXPRESS;Initial Catalog=Skladiste;Integrated Security=True");
            SqlDataAdapter dataAdapter = new SqlDataAdapter(@"SELECT *
                                         FROM [Skladiste].[dbo].[Prijava] WHERE KorisnickoIme = '" + korisnickoImeTextBox.Text + "' AND Lozinka = '" + lozinkaTextBox.Text + "'", konekcija);
            DataTable tablica = new DataTable();
            dataAdapter.Fill(tablica);

            if (tablica.Rows.Count == 1)
            {
                this.Hide();
                SkladisteDemo demo = new SkladisteDemo();
                demo.Show(); 
            }
            else
            {
                MessageBox.Show("Unijeli ste pogrešno korisničko ime ili lozinku!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ocistiButton_Click(sender, e);
            }
        }
    }
}
