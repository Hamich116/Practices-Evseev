using System;

namespace TestDelegates
{
    class Program
    {
        static void Main(string[] args)
        {
            TextField war = new TextField("Я незнаю что здесь можно написать", Color.Blue);

            war.CompleteText(war);
            
        }
    }
}
