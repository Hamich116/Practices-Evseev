using System;
using System.Collections.Generic;
using System.Text;

namespace praktika2
{
    class Hero
    {
        private string name;
        private string clothescolor;
        private int weight = 30;
        private int height = 100;
        private int power = 1;
        private int agility = 1;
        private int intellect = 1;

        protected string Name { get => name; set => name = value; }
        protected string Clothescolor { get => clothescolor; set => clothescolor = value; }
        protected int Weight { get => weight; set => weight = value; }
        protected int Height { get => height; set => height = value; }
        protected int Power { get => power; set => power = value; }
        protected int Agility { get => agility; set => agility = value; }
        protected int Intellect { get => intellect; set => intellect = value; }


        public static int counter = 0;

        public Hero(string Name, string Clothescolor, int Height, int Weight, int Power, int Agility, int Intellect)
        {
            if (counter <= 9)
            {
                counter++;
                this.Name = Name;
                this.Clothescolor = Clothescolor;
                this.Height = Height;
                this.Weight = Weight;
                this.Power = Power;
                this.Agility = Agility;
                this.Intellect = Intellect;
            }
            else Console.WriteLine("Уоу,уоу,остуди свой компьютер,он уже нагрет!");
        }
        public int GetDamage()
        {
            return (power + agility + intellect) * (height / weight);
        }
    }
}
