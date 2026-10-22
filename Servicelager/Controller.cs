using Models;
using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;
using System.Net.Http.Headers;

namespace Servicelager
{
    public class Controller
    {
        private Databas databas;

        public Controller(Databas databas)
        {
            this.databas = databas;
        }
        public void LäggTillAnnons(Annons annons)
        {
            databas.LäggTillAnnons(annons);
            annons.Säljare.LäggTillAnnons(annons);
        }
        public string SkapaAnnons(string titel, decimal pris,AnnonsSkick skick, Student säljare, Kurs kurs,string typ, string extra1, string extra2)
        {
            if (säljare == null || kurs == null)
                return "Säljare eller kurs saknas.";

            int nyttId = databas.HämtaAllaAnnonser().Count == 0
                ? 1
                : databas.HämtaAllaAnnonser().Max(a => a.AnnonsId) + 1;

            Annons nyAnnons;

            if (typ == "Kursbok")
            {
                nyAnnons = new Kursbok(
                    nyttId, titel, pris, skick,
                    AnnonsStatus.TillSalu, DateTime.Now,
                    säljare, extra1, extra2, kurs);
            }
            else if (typ == "Kompendium")
            {
                if (!int.TryParse(extra2, out int antalSidor) || antalSidor <= 0)
                    return "Ange ett giltigt antal sidor.";

                nyAnnons = new Kompendium(
                    nyttId, titel, pris, skick,
                    AnnonsStatus.TillSalu, DateTime.Now,
                    säljare, extra1, antalSidor, kurs);
            }
            else if (typ == "Digital resurs")
            {
                if (!double.TryParse(extra2, out double filstorlek) || filstorlek <= 0)
                    return "Ange en giltig filstorlek.";

                nyAnnons = new DigitalResurs(
                    nyttId, titel, pris, skick,
                    AnnonsStatus.TillSalu, DateTime.Now,
                    säljare, extra1, filstorlek, kurs);
            }
            else
            {
                return "Välj en giltig annonstyp.";
            }

            LäggTillAnnons(nyAnnons);

            return "Annonsen har skapats!";
        }
        public string UppdateraAnnons(Annons annons, Student student, string titel, decimal pris, AnnonsSkick skick)
        {
            if (annons == null || student == null)
                return "Annons eller student saknas.";

            if (annons.Säljare.StudentId != student.StudentId)
                return "Du får bara uppdatera dina egna annonser.";

            if (annons.StatusAnnons != AnnonsStatus.TillSalu)
                return "Du kan bara uppdatera annonser som är till salu.";

            if (string.IsNullOrWhiteSpace(titel) || pris <= 0)
                return "Ange en titel och ett pris över 0 kr.";
            annons.UppdateraAnnons(titel, pris, skick);
            return "Annonsen har uppdaterats!";
        }
        public Annons VisaAnnons(int annonsId)
        {
            return databas.HämtaAnnons(annonsId);
        }
        public List<Annons> ListaAnnonser()
        {
            List<Annons> tillgangligaAnnonser = new List<Annons>();

            foreach (Annons annons in databas.HämtaAllaAnnonser())
            {
                if (annons.StatusAnnons == AnnonsStatus.TillSalu)
                {
                    tillgangligaAnnonser.Add(annons);
                }
            }
            return tillgangligaAnnonser;
        }

        public List<Annons> SokAnnonser (string soktext)
        {
            return ListaAnnonser().Where(a => a.Titel.Contains(soktext ?? "",
                StringComparison.OrdinalIgnoreCase)).ToList();
        }
        public string ReserveraAnnons(int annonsId, Student köpare)
        {
            Annons annons = VisaAnnons(annonsId);
            if (köpare == null)
                return "Ingen köpare vald";
            if (annons == null)
                return "Annonsen finns inte. Försök igen.";

            if (!annons.KontrolleraStatus())
                return "Annonsen är redan reserverad";
            if (!annons.KontrolleraStatus())
                return "Annonsen är inte till salu";

            if (annons.Säljare.StudentId == köpare.StudentId)
                return "Du kan inte reservera din egen annons.";

            int affarsId = databas.HämtaAllaAffarer().Count + 1;
            Affar affar = new Affar(affarsId, köpare, annons);
            databas.LäggTillAffar(affar);

            annons.UppdateraAnnonsStatus(AnnonsStatus.Reserverad);

            return $"\nAnnonsen är reserverad!\n\n" +
            $"AnnonsID: {annons.AnnonsId}\n" +
            $"Köpare: {köpare.Fornamn} {köpare.Efternamn}\n" +
            $"Säljare: {annons.Säljare.Fornamn} {annons.Säljare.Efternamn}\n" +
            $"Annonsen titel: {annons.Titel}\n" +
            $"Pris: {annons.Pris} kr\n" +
            $"Reserveringsdatum: {affar.Reserveringsdatum}\n" +
            $"Affär: #{affar.AffarsId}";
        }
        public string BekräftaKöp (Affar affar, Student säljare)
        {
            if (affar == null)
                return "Affären finns inte.";
            if(säljare == null || affar.Säljare.StudentId != säljare.StudentId)
                return "Du får bara bekräfta dina egna försäljningar";

            if (!databas.HämtaAllaAffarer().Contains(affar))
                return "Affären finns inte i systemet";

            if (!databas.HämtaAllaAnnonser().Contains(affar.Annons))
            {
                return "Annonsen har tagits bort. Köpet kan inte bekräftas.";
            }
            if (affar.AffarStatus != AffarStatus.Reserverad)
                return "Affären är inte reserverad.";
            if (affar.Annons.StatusAnnons != AnnonsStatus.Reserverad)
                return "Annonsen är inte reserverad";

            affar.UppdateraAffarStatus(AffarStatus.Genomford);
            affar.Annons.UppdateraAnnonsStatus(AnnonsStatus.Sald);
            return "Köpet är bekräftat! Annonsen är nu såld!";
        }
        public List<Affar> HämtaAllaAffarer()
        {
            return databas.HämtaAllaAffarer();
        }
        public List<Annons> HämtaAllaAnnonser()
        {
            return databas.HämtaAllaAnnonser();
        }
        public bool TaBortAnnons(Annons annons, Administrator administrator) //tar emot annonsobjektet
        {
            if (annons == null || administrator == null)
            
             return false;
                if (!databas.HämtaAllaAdministratorer().Contains(administrator))
                {
                    return false;
                }
                
                bool borttagen = databas.TaBortAnnons(annons);

                if (borttagen)
                {
                    annons.Säljare.TaBortAnnons(annons);
                }
                return borttagen;
        }
        public bool TaBortMinAnnons (Annons annons, Student student)
        {
            if (annons == null || student == null) 
            {
                return false;
            }
            if (annons.Säljare.StudentId != student.StudentId)
            {
                return false;
            }
            if (annons.StatusAnnons != AnnonsStatus.TillSalu)
            {
                return false;
            }
            bool borttagen = databas.TaBortAnnons(annons);

            if(borttagen)
            {
                student.TaBortAnnons(annons);
            }
            return borttagen;
        }
        public Administrator? HämtaAdministrator (string epostadress)
        {
            return databas.HämtaAdministrator(epostadress);
        }
        public Administrator? LoggaInAdministrator (string epostadress, string losenord)
        {
            Administrator? admin = databas.HämtaAdministrator(epostadress); //metoden ber databasen att leta efetr en admin med den eposten

            if(admin == null)
            {
                return null;
            }

            if (admin.Losenord != losenord)
            {
                return null; 
            }
            return admin; //returnerar resultatet, om admin finns returneras ett administratörs-objket, annrs null
        }
        public Student? LoggaInStudent (string epostadress, string losenord)
        {
            Student? student = databas.HämtaAllaStudenter().FirstOrDefault(s=> s.Epostadress == epostadress);
            if (student == null)
            {
                return null;
            }
            if (!student.KontrolleraLosenord(losenord))
            {
                return null;
            }
            return student;
        }
        public string RegistreraStudent(string fornamn, string efternamn,string epostadress, string telefonnummer, string losenord)
        {
            if (string.IsNullOrWhiteSpace(fornamn) ||
                string.IsNullOrWhiteSpace(efternamn) ||
                string.IsNullOrWhiteSpace(epostadress) ||
                string.IsNullOrWhiteSpace(telefonnummer) ||
                string.IsNullOrWhiteSpace(losenord))
            {
                return "Du måste fylla i alla fält";
            }

            Student befintligStudent = databas.HämtaAllaStudenter().FirstOrDefault(s => s.Epostadress.Equals(epostadress, StringComparison.OrdinalIgnoreCase));

            if (befintligStudent != null)
            {
                return "E-postadressen används redan.";
            }

            int nyttId = databas.HämtaAllaStudenter().Count == 0
                ? 1
                : databas.HämtaAllaStudenter().Max(s => s.StudentId) + 1;

            Student nyStudent = new Student(
                nyttId, fornamn, efternamn,
                epostadress, telefonnummer, losenord);

            databas.LäggTillStudent(nyStudent);

            return "Registreringen lyckades!";
        }

        public List<Student> HämtaAllaStudenter()
        {
            return databas.HämtaAllaStudenter();
        }

        public string AdminUppdateraStudent(Student student, string fornamn,
            string efternamn, string epostadress, string telefonnummer)
        {
            if (student == null)
                return "Välj en student först.";

            if (string.IsNullOrWhiteSpace(fornamn) ||
                string.IsNullOrWhiteSpace(efternamn) ||
                string.IsNullOrWhiteSpace(epostadress) ||
                string.IsNullOrWhiteSpace(telefonnummer))
                return "Alla fält måste fyllas i.";

            if (databas.HämtaAllaStudenter().Any(s =>
                s != student &&
                s.Epostadress.Equals(epostadress, StringComparison.OrdinalIgnoreCase)))
                return "E-postadressen används redan.";

            student.UppdateraUppgifter(
                fornamn, efternamn, epostadress, telefonnummer);

            return "Studenten har uppdaterats!";
        }

        public string AdminTaBortStudent(Student student)
        {
            if (student == null)
                return "Välj en student först.";

            if (databas.HämtaAllaAnnonser().Any(a => a.Säljare == student) ||
                databas.HämtaAllaAffarer().Any(a =>
                    a.Köpare == student || a.Säljare == student))
                return "Studenten har annonser eller affärer och kan inte tas bort.";

            if (databas.TaBortStudent(student))
                return "Studenten har tagits bort!";

            return "Studenten kunde inte tas bort.";
        }

        public List<Kurs> HämtaAllaKurser()
        {
            return databas.HämtaAllaKurser();
        }
        public string LäggTillKurs (string kurskod, string kursnamn)
        {
            if (databas.HämtaKurs(kurskod) != null)
                return "Kursen finns redan,";
            Kurs nyKurs = new Kurs (kurskod, kursnamn);

            databas.LäggTillKurs(nyKurs);

            return "Kursen har lagts till!";
        }
        public string UppdateraKurs (Kurs kurs, string nyttKursnamn)
        {
            if (kurs == null)
                return "Välj en kurs först.";

            kurs.UppdateraKursnamn(nyttKursnamn);

            return "Kursen har uppdaterats!";
        }
        public string TaBortKurs (Kurs kurs)
        {
            if (kurs == null)
                return "Välj en kurs först.";
            if (databas.HämtaAllaAnnonser().Any (a=> a.Kurs == kurs))
            {
                return "Kursen kan inte tas bort eftersom det finns annonser kopplade till den.";
            }

            if (databas.TaBortKurs(kurs))
                return "Kursen har tagits bort!";
            return "Kursen kunde inte tas bort.";
        }
    }
}


