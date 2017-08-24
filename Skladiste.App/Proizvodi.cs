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
    public partial class Proizvodi : Form
    {
        public Proizvodi()
        {
            InitializeComponent();
            UcitajPodatke();
        }

        private void Proizvodi_Load(object sender, EventArgs e)
        {
            statusProizvodaComboBox.SelectedIndex = 0;
        }

        private void dodajButton_Click(object sender, EventArgs e)
        {
            SqlConnection konekcija = new SqlConnection("Data Source=DESKTOP-0LIGBMA\\SQLEXPRESS;Initial Catalog=Skladiste;Integrated Security=True");
            // Logika
            konekcija.Open();
            bool status = false;
            if (statusProizvodaComboBox.SelectedIndex == 0)
            {
                status = true;
            }
            else
            {
                status = false;
            }

            var sqlQuery = "";

            if(ProvjeriProizvod(konekcija, sifraProizvodaTextBox.Text))
            {
                sqlQuery = @"UPDATE [Proizvodi] SET [NazivProizvoda] = '" + nazivProizvodaTextBox.Text + "' ,[StatusProizvoda] = '" + status + "' WHERE [SifraProizvoda] = '" + sifraProizvodaTextBox.Text + "'";
            }
            else
            {
                sqlQuery = @"INSERT INTO [Skladiste].[dbo].[Proizvodi] ([SifraProizvoda],[NazivProizvoda],[StatusProizvoda]) VALUES
                            ('" + sifraProizvodaTextBox.Text + "','" + nazivProizvodaTextBox.Text + "','" + status + "')";
            }

            SqlCommand naredba = new SqlCommand(sqlQuery, konekcija);
            naredba.ExecuteNonQuery();
            konekcija.Close();

            // čitanje podataka
            UcitajPodatke();
        }

        private bool ProvjeriProizvod(SqlConnection konekcija, string sifraProizvoda)
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT 1 FROM [Proizvodi] WHERE [SifraProizvoda] ='" + sifraProizvoda + "'", konekcija);
            DataTable tablica = new DataTable();
            dataAdapter.Fill(tablica);

            if (tablica.Rows.Count > 0)
                return true;
            else
                return false;
        }

        public void UcitajPodatke()
        {
            SqlConnection konekcija = new SqlConnection("Data Source=DESKTOP-0LIGBMA\\SQLEXPRESS;Initial Catalog=Skladiste;Integrated Security=True");
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM [Skladiste].[dbo].[Proizvodi]", konekcija);
            DataTable tablica = new DataTable();
            dataAdapter.Fill(tablica);

            prikazProizvoda.Rows.Clear();
            foreach (DataRow item in tablica.Rows)
            {
                int n = prikazProizvoda.Rows.Add();

                prikazProizvoda.Rows[n].Cells[0].Value = item["SifraProizvoda"].ToString();
                prikazProizvoda.Rows[n].Cells[1].Value = item["NazivProizvoda"].ToString();

                if ((bool)item["StatusProizvoda"])
                {
                    prikazProizvoda.Rows[n].Cells[2].Value = "Aktivan";
                }
                else
                {
                    prikazProizvoda.Rows[n].Cells[2].Value = "Neaktivan";
                }
            }
        }

        private void prikazProizvoda_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            sifraProizvodaTextBox.Text = prikazProizvoda.SelectedRows[0].Cells[0].Value.ToString();
            nazivProizvodaTextBox.Text = prikazProizvoda.SelectedRows[0].Cells[1].Value.ToString();

            if (prikazProizvoda.SelectedRows[0].Cells[2].Value.ToString() == "Aktivan")
            {
                statusProizvodaComboBox.SelectedIndex = 0;
            }
            else
            {
                statusProizvodaComboBox.SelectedIndex = 1;
            }
        }

        private void izbrisiButton_Click(object sender, EventArgs e)
        {
            SqlConnection konekcija = new SqlConnection("Data Source=DESKTOP-0LIGBMA\\SQLEXPRESS;Initial Catalog=Skladiste;Integrated Security=True");
            var sqlQuery = "";

            if (ProvjeriProizvod(konekcija, sifraProizvodaTextBox.Text))
            {
                konekcija.Open();
                sqlQuery = @"DELETE FROM [Proizvodi] WHERE [SifraProizvoda] = '" + sifraProizvodaTextBox.Text + "'";
                SqlCommand naredba = new SqlCommand(sqlQuery, konekcija);
                naredba.ExecuteNonQuery();
                konekcija.Close();
            }
            else
            {
                MessageBox.Show("Ne postoji proizvod s tom šifrom proizvoda..!");
            }
            
            // čitanje podataka
            UcitajPodatke();
        }
    }
}
