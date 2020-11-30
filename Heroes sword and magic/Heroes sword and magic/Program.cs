using Heroes_sword_and_magic.Class;
using System;

namespace Heroes_sword_and_magic
{
    class Program
    {
        static void Main(string[] args)
        {
            King Artur = new King("Aleksandr", 100, 50, 999);
            Attacker Sanya = new Attacker("Sanya", 50, 30, 100);
            Courier Evgen = new Courier("Evgen", 10, 20, 100);
            Defender Hamich = new Defender("Hamich", 10, 50, 120);
            Attacker Sanya1 = new Attacker("Sanya1", 50, 30, 100);
            Courier Evgen1 = new Courier("Evgen1", 10, 20, 100);
            Hero[] White = { Artur, Sanya, Evgen, Hamich, Sanya1, Evgen1 };
            King Gilgamesh = new King("Gilgamesh", 150, 150, 300);
            Attacker Danil = new Attacker("Danil", 60, 50, 50);
            Courier Azat = new Courier("Azat", 20, 80, 60);
            Defender Ilham = new Defender("Ilham", 15, 100, 90);
            Courier Azat1 = new Courier("Azat1", 20, 80, 60);
            Defender Ilham1 = new Defender("Ilham1", 15, 100, 90);
            Hero[] Black = { Gilgamesh, Danil, Azat, Ilham, Azat1, Ilham1 };
            Player Kiril = new Player("Белые", White);
            Player Benedikt = new Player("Черные", Black);

            GameInformation.GetReport(Kiril,Benedikt);
        }
    }
}
