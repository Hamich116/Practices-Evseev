using System;
using System.Collections.Generic;
using System.Text;

namespace Heroes_sword_and_magic.Class
{
    class GameInformation
    {

        public static void GetReport(Player p1, Player p2)
        {
            Player.CheckHeroes6(p1);
            Player.CheckHeroes6(p2);
            King king1 = new King("Name", 1, 1, 1);
            King king2 = new King("Name", 1, 1, 1);
            Console.WriteLine($"Команда {p1.NameTeam}: ");
            foreach (var item in p1.heroes)
            {
                Console.WriteLine(item.Name);
                if (item is King)
                {
                    king1 = item as King;
                }
            }

            Console.WriteLine($"Команда {p2.NameTeam}: ");
            foreach (var item in p2.heroes)
            {
                Console.WriteLine(item.Name);
                if (item is King)
                {
                    king2 = item as King;
                }
            }

            if (king1.Equals(king2))
            {
                Console.WriteLine("Война нам здесь не поможет,мы потеряем лишь много героев." +
                    "Так что теперь у нас конфеты,дружба,жвачка!");
            }

            foreach (Hero item in p1.heroes)
            {
                item.ShoutForTheKing();
            }

            foreach (Hero item in p2.heroes)
            {
                item.ShoutForTheKing();
            }

        }
    }
}
