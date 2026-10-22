using System;
using Models;
using Servicelager;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class KurshanteringForm : Form
    {
        private Controller controller;
        public KurshanteringForm()
        {
            InitializeComponent();
        }

        public KurshanteringForm(Controller controller) : this()
        {
            this.controller = controller;
            VisaKurser();
        }

        public void VisaKurser()
        {
            lstKurser.DataSource = null;
            lstKurser.DataSource = controller.HämtaAllaKurser(); //hämta kuserna från databasen
        }

        private void btnTillbaka_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLaggTillKurs_Click(object sender, EventArgs e)

        {
            string kurskod = txtKurskod.Text.Trim(); //trim tar bort mellanslag i slutet
            string kursnamn = txtKursnamn.Text.Trim();

            if (kurskod == "" || kursnamn == "")
            {
                MessageBox.Show("Fyll i både kurskod och kursnamn.");
                return;
            }

            string resultat = controller.LäggTillKurs(kurskod, kursnamn);

            MessageBox.Show(resultat);
            VisaKurser();
        }

        private void btnUppdateraKurs_Click(object sender, EventArgs e)
        {
            Kurs valdKurs = lstKurser.SelectedItem as Kurs;

            if (valdKurs == null)
            {
                MessageBox.Show("Välj en kurs först.");
                return;
            }

            string nyttNamn = txtKursnamn.Text.Trim();

            if (nyttNamn == "")
            {
                MessageBox.Show("Ange ett kursnamn.");
                return;
            }

            string resultat = controller.UppdateraKurs(valdKurs, nyttNamn);

            MessageBox.Show(resultat);
            VisaKurser();
        }

        private void btnTaBortKurs_Click(object sender, EventArgs e)

        {
            Kurs valdKurs = lstKurser.SelectedItem as Kurs;

            if (valdKurs == null)
            {
                MessageBox.Show("Välj en kurs först.");
                return;
            }

            DialogResult svar = MessageBox.Show(
                "Är du säker på att du vill ta bort kursen?",
                "Bekräfta borttagning",
                MessageBoxButtons.YesNo);

            if (svar == DialogResult.Yes)
            {
                string resultat = controller.TaBortKurs(valdKurs);

                MessageBox.Show(resultat);
                VisaKurser();
            }
        }

        private void lstKurser_SelectedIndexChanged(object sender, EventArgs e) //textrutona fylls automatisk när en kurs väljs
        {
            Kurs valdKurs = lstKurser.SelectedItem as Kurs;

            if (valdKurs != null)
            {
                txtKurskod.Text = valdKurs.Kurskod;
                txtKursnamn.Text = valdKurs.Kursnamn;
            }
        }
    }
    
}
