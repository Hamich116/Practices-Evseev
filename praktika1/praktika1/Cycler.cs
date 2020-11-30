using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace praktika1
{
    class Cycler
    {
        public static int counter = 0;

        private string name;
        private string suname;
        private byte age;
        private string country = "Неизвестно";
        private string bicycle = "Неизвестно";
        private double sred_speed = 0;
        private Bicycle[] bicycles;

        bool natrasse = false;

        public string Name { get => name; private set => name = value; }
        public string Suname { get => suname; private set => suname = value; }
        public byte Age { get => age; private set => age = value; }
        public string Country { get => country; set => country = value; }
        public string Bicycle { get => bicycle; set => bicycle = value; }
        public double Sred_speed { get => sred_speed; set => sred_speed = value; }
        Bicycle[] Bicycles { get => bicycles; set => bicycles = value; }


        public Cycler(string name, string suname, byte age, string country, Bicycle[] bicycles, byte sred_speed) : this(name, suname, age)
        {
            this.bicycles = bicycles;
            this.country = country;
            this.sred_speed = sred_speed;
        }
        private Cycler(string name, string suname, byte age)
        {
            
            this.name = name;
            this.suname = suname;
            this.age = age;
        }
        public string GetCyclerCount()
        {
            return $"Количество велосипедистов на трассе: {counter}";
        }
        public string Goln()
        {
            if (natrasse == false)
            {
                counter++;
                natrasse = true;
                return $"Стал на трассу: {name} {suname} \n Количество участников: {counter}";
                
            }
            return "";
        }
        public string GoOut()
        {
            if (natrasse == true)
            {
                counter--;
                natrasse = false;
                return $"Сошел с трассы: {name} {suname} \n Количество участников: { counter}";
                
            }
            return "";
        }
        public string GetInfo()
        {
            Console.WriteLine(name + " " + suname + "\n" + "Возраст: " + age + "\n" + "Страна: " + country + "\n" + "Велосипеды: ");
            foreach (var item in bicycles)
            {
                if (item != null)
                {
                    return(item.Name + "\t");
                }
            }
            return "";
        }
        public void AddBicycle(Bicycle adbic)
        {
                for (int i = 3; i > 0; i--)
                {
                    bicycles[i] = bicycles[i - 1];
                }
                bicycles[0] = adbic;
        }
        public string Finish()
        {
            if (natrasse == true)
            {
                counter--;
                double finish = (10000 / age * age) / (bicycles[0].Max_speed * Sred_speed);
                natrasse = false;
                return name + " " + suname + " завершил гонку за " + finish;
            }
            else return "Он находится не на трассе!";
                
        }
        
    }
}
