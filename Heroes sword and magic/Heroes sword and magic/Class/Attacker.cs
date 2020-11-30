using System;
using System.Collections.Generic;
using System.Text;

namespace Heroes_sword_and_magic
{
    class Attacker : Hero,IShoutable,IKillable,IDamageble
    {
        public Attacker(string Name, int Power, int Wisdom, int Health) : base(Name, Power, Wisdom, Health)
        {

        }
        public override void ShoutForTheKing()
        {
            Console.WriteLine("ЗА КОРОЛЯ БЛИН НАФИГ!");
        }
        public void KillEnemy(Hero h)
        {
            if (this.Power > h.Health)
            {
                Console.WriteLine($"Герой {h.Name} умер");
                h.Health = 0;
            }
            else
            {
                Console.WriteLine($"Я, {this.Name} опозорил своего Короля,и мне нет прощения!");
                this.Health = 0;
            }
        }
        public void DamageEnemy(Hero h)
        {
            if (this.Wisdom < h.Wisdom)
            {
                if (this.Health > h.Power)
                {
                    this.Health -= h.Power;
                }
                else this.Health = 1;
            }
            else if (this.Wisdom == h.Wisdom)
            {
                if (h.Health > this.Power && this.Health > h.Power)
                {
                    this.Health -= h.Power;
                    h.Health -= this.Power;
                }
                else if (h.Health > this.Power && this.Health < h.Power)
                {
                    h.Health -= this.Power;
                    this.Health = 1;
                }
                else
                {
                    this.Health -= h.Power;
                    h.Health = 1;
                }
            }
            else
            {
                if (h.Health > this.Power)
                { 
                    h.Health -= this.Power;
                }
            }
        }
    }
}
