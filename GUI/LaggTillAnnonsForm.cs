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
    public partial class LaggTillAnnonsForm : Form
    {
        private Controller controller;
        private Student inloggadStudent;
        public LaggTillAnnonsForm()
        {
            InitializeComponent();
        }
        public LaggTillAnnonsForm(Controller controller, Student student) : this()
        {
            this.controller = controller;
            this.inloggadStudent = student;

            cmbKurser.DataSource = controller.HämtaAllaKurser();
            cmbKurser.SelectedIndex = -1;

            cmbTyp.Items.Add("Kursbok");
            cmbTyp.Items.Add("Kompendium");
            cmbTyp.Items.Add("Digital resurs");
            cmbTyp.SelectedIndex = 0;
        }
        private void btnSpara_Click(object sender, EventArgs e)
        {
            string titel = txtTitel.Text;

            if (string.IsNullOrWhiteSpace(titel))
            {
                MessageBox.Show("Du måste ange en titel.");
                return;

            }

            if (!decimal.TryParse(txtPris.Text, out decimal pris) || pris <= 0)
            {
                MessageBox.Show("Du måste ange ett giltigt pris.");
                return;
            }

            if (cmbSkick.SelectedItem == null)
            {
                MessageBox.Show("Du måste välja bokens skick");
                return;
            }
            //Omvandla det valda skicket till AnnonsSkick
            AnnonsSkick skick = Enum.Parse<AnnonsSkick>(cmbSkick.SelectedItem.ToString());

            Kurs valdKurs = cmbKurser.SelectedItem as Kurs;

            if (valdKurs == null)
            {
                MessageBox.Show("Välj en kurs.");
                return;
            }

            string typ = cmbTyp.SelectedItem?.ToString() ?? "";
            string extra1 = txtExtra1.Text.Trim();
            string extra2 = txtExtra2.Text.Trim();
            string extra3 = txtExtra3.Text.Trim();

            if (extra1 == "" || extra2 == "")
            {
                MessageBox.Show("Fyll i båda uppgifterna för annonstypen.");
                return;
            }
            if (typ == "Kursbok" && string.IsNullOrWhiteSpace(extra3))
            {
                MessageBox.Show("Ange kursbokens upplaga.");
                return;
            }

            string resultat = controller.SkapaAnnons(
                titel, pris, skick, inloggadStudent,
                valdKurs, typ, extra1, extra2, extra3);

            MessageBox.Show(resultat);

            if (resultat == "Annonsen har skapats!")
            {
                this.Close();
            }
        }

        private void btnAvbryt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LaggTillAnnonsForm_Load(object sender, EventArgs e)
        {

        }

        private void cmbTyp_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTyp.SelectedIndex == 0)
            {
                lblExtra1.Text = "ISBN";
                lblExtra2.Text = "Författare";
                lblExtra3.Text = "Upplaga";

                lblExtra3.Visible = true;
                txtExtra3.Visible = true;
            }
            else if (cmbTyp.SelectedIndex == 1)
            {
                lblExtra1.Text = "Utgivningsår";
                lblExtra2.Text = "Antal sidor";

                lblExtra3.Visible = false;
                txtExtra3.Visible = false;
            }
            else if (cmbTyp.SelectedIndex == 2)
            {
                lblExtra1.Text = "Filformat";
                lblExtra2.Text = "Leveranssätt";

                lblExtra3.Visible = false;
                txtExtra3.Visible = false;
            }

            txtExtra1.Clear();
            txtExtra2.Clear();
            txtExtra3.Clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }

}
