
using System;
using System.Collections.Generic;
using System.Text;

namespace TextBlockProj
{
    public delegate void Action(string oldText, string newText);
    public class TextBlock
    {
        string name;
        string text;
        Color textColor;
        Font textFont;
        public Action textEvent;

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
                textEvent?.Invoke(text, value);
                text = value;
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
