using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Student : Anvandare
    {
        public int StudentId { get; private set; }
        public Student(int studentId, string fornamn, string efternamn, string epostadress, string telefonnummer)
            : base(fornamn, efternamn, epostadress, telefonnummer) //base innebär att när ett student.objket skapas ska konstruktorn i Person först köras pch spara personuppgifterna
        {
            StudentId = studentId;
           
        }

    }
}

