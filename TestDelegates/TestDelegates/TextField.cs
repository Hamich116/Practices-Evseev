using System;
using System.Collections.Generic;
using System.Text;

namespace TestDelegates
{
    
    class TextField
    {
        public delegate void ChangeText(TextField textField);
        public string Text { get; set; } = "Изначальный текст";
        public Color Color { get; set; } = Color.Black;
        public int Length { get; private set; }
        public int SizeText { get; set; } = 30;
        
        public TextField(string Text, Color Color)
        {
            this.Text = Text;
            this.Color = Color;
            this.Length = Text.Length;
        }

        private ChangeText change = ChangeColor + new ChangeText(ChangeSizeText);

        public static void CompleteText(TextField textField)
        {
            int OldLenght = textField.Length;
            Console.WriteLine(textField.Text);
            for(; ; )
            {
                textField.Text += " " + Convert.ToString(Console.ReadLine());
                textField.Length = textField.Text.Length;
                if (textField.Length != OldLenght)
                {
                    Console.WriteLine(textField.Text);
                    textField.change(textField);
                    Console.WriteLine($"Цвет изменился на {textField.Color}" );
                    Console.WriteLine($"Размер текста изменился на {textField.SizeText}");
                    break;
                }
            }
            
        }

        static public void ChangeColor(TextField textField)
        {
            textField.Color++;
        }

        static public void ChangeSizeText(TextField textField)
        {
            Random rnd = new Random();
            textField.SizeText = rnd.Next(10, 64);
        }
    }
    
}
