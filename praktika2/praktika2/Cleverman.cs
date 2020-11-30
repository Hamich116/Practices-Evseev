using System;
using System.Collections.Generic;
using System.Text;

namespace praktika2
{
    class Cleverman : Hero
    {
        private bool haveStaff;
        private int knowSpell;

        public bool HaveStaff { get => haveStaff; set => haveStaff = value; }
        public int KnowSpell { get => knowSpell; set => knowSpell = value; }

        public Cleverman(string Name, string Clothes_color, int Height, int Weight, int Power, int Agility, int Intellect,bool HaveStaff, int KnowSpell) : base (Name, Clothes_color, Height, Weight, Power, Agility, Intellect)
        {
            if (counter <= 9)
            {
                this.HaveStaff = HaveStaff;
                this.KnowSpell = KnowSpell;
            }
        }
        
        public string GetSpell()
        {
            return $"{Name} нанес урон магией: {(Power + Agility + 3 * Intellect) * (Height / Weight)}";
        }

    }
}
