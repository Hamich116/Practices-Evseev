using System;
using System.Collections.Generic;
using System.Text;

namespace Heroes_sword_and_magic
{
    abstract class Hero : IShoutable
    {
        public string Name { get; set; }
        public int Power { get; set; }
        public int Wisdom { get; set; }
        public int Health { get; set; }

        public Hero(string Name, int Power, int Wisdom, int Health)
        {
            this.Name = Name;
            this.Power = Power;
            this.Wisdom = Wisdom;
            this.Health = Health;
        }

        public abstract void ShoutForTheKing();
    }
}
