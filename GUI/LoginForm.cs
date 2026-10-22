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
    public partial class LoginForm : Form
    {
        private Controller controller;
        public LoginForm(Controller controller)
        {
            InitializeComponent();
            this.controller = controller;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void btnLoggaIn_Click(object sender, EventArgs e)
        {
            string epostadress = txtEpost.Text;
            string losenord = txtLosenord.Text;

            //försöka logga in som administatör
            Administrator? admin = controller.LoggaInAdministrator(epostadress, losenord); //skickar uppgifter till Controller, som kontrollerar dem mot administratör i datasen

            if (admin != null) //kontroll om inloggning misslyckades
            {
                MessageBox.Show("Välkommen " + admin.Fornamn + "!");
                AdminForm adminFonster = new AdminForm(controller, admin); //skapar administratörerns eget förnser, skickar samma controller så admin kan se annonserna i databasen
                adminFonster.Show();
                return;
            }

            Student? student = controller.LoggaInStudent(epostadress, losenord);
            if (student != null)
            {
                StudentForm studentForm = new StudentForm(controller, student);

                this.Hide();
                studentForm.ShowDialog();
                this.Show(); //visar inloggningsfönstret igen när studentsidan stängs

                return;
            }

            MessageBox.Show("Fel e-postadress eller lösenord");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistreraDig_Click(object sender, EventArgs e)
        {
            RegisteringStudentForm registreringsFonster = new RegisteringStudentForm(controller);

            registreringsFonster.ShowDialog();
        }
    }
}
