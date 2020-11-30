using System;

namespace praktika1
{
    class Program
    {
        static void Main(string[] args)
        {
            Bicycle stels = new Bicycle("Stels", 32, 45000);
            Bicycle forward = new Bicycle("Forward", 25, 35000);
            Bicycle stern = new Bicycle("Stern", 27, 30000);
            Bicycle Merida = new Bicycle("Merida", 30, 15000);
            Bicycle[] Bicycles1 = new Bicycle[4];
            Bicycle[] Bicycles2 = new Bicycle[4];
            Bicycles1[0] = stels;
            Bicycles1[1] = forward;
            Bicycles2[0] = forward;
            Bicycles2[1] = stern;
            Cycler rustem = new Cycler("Рустем", "Гайфуллин", 17, "Russia", Bicycles1, 25);
            Cycler ilham = new Cycler("Ильхам", "Хаматуллин", 18, "Russia", Bicycles2, 20);
            Cycler askar = new Cycler("Аскар", "Шпалитов", 18, "Russia", Bicycles1, 23);
            rustem.GetInfo();
            rustem.AddBicycle(Merida);
            rustem.Goln();
            ilham.Goln();
            askar.Goln();
            rustem.GoOut();
            askar.GoOut();
            askar.GoOut();
            askar.Goln();
            rustem.Finish();
            ilham.Finish();
            askar.Finish();
            
        }
    }
}
