using System;

namespace _9prk
{
    class Program
    {
        static void Main(string[] args)
        {
            TextBlock textBlock = new TextBlock("MyTextBlock", Color.Black, Font.Calibri);
            textBlock.TextChanged += (object sender, TextChangedEventArgs e) =>
            {
                Console.WriteLine();
                for (int i = 0; i < e.NewText.Length + 2; i++)
                {
                    e.OldText += "-";
                }
                e.OldText += $"\n|{e.NewText}|\n";
                for (int i = 0; i < e.NewText.Length + 2; i++)
                {
                    e.OldText += "-";
                }
                Console.WriteLine(e.OldText);
            };

            while (true)
            {
                textBlock.Text += Console.ReadKey().KeyChar;
            }
        }
    }
}
