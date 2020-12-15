using System;

namespace TextBlockProj
{
    class Program
    {
        static void Main(string[] args)
        {
            TextBlock textBlock = new TextBlock("MyTextBlock", Color.Black, Font.Calibri);
            textBlock.textEvent = (string oldText, string newText) =>
            {
                Console.WriteLine();
                oldText = "";
                for (int i = 0; i < newText.Length + 2; i++)
                {
                    oldText += "-";
                }
                oldText += $"\n|{newText}|\n";
                for (int i = 0; i < newText.Length + 2; i++)
                {
                    oldText += "-";
                }
                Console.WriteLine(oldText);
            };
            while (true)
            {
                textBlock.Text += Console.ReadKey().KeyChar;
            }
        }
    }
}
