using Models;
using Servicelager;

namespace GUI
{
    public partial class Form1 : Form
    {
        private Controller controller;


        public Form1(Controller controller)
        {
            InitializeComponent();
            this.controller = controller;

            lstAffarer.DataSource = controller.HämtaAllaAffarer();
        }

        private void btnBekraftaKop_Click(object sender, EventArgs e)
        {
            Affar affar = lstAffarer.SelectedItem as Affar; //selecteditem hämtar objektet som användaren markerat i listan.
                                                            //as Affar kontrollerar om det valda objektet är en Affar och ger oss en referens till det.

            if (affar == null)
            {
                MessageBox.Show("Välj en affär först.");
                return;
            }

            string resultat = controller.BekräftaKöp(affar); //skickar själva affärobjketet
            MessageBox.Show(resultat); //visar om köpet kunde bekräftas

            lstAffarer.DataSource = null; //tömmer listans koppling till datan
            lstAffarer.DataSource = controller.HämtaAllaAffarer(); //kopplar loistan till affärerna igen så den visar deras nya status
        }

        private void btnTaBortAnnons_Click(object sender, EventArgs e) //händelsemetod som körs automatiskt när någon klickar på knappen Ta bort annons
        {
        }
    }
}
