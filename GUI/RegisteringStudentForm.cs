using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Models;
using Servicelager;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class RegisteringStudentForm : Form
    {
        private Controller controller;
        public RegisteringStudentForm(Controller controller)
        {
            InitializeComponent();
            this.controller = controller;
        }

        private void RegisteringStudentForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fornamn = txtFornamn.Text;
            string efternamn = txtEfternamn.Text;
            string epostadress = txtEpost.Text;
            string telefonnummer = txtTelefonnummer.Text;
            string losenord = txtLosenord.Text;

            string resultat = controller.RegistreraStudent(fornamn, efternamn, epostadress, telefonnummer, losenord);

            MessageBox.Show(resultat);

            if (resultat == "Registreringen lyckades!")
            {
                this.Close(); //stänger registreringsfönstret
            }
        }
    }
}
