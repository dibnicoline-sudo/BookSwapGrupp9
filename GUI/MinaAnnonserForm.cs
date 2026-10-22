using Servicelager;
using System;
using Models;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Models;
using Servicelager;

namespace GUI
{
    public partial class MinaAnnonserForm : Form
    {
        private Controller controller;
        private Student inloggadStudent;

        public MinaAnnonserForm()
        {
            InitializeComponent();
        }
        public MinaAnnonserForm(Controller controller, Student student) : this()
        {

            this.controller = controller;
            this.inloggadStudent = student;

            VisaMinaAnnonser();
        }
        private void VisaMinaAnnonser()
        {
            lstMinaAnnonser.Items.Clear();
            List<Annons> annonser = inloggadStudent.HämtaMinaAnnonser();

            foreach (Annons annons in annonser)
            {
                lstMinaAnnonser.Items.Add(annons);
            }

        }

        private void lblRubrik_Click(object sender, EventArgs e)
        {

        }

        private void btnTillbaka_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLaggTillAnnons_Click(object sender, EventArgs e)
        {
            LaggTillAnnonsForm laggTillForm = new LaggTillAnnonsForm(controller, inloggadStudent);

            laggTillForm.ShowDialog();

            VisaMinaAnnonser();
        }

        private void btnTillbaka_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUppdateraAnnons_Click(object sender, EventArgs e)
        {
            if (lstMinaAnnonser.SelectedItem == null)
            {
                MessageBox.Show("Du måste välja en annons att uppdatera.");
                return;

            }
            //Hämta den markerade annonsen
            Annons valdAnnons = (Annons)lstMinaAnnonser.SelectedItem;

            UppdateraAnnonsForm uppdateraForm = new UppdateraAnnonsForm(controller, valdAnnons, inloggadStudent);
            uppdateraForm.ShowDialog();

            //Updatera liostan när formuläret stängs
            VisaMinaAnnonser();
        }

        private void btnTaBortAnnons_Click(object sender, EventArgs e)
        {
            if (lstMinaAnnonser.SelectedItem == null)
            {
                MessageBox.Show("Du måste välja en annons att ta bort.");
                return;
            }

            Annons valdAnnons = (Annons)lstMinaAnnonser.SelectedItem;

            DialogResult svar = MessageBox.Show("Är du säker på att du vill ta bort annonen?", "Bekräfta borttagning",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (svar == DialogResult.Yes)
            {
                bool borttagen = controller.TaBortMinAnnons(valdAnnons, inloggadStudent);

                if (borttagen)
                {
                    MessageBox.Show("Annonsen har tagits bort!");
                    VisaMinaAnnonser();
                }
                else
                {
                    MessageBox.Show("Det gick inte att ta bort annonsen");
                }
            }
        }
    }
}

