using System;
using System.Collections.Generic;
using System.Text;

namespace   Models
{
    public class Student : Person
    {
        public int StudentId { get; private set; }
        public string Fornamn { get; private set; }
        public string Efternamn { get; private set; }
        public string Epostadress { get; private set; }
        private string Telefonnummer { get; set; }

        public Student(int studentId, string fornamn, string efternamn, string epostadress, string telefonnummer)
            : base(fornamn, efternamn, epostadress, telefonnummer) //base innebär att när ett student.objket skapas ska konstruktorn i Person först köras pch spara personuppgifterna
        {
            StudentId = studentId;
           
        }

    }
}

