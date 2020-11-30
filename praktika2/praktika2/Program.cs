using System;

namespace praktika2
{
    class Program
    {
        static void Main(string[] args)
        {
            Powerfulman Artur = new Powerfulman("Артур Пендрагон", "Черная одежда", 180, 50, 100, 40, 30, "Экскалибур", false);
            Cleverman Gendalf = new Cleverman("Гендальф", "Белая одежда", 190, 55, 15, 25, 60, true, 30);
            Dodger Spiderman = new Dodger("Человек-паук", "Красно - синяя одежда", 175, 60, 40, 50, 10, false);
            Console.WriteLine(Hero.counter);
            Console.WriteLine(Artur.GetDamage());
            Console.WriteLine(Gendalf.GetSpell());
            Console.WriteLine(Spiderman.GetDamage());
            Console.WriteLine(Artur.GetSkillPower());
            Console.WriteLine(Spiderman.GetSkillAgility());
        }
    }
}
