using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;

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
        }
        public Annons VisaAnnons(int annonsId)
        {
            return databas.HämtaAnnons(annonsId);
        }
        public void ListaAnnonser()
        {
            foreach (Annons annons in databas.HämtaAllaAnnonser())
            {
                if (annons.StatusAnnons == AnnonsStatus.TillSalu)
                {
                    Console.WriteLine(annons);
                }

            }
        }
        public string ReserveraAnnons(int annonsId, Student köpare)
        {
            Annons annons = VisaAnnons(annonsId);
            if (annons == null)
                return "Annonsen finns inte. Försök igen.";

            if (!annons.KontrolleraStatus())
                return "Annonsen är redan reserverad";

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
        public string BekräftaKöp (Affar affar)
        {
            if (affar == null)
                return "Affären finns inte.";
            if (!databas.HämtaAllaAnnonser().Contains(affar.Annons))
            {
                return "Annonsen har tagits bort. Köpet kan inte bekräftas.";
            }
            if (affar.AffarStatus != AffarStatus.Reserverad)
                return "Affären är inte reserverad.";
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
        public bool TaBortAnnons (Annons annons, Administrator administrator) //tar emot annonsobjektet
        {
           
            if (annons == null || administrator == null)
            {
                return false;
            }
            if (!databas.HämtaAllaAdministratorer().Contains(administrator))
            {
                return false;
            }
            return databas.TaBortAnnons(annons);
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
    }
}


