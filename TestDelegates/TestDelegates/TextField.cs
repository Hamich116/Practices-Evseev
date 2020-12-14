using System;
using System.Collections.Generic;
using System.Text;

namespace TestDelegates
{
    public delegate void ChangeText(TextField textField);

    public class TextField
    {
        
        public string Text { get; set; } = "Изначальный текст";
        public Color Color { get; set; } = Color.Black;
        public int Length { get; private set; }
        public int SizeText { get; set; } = 30;
        public ChangeText ToChange;

        public TextField(string Text, Color Color)
        {
            this.Text = Text;
            this.Color = Color;
            this.Length = Text.Length;
        }

        

        public void CompleteText()
        {
            int OldLenght = Length;
            Console.WriteLine(Text);
            for (; ; )
            {
                Text += Console.ReadLine();
                Length = Text.Length;
                if (this.Length != OldLenght)
                {
                    Console.WriteLine(Text);
                    break;
                }
            }

        }
        public static void ChangeColor(TextField textField)
        {
            textField.Color++;
            Console.WriteLine($"Цвет изменился на {textField.Color}");
        }

        public static void ChangeSizeText(TextField textField)
        {
            Random rnd = new Random();
            textField.SizeText = rnd.Next(10, 64);
            Console.WriteLine($"Размер текста изменился на {textField.SizeText}");
        }
    }

}
