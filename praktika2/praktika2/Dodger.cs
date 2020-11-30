using System;
using System.Collections.Generic;
using System.Text;

namespace praktika2
{
    class Dodger : Hero
    {
        private bool isThief;
        public bool IsThief { get => isThief; set => isThief = value; }
        public Dodger(string Name, string Clothes_color, int Height, int Weight, int Power, int Agility, int Intellect,bool IsThief) : base(Name, Clothes_color, Height, Weight, Power, Agility, Intellect)
        {
            if (counter <= 9)
            {
                this.IsThief = IsThief;
            }
        }
        public string GetSkillAgility()
        {
            return $"{Name} нанес урон сзади: {(Power + 5 * Agility + Intellect) * (Height / Weight)}";
        }
    }
}
