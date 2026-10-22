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
    public partial class MinaAffarerForm : Form
    {
        private Controller controller;
        private Student inloggadStudent;
        public MinaAffarerForm()
        {
            InitializeComponent();
        }

        public MinaAffarerForm(Controller controller, Student student) : this()
        {
            this.controller = controller;
            this.inloggadStudent = student;

            VisaMinaAffarer();
        }

        private void VisaMinaAffarer()
        {
            lstAffarer.Items.Clear();

            List<Affar> affarer = controller.HämtaAllaAffarer();

            foreach (Affar affar in affarer)
            {
                if (affar.Säljare.StudentId == inloggadStudent.StudentId)
                {
                    lstAffarer.Items.Add(affar);
                }
            }
        }

        private void btnTillbaka_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBekraftaKop_Click(object sender, EventArgs e)
        {
            Affar valdAffar = lstAffarer.SelectedItem as Affar; //hämtar affären som säljaren markerat

            if(valdAffar == null)
            {
                MessageBox.Show("Välj en affär först.");
                return;
            }

            DialogResult svar = MessageBox.Show("Är du säker på att köpet är genomfört?",
                "Bäkräfta köp", MessageBoxButtons.YesNo);
            if (svar == DialogResult.Yes)
            {
                string resultat = controller.BekräftaKöp(valdAffar, inloggadStudent);

                MessageBox.Show(resultat);
                VisaMinaAffarer(); //uppdaterar listan så att affären visas som genomförd
            }
        }
    }
}
