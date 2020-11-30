using System;
using System.Collections.Generic;
using System.Text;

namespace Heroes_sword_and_magic
{
    class King : Hero, IKillable
    {
        public King(string Name, int Power, int Wisdom, int Health) : base(Name, Power, Wisdom, Health)
        {

        }

        public override void ShoutForTheKing()
        {
            Console.WriteLine("ЗА СЕБЯ БЛИН НАФИГ!");
        }

        public override bool Equals(object obj)
        {
            King king = obj as King;
            int summa1 = Power + Wisdom + Health;
            int summa2 = king.Power + king.Wisdom + king.Health;
            if (summa1 == summa2)
            {
                return true;
            }
            else return false;
        }
        public void KillEnemy(Hero h)
        {
            Random rnd1 = new Random();
            Random rnd2 = new Random();
            if (h is King)
            {
                int a = 0;
                int b = 0;
                while (a == b)
                {
                    a = rnd1.Next(1, 3);
                    b = rnd2.Next(1, 3);
                }
                // 1 - ножницы
                // 2 - бумага
                // 3 - камень
                Console.WriteLine("Камень,ножницы,бумага раз,два,три");
                switch (a)
                {
                    case 1:
                        Console.WriteLine("Ножницы");
                        if (b == 2)
                        {
                            Console.WriteLine("Бумага");
                            Console.WriteLine("Я, " + this.Name + " выйграл,теперь я здесь главный!");
                        }
                        else
                        {
                            Console.WriteLine("Камень");
                            Console.WriteLine("Я, " + h.Name + " выйграл,теперь я здесь главный!");
                        }
                        break;
                    case 2:
                        Console.WriteLine("Бумага");
                        if (b == 1)
                        {
                            Console.WriteLine("Ножницы");
                            Console.WriteLine("Я, " + h.Name + " выйграл,теперь я здесь главный!");
                        }
                        else
                        {
                            Console.WriteLine("Камень");
                            Console.WriteLine("Я, " + h.Name + " выйграл,теперь я здесь главный!");
                        }
                        break;
                    case 3:
                        Console.WriteLine("Камень");
                        if (b == 1)
                        {
                            Console.WriteLine("Ножницы");
                            Console.WriteLine("Я, " + this.Name + " выйграл,теперь я здесь главный!");
                        }
                        else
                        {
                            Console.WriteLine("Бумага");
                            Console.WriteLine("Я, " + h.Name + " выйграл,теперь я здесь главный!");
                        }
                        break;
                }

            }
            else
            {
                h.Health = 0;
            }

        }

    }
}
