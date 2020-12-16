using System;
using System.Collections.Generic;
using System.Text;

namespace _9prk
{
    public class TextChangedEventArgs
    {
        string oldText;
        string newText;

        public string OldText
        {
            get => oldText;
            set => oldText = value;
        }
        public string NewText
        {
            get => newText;
            set => newText = value;
        }

        public TextChangedEventArgs(string oldText, string newText)
        {
            this.oldText = oldText;
            this.newText = newText;
        }
    }
}
