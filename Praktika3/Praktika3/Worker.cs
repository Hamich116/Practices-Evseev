using System;
using System.Collections.Generic;
using System.Text;

namespace Praktika3
{
    abstract class Worker
    {
        public DateTime dateWork = new DateTime(2020, 7, 1);
        public DateTime dateEnd = new DateTime(2020, 7, 26);
        public DateTime dateSaturday = new DateTime(2020, 7, 4);
        public DateTime dateSunday = new DateTime(2020, 7, 5);
        public static double accmoney = 0;
        public static double budget = 3000000;

        public string Name { get; set; }
        public string Suname { get; set; }
        public bool IsMan { get; set; }
        public byte Age { get; set; }
        public double Money { get; set; }
        public string Departament { get; set; }
        public double Experience { get; set; }

        public Worker(string Name, string Suname, bool IsMan, byte Age, double Experience, string Departament, double Money)
            : this(Name,Suname,IsMan,Age,Experience,Departament)
        {
            this.Money = Money;
        }

        public Worker(string Name, string Suname, bool IsMan, byte Age, double Experience,string Departament)
        {
            this.Name = Name;
            this.Suname = Suname;
            this.IsMan = IsMan;
            this.Experience = Experience;
            this.Departament = Departament;
        }

        public virtual void ReceiveMoney()
        {
            Console.WriteLine(Money);
            budget = budget - Money;
        }
    }
}
