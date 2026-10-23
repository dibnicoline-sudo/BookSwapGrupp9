using Models;
using Servicelager;

namespace GUI
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Databas databas = new Databas();
            Controller controller = new Controller(databas);

            //testdata
            Administrator admin = new Administrator("Anna", "Andersson", "anna@bookswap.se", "0764352290", "Anna2026");
            Student kopare = new Student(1, "Sara", "Andersson", "sara@gmail.com", "0701234567", "Sara2026");
            Student saljare = new Student(2, "Alex", "Karlsson", "alex@gmail.com", "0709876543", "Alex2026");
            Kurs kurs1 = new Kurs("C10B1B", "Objektorienterad systemutveckling 1");
            Kurs kurs2 = new Kurs("B187W9N", "Grundläggande programmering Java");
            Kurs kurs3 = new Kurs("G08N2N", "Grundläggande programmering C#");

            Annons annons1 = new Kursbok(
                1,
                "C# Grundbok",
                250m,
                AnnonsSkick.BraSkick,
                AnnonsStatus.TillSalu,
                DateTime.Now,
                saljare, "98726839", "Anna Svenssson", 3, kurs1
            );
            Annons annons2 = new Kompendium(
                2,
                "Java Grundbok",
                180m,
                AnnonsSkick.BraSkick,
                AnnonsStatus.TillSalu,
                DateTime.Now,
                kopare,2023,90, kurs1);

            Annons annons3 = new DigitalResurs(3,
                "Python Grundbok",
                320m,
                AnnonsSkick.Nyskick,
                AnnonsStatus.TillSalu,
                DateTime.Now,
                saljare, "PDF", "E-post", kurs2);

            

            Affar affar = new Affar(1, kopare, annons1);
            

            databas.LäggTillStudent(saljare);
            databas.LäggTillStudent(kopare);

            controller.LäggTillAnnons(annons1);
            controller.LäggTillAnnons(annons2);
            controller.LäggTillAnnons(annons3);

            databas.LäggTillAffar(affar);
            databas.LäggTillAdministrator(admin);

            databas.LäggTillKurs(kurs1);
            databas.LäggTillKurs(kurs2);
            databas.LäggTillKurs(kurs3);

            Application.Run(new LoginForm(controller));
        }
    }
}