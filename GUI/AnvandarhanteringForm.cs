using System;
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
    public partial class AnvandarhanteringForm : Form
    {
        private Controller controller;
        public AnvandarhanteringForm()
        {
            InitializeComponent();
        }

        public AnvandarhanteringForm(Controller controller) : this()
        {
            this.controller = controller;
            VisaStudenter();
        }

        private void VisaStudenter()
        {
            lstStudenter.DataSource = null;
            lstStudenter.DataSource = controller.HämtaAllaStudenter();
            lstStudenter.ClearSelected();
        }

        private void btnLaggTill_Click_1(object sender, EventArgs e)
        {
            string resultat = controller.RegistreraStudent(
                txtFornamn.Text.Trim(),
                txtEfternamn.Text.Trim(),
                txtEpost.Text.Trim(),
                txtTelefon.Text.Trim(),
                txtLosenord.Text);

            MessageBox.Show(resultat);
            VisaStudenter();
        }

        private void btnUppdatera_Click(object sender, EventArgs e)
        {
            Student student = lstStudenter.SelectedItem as Student;

            string resultat = controller.AdminUppdateraStudent(
                student,
                txtFornamn.Text.Trim(),
                txtEfternamn.Text.Trim(),
                txtEpost.Text.Trim(),
                txtTelefon.Text.Trim());

            MessageBox.Show(resultat);
            VisaStudenter();
        }

        private void btnTaBort_Click(object sender, EventArgs e)
        {
            Student student = lstStudenter.SelectedItem as Student;

            if (student == null)
            {
                MessageBox.Show("Välj en student först.");
                return;
            }

            DialogResult svar = MessageBox.Show(
                "Är du säker på att du vill ta bort studenten?",
                "Bekräfta borttagning",
                MessageBoxButtons.YesNo);

            if (svar == DialogResult.Yes)
            {
                string resultat = controller.AdminTaBortStudent(student);
                MessageBox.Show(resultat);
                VisaStudenter();
            }
        }

        private void lstStudenter_SelectedIndexChanged_1(
            object sender, EventArgs e)
        {
            Student student = lstStudenter.SelectedItem as Student;

            if (student != null)
            {
                txtFornamn.Text = student.Fornamn;
                txtEfternamn.Text = student.Efternamn;
                txtEpost.Text = student.Epostadress;
                txtTelefon.Text = student.Telefonnummer;
                txtLosenord.Clear();
            }
        }

        private void btnTillbaka_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
