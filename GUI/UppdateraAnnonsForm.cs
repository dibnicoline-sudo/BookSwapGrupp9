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

    public partial class UppdateraAnnonsForm : Form
    {
        private Controller controller;
        private Annons valdAnnons;
        private Student inloggadStudent;
        public UppdateraAnnonsForm()
        {
            InitializeComponent();
        }

        public UppdateraAnnonsForm(Controller controller, Annons annons, Student student) : this()
        {
            this.controller = controller;
            valdAnnons = annons;
            inloggadStudent = student;

            txtTitel.Text = annons.Titel;
            txtPris.Text = annons.Pris.ToString();
            cmbSkick.SelectedItem = annons.Skick.ToString();
        }

        private void btnSparaÄndringar_Click(object sender, EventArgs e)
        {
            string titel = txtTitel.Text;

            //kontrollera titeln
            if (string.IsNullOrWhiteSpace(titel))
            {
                MessageBox.Show("Du måste ange en titel.");
                return;
            }
            if (!decimal.TryParse(txtPris.Text, out decimal pris) || pris <= 0)
            {
                MessageBox.Show("Du måste ange ett gilitigt pris.");
                return;
            }

            if (cmbSkick.SelectedItem == null || !Enum.TryParse<AnnonsSkick>(cmbSkick.SelectedItem.ToString(), out AnnonsSkick skick))
            {
                MessageBox.Show("Du måste välja ett giltigt skick");
                return;
            }

            string resultat = controller.UppdateraAnnons(valdAnnons, inloggadStudent, titel, pris, skick);

            MessageBox.Show(resultat);
            if (resultat == "Annonsen har uppdaterats!")
            {
                this.Close();
            }
          
        }

        private void btnAvbryt_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
