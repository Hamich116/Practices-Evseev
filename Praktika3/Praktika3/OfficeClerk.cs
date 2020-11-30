using System;
using System.Collections.Generic;
using System.Text;

namespace Praktika3
{
    class OfficeClerk : Worker
    {
        public OfficeClerk(string Name, string Suname, bool IsMan, byte Age, double Experience,string Departament)
            : base (Name,Suname,IsMan,Age,Experience,Departament)
        {

        }

        public override void ReceiveMoney()
        {
            while (dateWork != dateEnd)
            {
                if (dateWork.DayOfWeek != dateSaturday.DayOfWeek && dateWork.DayOfWeek != dateSunday.DayOfWeek)
                {
                    Money = Money + (325 * 8);
                }
                dateWork = dateWork.AddDays(1);
            }
            
            Console.WriteLine(Money);
            budget = budget - Money;
        }
    }
}
