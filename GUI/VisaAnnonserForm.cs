using Models;
using Servicelager;
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
    public partial class VisaAnnonserForm : Form
    {
        private Controller controller;
        private Student inloggadStudent;
        public VisaAnnonserForm(Controller controller, Student student)
        {
            InitializeComponent();
            this.controller = controller;
            this.inloggadStudent = student;

            VisaTillgangligaAnnonser();
        }

        private void VisaTillgangligaAnnonser()
        {
            lstAnnonser.Items.Clear();

            List<Annons> annonser = controller.ListaAnnonser();
            foreach (Annons annons in annonser)
            {
                lstAnnonser.Items.Add(annons);
            }
        }
        private void btnTillbaka_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReserveraAnnons_Click(object sender, EventArgs e)
        {
            if (lstAnnonser.SelectedItem == null)
            {
                MessageBox.Show("Du måste välja en annons först");
                return;
            }
            Annons valdAnnons = (Annons)lstAnnonser.SelectedItem;

            string resultat = controller.ReserveraAnnons(valdAnnons.AnnonsId, inloggadStudent);
            MessageBox.Show(resultat);
            VisaTillgangligaAnnonser();
        }

        private void btnSok_Click(object sender, EventArgs e)
        {
            string soktext = txtSok.Text.Trim(); //texten hämtas

            lstAnnonser.Items.Clear(); //den gamla listan töms

            List<Annons> resultat = controller.SokAnnonser(soktext); //hämtar annonser som matchar sökningen

            foreach (Annons annons in resultat)
            {
                lstAnnonser.Items.Add(annons);
            }
            if (resultat.Count == 0)
            {
                MessageBox.Show("Inga annonser matchade din sökning.");
            }
        }
    }
    
}
