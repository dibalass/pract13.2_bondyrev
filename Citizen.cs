using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pract13._2
{
    public class Citizen
    {
        string fio, country;
        int age, passport;
        long number;
        public Citizen(string FIO, int age, string country, int passport, long number)
        {
            this.fio = FIO;
            this.age = age;
            this.country = country;
            this.passport = passport;
            this.number = number;
        }
        public string Fio { get { return fio; } set { fio = value; } }
        public string Country { get { return country; } set { country = value; } }
        public long Number { get { return number; } set { number = value; } }
        public int Age { get { return age; } set { age = value; } }
        public int Passport { get { return passport; } set { passport = value; } }
    }
}
