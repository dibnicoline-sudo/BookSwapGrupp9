using Servicelager;
using Models;
using System;
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
    public partial class AdminForm : Form
    {
        private Controller controller;
        private Administrator administrator;
        public AdminForm(Controller controller, Administrator administrator)
        {
            InitializeComponent();


            this.controller = controller;
            this.administrator = administrator;

            lstAnnonser.DataSource = controller.HämtaAllaAnnonser();
        }

        private void btnTaBortAnnonser_Click(object sender, EventArgs e)
        {
            Annons annons = lstAnnonser.SelectedItem as Annons; //hämtar annonsen som användaren valt, selecteditem är det objekt som användaren markerat
            if (annons == null)
            {
                MessageBox.Show("Välj en annons först."); //om admin klickar på knappen utan att välja annons visas detta
                return;
            }
            DialogResult svar = MessageBox.Show( // frågar om admin är säker, dialogresult svar sparar vilket alternattiv användaren klickade på, 
                "Är du säker på att du vill ta bort annonsen?",
                "Bekräfta borttagning",
                MessageBoxButtons.YesNo);

            if (svar == DialogResult.Yes)
            {
                bool borttagen = controller.TaBortAnnons(annons, administrator);

                if (borttagen)
                {
                    lstAnnonser.DataSource = null;
                    lstAnnonser.DataSource = controller.HämtaAllaAnnonser(); //hämtar annonserna igen så att listan uppdateras

                    MessageBox.Show("Annonsen har tagits bort.");
                }
                else
                {
                    MessageBox.Show("Annonsen kunde inte tas bort");
                }
            }
        }

        private void btnHanteraKurser_Click(object sender, EventArgs e)
        {
            KurshanteringForm kursForm = new KurshanteringForm(controller);

            this.Hide();
            kursForm.ShowDialog();
            this.Show();
        }

        private void btnHanteraAnvandare_Click(object sender, EventArgs e)
        {
            AnvandarhanteringForm form = new AnvandarhanteringForm(controller);

            form.ShowDialog();
        }

        private void btnLoggaUt_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
