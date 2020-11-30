using System;
using System.Collections.Generic;
using System.Text;

namespace praktika2
{
    class Powerfulman : Hero
    {
        private string swordName;
        private bool haveShield = false;
        public string SwordName { get => swordName; set => swordName = value; }
        public bool HaveShield { get => haveShield; set => haveShield = value; }
        
        public Powerfulman(string Name,string Clothes_color,int Height,int Weight,int Power,int Agility,int Intellect,string SwordName,bool HaveShield) : base (Name,Clothes_color,Height,Weight,Power,Agility,Intellect)
        {
            if (counter <= 9)
            {
                this.SwordName = SwordName;
                this.HaveShield = HaveShield;
            }
        }
        public string GetSkillPower()
        {
            return $"{Name} нанес усиленный урон: {(4 * Power + Agility + Intellect) * (Height / Weight)}";
        }

    }
}
