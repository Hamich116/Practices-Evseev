using System;
using System.Collections;
using System.Collections.Generic;

namespace Praktika6
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomList<int> customList1 = new CustomList<int>() { 12, 578 };
            CustomList<int> customList2 = new CustomList<int>() { 1, 2, 3, 4, 5 };
            CustomList<int> customList3 = new CustomList<int>() { 132, 15, 45, 46 };
            CustomList<int> customList4 = new CustomList<int>() { 187, 48, 78 };
            
            customList1.Add(15);
            customList1.Insert(3, 30);
            foreach (var item in customList1)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Произошел RemoveAt");
            customList1.RemoveAt(1);
            foreach (var item in customList1)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Специально для Эмиля:");
            Console.WriteLine(customList1.IndexOf(30));
            Console.WriteLine("Делаю невозможное:");
            customList1.InsertRange(2, customList4);
            foreach (var item in customList1)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Переделываю Эмиля Reverse");
            customList2.Reverse();
            foreach(var item in customList2)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("AddRange");
            customList2.AddRange(customList4);
            foreach (var item in customList2)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Remove");
            customList2.Remove(5);
            foreach (var item in customList2)
            {
                Console.WriteLine(item);
            }
        }
    }
}
