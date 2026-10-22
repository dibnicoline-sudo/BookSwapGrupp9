using Models;
using System;
using System.Collections.Generic;
using System.Text;


namespace Models
{
    public class Kurs
    {
        public string Kurskod { get; private set; }
        public string Kursnamn { get; private set; }

        public Kurs(string kurskod, string kursnamn)
        {
            Kurskod = kurskod;
            Kursnamn = kursnamn;

        }
        public override string ToString()
        {
            return $"{Kurskod} - {Kursnamn}";
        }
        public void UppdateraKursnamn(string nyttKursnamn)
        {
            Kursnamn = nyttKursnamn;
        }
    }
}
