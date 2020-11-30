using System;
using System.Collections.Generic;
using System.Text;

namespace Praktika3
{
    class Accountant : Worker
    {
        public Accountant(string Name, string Suname, bool IsMan, byte Age, double Experience,string Departament, double Money)
            : base(Name, Suname, IsMan, Age, Experience,Departament, Money)
        {

        }
        public override void ReceiveMoney()
        {
            Money = Money + accmoney;
            Console.WriteLine(Money);
            
        }
        public void Report(Worker[] workers)
        {

            Console.WriteLine($"Расчетный период: {dateWork} - {dateEnd}");
            
            foreach (Worker worker in workers)
            {
                Console.WriteLine($"{worker.Name} {worker.Suname} - {worker.Money}");
            }
            Console.WriteLine($"Премиальных осталось: {budget}");
            Console.WriteLine($"Бухгалтер стырил у бедных программистов: {accmoney}");
        }
    }
}
