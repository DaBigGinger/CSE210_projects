using System;
using System.Collections.Generic;
using System.Linq;


public class Word
{
    public string Text { get; set; }
    public bool IsHidden { get; set; }

    // Constructor
    public Word(string text)
    {
        Text = text;
        IsHidden = false;
    }
}