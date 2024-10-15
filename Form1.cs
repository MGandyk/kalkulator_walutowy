using System;
using System.Windows.Forms;

namespace Kalkulator_walutowy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal kwota_do_przewalutowania;

            if (!decimal.TryParse(textBox1_wprowadz_kwote_do_przealutowania.Text, out kwota_do_przewalutowania))
            {
                // Jak nie wyjdzie, komunikat o błędzie
                MessageBox.Show("Wprowadź poprawną liczbę w polu kwoty do przewalutowania.", "Błąd!", MessageBoxButtons.OK);
                return;
            }

            if (listDostepneWaluty.SelectedItem == null)
            {
                MessageBox.Show("Proszę wybrać walutę z listy.");
                return;
            }

            string wybrana_waluta = listDostepneWaluty.SelectedItem.ToString();

            decimal PLNtoUSD = 0.25m;

            decimal kurs_wybranej_waluty_do_usd = 0;

            switch (wybrana_waluta)
            {
                case "EUR":
                    kurs_wybranej_waluty_do_usd = 0.91m;
                    break;
                case "CHF":
                    kurs_wybranej_waluty_do_usd = 0.86m;
                    break;
                case "GBP":
                    kurs_wybranej_waluty_do_usd = 0.77m;
                    break;
                default:
                    MessageBox.Show("Niepoprawna waluta. Wybierz EUR, CHF lub GBP.");
                    return;
            }

            decimal wynik = kwota_do_przewalutowania * PLNtoUSD * kurs_wybranej_waluty_do_usd;

            labelPrzewalutowano.Text = wynik.ToString("F2") + " " + wybrana_waluta;

        }

        private void textBox1_wprowadz_kwote_do_przealutowania_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                button1_Click(sender, e);
            }

        }

        private void listDostepneWaluty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                button1_Click(sender, e);
            }
        }

    }
}

