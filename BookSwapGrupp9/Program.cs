namespace BookSwapGrupp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Controller controller = new Controller();

            Student student1 = new Student(1,"Sara", "Andersson", "saraA@gmail.com", "0729386544");
            Student student2 = new Student(2, "Alex", "Karlsson", "KarlssonAlex@icloud.com", "0712345679");
            Student student3 = new Student(3, "Emma", "Johansson", "emma@gmail.com", "0703456789");
            Student student4 = new Student(4, "Lucas", "Nilsson", "lucas@gmail.com", "0704567890");
            Student student5 = new Student(5, "Amina", "Hassan", "amina@gmail.com", "0705678901");
            Student student6 = new Student(6, "William", "Karlsson", "william@gmail.com", "0706789012");
            Student student7 = new Student(7, "Nora", "Lindberg", "nora@gmail.com", "0707890123");
            Student student8 = new Student(8, "Ali", "Ahmed", "ali@gmail.com", "0702345678");
            Student student9 = new Student(9, "Oscar", "Berg", "BergOscar@icloud.com", "0798263844");
            Student student10 = new Student(10, "Leila", "Mohammed", "Leila@gmail.com", "0712093487");

            Annons annons1 = new Annons(1, "Objektorienterad Systemutveckling 1", 300, AnnonsSkick.Nyskick, AnnonsStatus.TillSalu, new DateTime(2026, 8, 2), student2);
            Annons annons2 = new Annons(2, "Databaser och SQL", 250, AnnonsSkick.BraSkick, AnnonsStatus.TillSalu, new DateTime(2026, 8, 19), student8);
            Annons annons3 = new Annons(3, "Introduktion till Programmering", 350, AnnonsSkick.Nyskick, AnnonsStatus.TillSalu, new DateTime(2025, 4, 21), student3);
            Annons annons4 = new Annons(4, "Systemanalys och Design", 150, AnnonsSkick.Slitet, AnnonsStatus.TillSalu, new DateTime(2024, 12, 9), student7);
            Annons annons5 = new Annons(5, "Informationssäkerhet och cybersäkerhet", 349, AnnonsSkick.BraSkick, AnnonsStatus.TillSalu, new DateTime(2026, 11, 28), student1);
            Annons annons6 = new Annons(6, "Hur moderna organisationer fungerar", 279, AnnonsSkick.Slitet, AnnonsStatus.TillSalu, new DateTime(2025, 10, 7), student10);
            Annons annons7 = new Annons(7, "Organisation och organisering", 435, AnnonsSkick.Nyskick, AnnonsStatus.TillSalu, new DateTime(2026, 1, 30), student9);
            Annons annons8 = new Annons(8, "Matematisk statistik", 179, AnnonsSkick.Slitet, AnnonsStatus.TillSalu, new DateTime(2025, 3, 17), student6);
            Annons annons9 = new Annons(9, "Den nya affärsredovisningen", 539, AnnonsSkick.Nyskick, AnnonsStatus.TillSalu, new DateTime(2026, 5, 27), student4);
            Annons annons10 = new Annons(10, "Medicinska sjukdomar", 299, AnnonsSkick.BraSkick, AnnonsStatus.TillSalu, new DateTime(2025, 7, 7), student5);

            controller.LäggTillAnnons(annons1);
            controller.LäggTillAnnons(annons2);
            controller.LäggTillAnnons(annons3);
            controller.LäggTillAnnons(annons4);
            controller.LäggTillAnnons(annons5);
            controller.LäggTillAnnons(annons6);
            controller.LäggTillAnnons(annons7);
            controller.LäggTillAnnons(annons8);
            controller.LäggTillAnnons(annons9);
            controller.LäggTillAnnons(annons10);

            

            bool avsluta = false;
            while (avsluta == false)
            {
                Console.Clear();
                Console.WriteLine("=== BookSwap ===");
                Console.WriteLine();
                Console.WriteLine("Välj ett alternativ från menyn:");
                Console.WriteLine();
                Console.WriteLine("1. Visa annonser");
                Console.WriteLine("2. Reservera annons");
                Console.WriteLine("0. Avsluta");
                Console.WriteLine();
                

                bool giltigtVal = false;

                while (giltigtVal == false)
                {
                    Console.Write("Ange val: ");
                    string menyval = Console.ReadLine();


                    if (int.TryParse(menyval, out int val))
                    {
                        switch (val)
                        {
                            case 1:
                                Console.WriteLine("Du har valt att visa annonser");
                                giltigtVal = true;
                                break;

                            case 2:
                                Console.WriteLine("Du har valt att reservera annons\n");
                                Console.Write("Ange annons-ID på den annons du vill reservera: ");
                                bool AnnonsVal = false;
                                while (AnnonsVal == false)
                                {
                                    string input = Console.ReadLine();

                                    if (int.TryParse(input, out int annonsId))
                                    {
                                        Console.WriteLine(controller.ReserveraAnnons(annonsId, student1));
                                        AnnonsVal = true;
                                    }
                                    else 
                                    {
                                        Console.Write("Ange ett gilitgt annnons-ID: ");
                                    }
                                }
                                giltigtVal = true;
                                break;
                            case 0:
                                Console.WriteLine("Avslutar menyn...");
                                avsluta = true;
                                giltigtVal = true;
                                break;
                               
                            default:
                                Console.WriteLine("Ogiltgt menyval. Försök igen.");
                                break;
                        }

                    }
                    else
                    {
                        Console.WriteLine("Ange ett giltigt nummer: ");
                    }
                }
                if (avsluta == false)
                {
                    Console.WriteLine("\nTryck på valfri tangent för att återgå till menyn");
                    Console.ReadKey();
                }
            }
            
        }
    }
}
