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
            customList1.Insert(2, 30);
            foreach (var item in customList1)
            {
                Console.WriteLine(item);
            }

           /* customList2.AddRange(customList1);*/ // ошибка

            //customList2.Remove(2);
            //foreach (var item in customList2)
            //{
            //    Console.WriteLine(item);
            //}
            
            //customList3.Clear();
            //foreach (var item in customList3)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine(customList1.IndexOf(125) ); 
        }
    }
}
