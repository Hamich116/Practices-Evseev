using Heroes_sword_and_magic.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Heroes_sword_and_magic
{
    class Courier : Hero, IShoutable, IHealable, IGetMessagable
    {
        public Courier(string Name, int Power, int Wisdom, int Health) : base(Name, Power, Wisdom, Health)
        {

        }
        public override void ShoutForTheKing()
        {
            Console.WriteLine("ЗА КОРОЛЯ БЛИН НАФИГ!");
        }
        private void HealAlly(Hero h1, Hero h2)
        {
            if (this == h1 || this == h2)
            { Console.WriteLine($"Не бойся,{h1.Name},я нас подлатаю"); }
            else Console.WriteLine($"Не бойтесь,{h1.Name} и {h2.Name}, я вас подлатаю");
            h1.Health += 30;
            h2.Health += 30;
        }
        public void GetWisdom(Hero h1, Hero h2)
        {
            h2.Wisdom += h1.Wisdom;
            h1.Wisdom = 0;
            HealAlly(h1, h2);
        }
    }
}
