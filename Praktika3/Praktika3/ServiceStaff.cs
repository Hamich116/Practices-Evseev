using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Text;

namespace Praktika3
{
    class ServiceStaff : Worker
    {
        private static double budgetServiceStaff = 0;
        private static int counter = 0;
        public ServiceStaff(string Name, string Suname, bool IsMan, byte Age, double Experience,string Departament)
            : base (Name,Suname,IsMan,Age,Experience,Departament)
        {
        }

        public void BudgetServiceStaff()
        {
            if (counter == 0)
            {
                counter++;
                budgetServiceStaff = budget;
                budget = 0;
            }
        }

        public override void ReceiveMoney()
        {
            if (counter == 1)
            {
                Money = budgetServiceStaff / 8;
                Console.WriteLine(Money); 
            }
            else Console.WriteLine("Бюджет для обслуживающего персонала еще не начислен");
        }
    }
}
