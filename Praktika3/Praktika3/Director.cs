using System;
using System.Collections.Generic;
using System.Text;

namespace Praktika3
{
    class Director : Worker
    {
        
        byte leadershipSkills;
        byte stressResistance;

        public bool IsAdditionalEducation { get; set; }
        public bool IsTraining { get; set; }
        public byte LeadershipSkills
        {
            get
            {
                return leadershipSkills;
            }

            set
            {
                if (value < 11)
                {
                    leadershipSkills = value;
                }
                
            }
        }
        public byte StressResistance
        {
            get
            {
                return stressResistance;
            }
            set
            {
                if (value < 11)
                {
                    stressResistance = value;
                }
            }
        }
        public Director(string Name, string Suname, bool IsMan,byte Age, double Experience,string Departament, double Money, bool IsAdditionalEducation, bool IsTraining, byte LeadershipSkills, byte StressResistance)
            : base (Name,Suname,IsMan,Age,Experience,Departament,Money)
        {
            this.IsAdditionalEducation = IsAdditionalEducation;
            this.IsTraining = IsTraining;
            this.LeadershipSkills = LeadershipSkills;
            this.StressResistance = StressResistance;
        }
        
        public override void ReceiveMoney()
        {
            Money = Money * 2;
            Console.WriteLine(Money);
            budget = budget - (Money);
           
        }
    }
}
