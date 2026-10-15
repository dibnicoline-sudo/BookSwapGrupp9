using Models;
using Servicelager;

namespace GUI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Databas databas = new Databas();
            Controller controller = new Controller(databas);
            
            //testdata
            Administrator admin = new Administrator("Anna", "Andersson", "anna@bookswap.se", "0764352290", "Anna2026");
            Student saljare = new Student(1, "Sara", "Andersson", "sara@gmail.com", "0701234567");
            Student kopare = new Student(2, "Alex", "Karlsson", "alex@gmail.com", "0709876543");

            Annons annons = new Annons(
                1,
                "C# Grundbok",
                250m,
                AnnonsSkick.BraSkick,
                AnnonsStatus.Reserverad,
                DateTime.Now,
                saljare
            );
            Annons annons2 = new Annons(
                2,
                "Java Grundbok",
                180m,
                AnnonsSkick.BraSkick,
                AnnonsStatus.TillSalu,
                DateTime.Now,
                saljare);

            databas.LäggTillAnnons(annons2);

            Affar affar = new Affar(1, kopare, annons);
            affar.UppdateraAffarStatus(AffarStatus.Reserverad);

            databas.LäggTillStudent(saljare);
            databas.LäggTillStudent(kopare);
            databas.LäggTillAnnons(annons);
            databas.LäggTillAffar(affar);
            databas.LäggTillAdministrator(admin);

            Application.Run(new LoginForm(controller));
        }
    }
}