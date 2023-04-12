using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pract13._2
{
    public class Citizen
    {
        string fio, country, year;
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
        public string Year { get {
                int year1 = Convert.ToInt32(year);
                string stroka = "";
                int vozrast = 2023 - year1;
                if (vozrast >= 45)
                {
                    stroka = "Паспорт больше не нужно менять";
                }
                else if (vozrast <= 20)
                {
                    stroka = $"в {year1 + 45}";
                }
                else if (vozrast <= 14)
                {
                    stroka = $"в {year1 + 20} и {year1 + 45}";
                }
                else
                {
                    stroka = $@"в {year1 + 14}, {year1 + 20} и в {year1 + 45}";
                }
                return stroka;} set { year = value; } }

    }
}
