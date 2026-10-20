using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Servicelager
{
    public class Databas
    {
        private List<Annons> annonser = new List<Annons>();
        private List<Student> studenter = new List<Student>();
        private List<Affar> affarer = new List<Affar>();
        private List<Administrator> administratorer = new List<Administrator>();


        public void LäggTillAnnons(Annons annons)
        {
            annonser.Add(annons);
        }
        public bool TaBortAnnons (Annons annons)
        {
            return annonser.Remove(annons);
        }

        public Annons HämtaAnnons(int id)
        {
            return annonser.FirstOrDefault(a => a.AnnonsId == id);
        }

        public List<Annons> HämtaAllaAnnonser()
        {
            return annonser;
        }


        public void LäggTillStudent(Student student)
        {
            studenter.Add(student);
        }

        public Student HämtaStudent(int id)
        {
            return studenter.FirstOrDefault(s => s.StudentId == id);
        }

        public List<Student> HämtaAllaStudenter()
        {
            return studenter;
        }

        public void LäggTillAffar(Affar affar)
        {
            affarer.Add(affar);
        }
        public List<Affar> HämtaAllaAffarer()
        {
            return affarer;
        }
        public void LäggTillAdministrator (Administrator administrator)
        {
            administratorer.Add(administrator);
        }
        public Administrator? HämtaAdministrator (string epostadress) //administrator? metoden ska returnera ett admin-objket eller null om ingen admin hittas
        {
            return administratorer.FirstOrDefault(a => a.Epostadress == epostadress); //jämför varhe admins epost med den som skickas in
        }
        public List<Administrator> HämtaAllaAdministratorer()
        {
            return administratorer;
        }
    }
}




