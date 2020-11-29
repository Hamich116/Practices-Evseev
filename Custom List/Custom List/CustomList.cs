﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Praktika6
{
    class CustomList<T> : IEnumerable<T>, ICloneable
    {

        private int capasity = 1;
        int count = 0;
        public int Count { get => count; }

        public int Capasity { get => capasity; set => capasity=value; }
        public int Length { get { return list.Length; } }

        public CustomList() { }
        public CustomList(IEnumerable<T> collection) { }
        public CustomList(int capacity) { }

        T[] list = new T[0];
        public void Add(T item)
        {
            T[] newList = new T[list.Length + 1];
            list.CopyTo(newList, 0);
            newList[list.Length] = item;
            list = newList;
        }
        
        public void AddRange(IEnumerable<T> collection)
        {
            
            T[] newList = new T[list.Length + 1];
            list.CopyTo(newList, 0);
            newList[list.Length] = (T)collection;
            list = newList;
            
        }
        
        public void Clear()
        {
            list = new T[0];
        }

        public CustomList<T> Clone()
        {
            CustomList<T> customlist = new CustomList<T>();
            for (int i = 0; i < list.Length; i++)
            {
                customlist.Add(list[i]);
            }
            return customlist;
        }

        /*
        public bool Contains(T item)
        {

        }
        */

        public int IndexOf(T item)
        {
            int indexOf = -1;
            for (int i = 0; i < this.list.Length; i++)
            {
                if (list[i].Equals(item)) indexOf = i;
            }
            return indexOf;
        }
        
        
        public void Insert(int index, T item)
        {
            T[] newList = new T[list.Length + 1];
            for (int i = 0; i < index; i++)
            {
                newList[i] = list[i];
            }
            newList[index] = item;
            for (int i = index + 1; i < newList.Length; i++)
            {
                newList[i] = list[i - 1];
            }
            list = newList;

        }
        
        public void InsertRange(int index, IEnumerable<T> collection)
        {
            int counter = 0;
            int length = 0;
            foreach (var item in collection)
            {
                length++;
            }
            T[] newList = new T[list.Length + length];
            for (int i = 0; i < index; i++)
            {
                newList[i] = list[i];
            }
            foreach (var item in collection)
            {
                newList[index + counter] = item;
                counter++;
            }
            
            for (int i = index + length; i < newList.Length; i++)
            {
                newList[i] = list[i - length];
            }
            list = newList;
        }
        
        public void Remove(T item)
        {
            int index = Array.IndexOf(list, item);
            if (index == -1) return;
            T[] newList = new T[list.Length - 1];
            int offset = 0;
            for (int i = 0; i < list.Length; i++)
            {
                if (i == index) { offset++; continue; }
                newList[i - offset] = list[i];
            }
            list = newList;

        }
        public void RemoveAt(int index)
        {

            T[] newList = new T[list.Length - 1];
            for (int i = 0; i < index; i++)
            {
                newList[i] = list[i];
            }
            for (int i = index; i < newList.Length; i++)
            {
                newList[i] = list[i + 1];
            }
            list = newList;
        }
        /*
        public void Reverse(int index, int count)
        {

        }
        public void Reverse()
        {

        }
        */

        public IEnumerator<T> GetEnumerator()
        {
            return ((IEnumerable<T>)list).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return list.GetEnumerator();
        }

        object ICloneable.Clone()
        {
            return list.Clone();
        }
    }
}
