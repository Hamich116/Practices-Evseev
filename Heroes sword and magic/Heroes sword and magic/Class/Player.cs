using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace Heroes_sword_and_magic.Class
{
    class Player
    {
        public string NameTeam { get; set; }
        public Hero[] heroes = new Hero[6];
        public Player(string NameTeam, Hero[] heroes)
        {
            this.NameTeam = NameTeam;
            this.heroes = heroes;
        }
        public static void CheckHeroes6(Player player)
        {
            int attackercounter = 0;
            int couriercounter = 0;
            int defendercounter = 0;
            foreach (Hero item in player.heroes)
            {
                if (item is Attacker)
                {
                    attackercounter++;
                }
                else if (item is Courier)
                {
                    couriercounter++;
                }
                else if (item is Defender)
                {
                    defendercounter++;
                }
            }
            if (defendercounter == 0 || couriercounter == 0 || attackercounter == 0)
            {
                Console.WriteLine("Вы нарушили правило!Ваша команда будет дисквалифицирована!");
                player.heroes = null;
            }
        }
    }
}
