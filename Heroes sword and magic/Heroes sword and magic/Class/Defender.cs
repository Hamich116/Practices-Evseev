using System;
using System.Collections.Generic;
using System.Text;

namespace Heroes_sword_and_magic
{
    class Defender : Hero, IShoutable, IDamageble, IHealable
    {
        public Defender(string Name, int Power, int Wisdom, int Health) : base(Name, Power, Wisdom, Health)
        {

        }

        public override void ShoutForTheKing()
        {
            Console.WriteLine("ЗА КОРОЛЯ БЛИН НАФИГ!");
        }

        public void DamageEnemy(Hero h)
        {
            if (h.Health > h.Power / 10)
            {
                h.Health -= h.Power / 10;
            }
            else
            {
                Console.WriteLine("Ха, ха ты думал я умер, но нет я жив!");
                h.Health = 1;
            }
        }
        public void HealAlly(Hero h)
        {
            Console.WriteLine($"Я, {h.Name}, подлатаю тебя");
            h.Health += this.Health + this.Power;
        }
    }
}
