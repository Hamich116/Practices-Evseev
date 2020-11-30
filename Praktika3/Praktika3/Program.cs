using System;
using System.Security.Cryptography.X509Certificates;

namespace Praktika3
{
    class Program
    {
        static void Main(string[] args)
        {
            Director Sergey = new Director("Сергей", "Старых", true, 24, 4, "Директор", 200000, false, false, 10, 10);
            Accountant Askar = new Accountant("Аскар", "Волковых", true, 20, 1, "Бухгалтер", 50000);
            ITSpecialist Tom = new ITSpecialist("Том", "Воронин", true, 35, 10, "Специалист", 3);
            ITSpecialist Tom1 = new ITSpecialist("Том", "Хамычов", true, 35, 10, "Специалист", 3);
            ITSpecialist Artur = new ITSpecialist("Артур", "Ислымыч", true, 35, 10, "Специалист", 3);
            ITSpecialist Stas = new ITSpecialist("Стас", "Генадиев", true, 35, 10, "Специалист", 3);
            ITSpecialist Azalya = new ITSpecialist("Азалия", "Воробьева", false, 30, 7, "Специалист", 4);
            ITSpecialist Azalya1 = new ITSpecialist("Азалия", "Воробьева", false, 30, 7, "Специалист", 4);
            ITSpecialist Azalya2 = new ITSpecialist("Азалия", "Воробьева", false, 30, 7, "Специалист", 4);
            ITSpecialist Azalya3 = new ITSpecialist("Азалия", "Воробьева", false, 30, 7, "Специалист", 4);
            OfficeClerk Danil = new OfficeClerk("Данил", "Новых", true, 33, 10, "Офис");
            OfficeClerk Danil1 = new OfficeClerk("Данил", "Новых", true, 33, 10, "Офис");
            OfficeClerk Danil2 = new OfficeClerk("Данил", "Новых", true, 33, 10, "Офис");
            OfficeClerk Danil3 = new OfficeClerk("Данил", "Новых", true, 33, 10, "Офис");
            OfficeClerk Danil4 = new OfficeClerk("Данил", "Новых", true, 33, 10, "Офис");
            OfficeClerk Danil5 = new OfficeClerk("Данил", "Новых", true, 33, 10, "Офис");
            OfficeClerk Danil6 = new OfficeClerk("Данил", "Новых", true, 33, 10, "Офис");
            OfficeClerk Danil7 = new OfficeClerk("Данил", "Новых", true, 33, 10, "Офис");
            OfficeClerk Danil8 = new OfficeClerk("Данил", "Новых", true, 33, 10, "Офис");
            OfficeClerk Danil9 = new OfficeClerk("Данил", "Новых", true, 33, 10, "Офис");
            OfficeClerk Danil10 = new OfficeClerk("Данил", "Новых", true, 33, 10, "Офис");
            OfficeClerk Danil11 = new OfficeClerk("Данил", "Новых", true, 33, 10, "Офис");
            OfficeClerk Danil12 = new OfficeClerk("Данил", "Новых", true, 33, 10, "Офис");
            OfficeClerk Danil13 = new OfficeClerk("Данил", "Новых", true, 33, 10, "Офис");
            OfficeClerk Danil14 = new OfficeClerk("Данил", "Новых", true, 33, 10, "Офис");
            ServiceStaff Ilfir = new ServiceStaff("Ильфир", "Зароботьев", true, 40, 20, "Сервис");
            ServiceStaff Ilfir1 = new ServiceStaff("Ильфир", "Зароботьев", true, 40, 20, "Сервис");
            ServiceStaff Ilfir2 = new ServiceStaff("Ильфир", "Зароботьев", true, 40, 20, "Сервис");
            ServiceStaff Ilfir3 = new ServiceStaff("Ильфир", "Зароботьев", true, 40, 20, "Сервис");
            ServiceStaff Ilfir4 = new ServiceStaff("Ильфир", "Зароботьев", true, 40, 20, "Сервис");
            ServiceStaff Ilfir5 = new ServiceStaff("Ильфир", "Зароботьев", true, 40, 20, "Сервис");
            ServiceStaff Ilfir6 = new ServiceStaff("Ильфир", "Зароботьев", true, 40, 20, "Сервис");
            ServiceStaff Ilfir7 = new ServiceStaff("Олег", "Зароботьев", true, 40, 20, "Сервис");
            Worker[] workers = { Sergey, Askar, Tom, Tom1, Artur,Ilfir,Danil13,Ilfir7 };
            
            Stas.ReceiveMoney();
            Danil.ReceiveMoney();
            Ilfir.ReceiveMoney();
            Askar.ReceiveMoney();
            Sergey.ReceiveMoney();
            Artur.ReceiveMoney();
            Tom.ReceiveMoney();
            Tom1.ReceiveMoney();
            Danil13.ReceiveMoney();
            Askar.ReceiveMoney();
            Ilfir.BudgetServiceStaff();
            Ilfir7.ReceiveMoney();
            Console.WriteLine(Worker.budget);
            Askar.Report(workers);
        }
    }
}
