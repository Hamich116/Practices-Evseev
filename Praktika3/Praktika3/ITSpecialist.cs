using System;
using System.Collections.Generic;
using System.Text;

namespace Praktika3
{
    class ITSpecialist : Worker
    {
        public byte KnowledgeProgrammingLanguages { get; set; }
        public ITSpecialist(string Name, string Suname, bool IsMan,byte Age,double Experience,string Departament,byte KnowledgeProgrammingLanguages)
            : base(Name, Suname,IsMan,Age,Experience,Departament)
        {
            this.KnowledgeProgrammingLanguages = KnowledgeProgrammingLanguages;
        }
        
        public override void ReceiveMoney()
        {
            Money = 125000;
            budget = budget - Money;
            accmoney = accmoney + (Money * 20 / 100);
            Money = Money * 80 / 100;
            Console.WriteLine(Money);
        }
    }
}
