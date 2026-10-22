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
    public partial class StudentForm : Form
    {
        private Controller controller;
        private Student inloggadStudent;

        public StudentForm(Controller controller, Student student)
        {
            InitializeComponent();
            this.controller = controller;
            this.inloggadStudent = student;

            lblValkommen.Text = $"Välkommen {student.Fornamn}!";
        }

        private void btnVisaAnnonser_Click(object sender, EventArgs e)
        {
            VisaAnnonserForm annonserForm = new VisaAnnonserForm(controller, inloggadStudent);

            this.Hide();
            annonserForm.ShowDialog();
            this.Show();
        }

        private void btnLoggaUt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinaAnnonser_Click(object sender, EventArgs e)
        {
            MinaAnnonserForm minaAnnonserForm = new MinaAnnonserForm(controller, inloggadStudent);

            this.Hide();
            minaAnnonserForm.ShowDialog();
            this.Show();
        }

        private void btnMinaAffarer_Click(object sender, EventArgs e)
        {
            MinaAffarerForm minaAffarerForm = new MinaAffarerForm(controller, inloggadStudent);

            this.Hide();

            minaAffarerForm.ShowDialog(); //visa fönster Mina affärer
            this.Show();
        }
    }
}
