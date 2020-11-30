using System;
using System.Collections.Generic;
using System.Text;

namespace praktika1
{
    class Bicycle
    {
        private string name;
        private byte max_speed;
        private int price;
        public string Name { get => name; set => name = value; }
        public byte Max_speed { get => max_speed; set => max_speed = value; }
        public int Price { get => price; set => price = value; }
        public Bicycle(string name,byte max_speed,int price)
        {
            this.name = name;
            this.max_speed = max_speed;
            this.price = price;
        }

    }

}
