using System;
using System.Collections.Generic;
using System.Text;

namespace _9prk
{
    public class TextBlock
    {
        public event EventHandler<TextChangedEventArgs> TextChanged;
        string name;
        string text;
        Color textColor;
        Font textFont;
        public string Name
        {
            get => name;
            set => name = value;
        }
        public string Text
        {
            get => text;
            set
            {
                string oldtext = this.text;
                this.text = value;
                TextChanged?.Invoke(this, new TextChangedEventArgs(oldtext, value));
            }
        }
        public Color TextColor
        {
            get => textColor;
            set => textColor = value;
        }
        public Font TextFont
        {
            get => textFont;
            set => textFont = value;
        }

        public TextBlock(string name, Color color, Font font)
        {
            this.name = name;
            this.textColor = color;
            this.textFont = font;
        }
    }
}
