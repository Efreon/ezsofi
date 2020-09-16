using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedProgramming
{
    public class PostIt
    {
        string backgroundColor;
        string text;
        string textColor;

        public PostIt(string backgroundColor, string text, string textColor)
        {
            this.backgroundColor  = backgroundColor;
            this.text = text;
            this.textColor = textColor;
        }
    }
}