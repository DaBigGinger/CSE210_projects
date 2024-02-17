using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    private List<Word> _words;

    // Constructor
    public Scripture(string text)
    {
        _words = text.Split(' ').Select(word => new Word(word)).ToList();
    }

    // Method to hide random words
    // Method to hide random words
    public void HideRandomWords(int numWordsToHide)
    {
        Random rand = new Random();
        int wordsHidden = 0;

    // Check if there are fewer words left to hide than the requested number
        if (numWordsToHide > _words.Count)
            numWordsToHide = _words.Count;

        while (wordsHidden < numWordsToHide)
        {
            int index = rand.Next(_words.Count);
            if (!_words[index].IsHidden)
            {
                _words[index].IsHidden = true;
                wordsHidden++;
            }
        }
    }


    // Method to display the scripture
    public void Display(ScriptureReference reference)
    {
        Console.Clear();
        Console.WriteLine($"{reference.Book} {reference.Chapter}:{reference.StartVerse}-{reference.EndVerse}");
        foreach (Word word in _words)
        {
            if (word.IsHidden)
            {
                Console.Write("____ ");
            }
            else
            {
                Console.Write(word.Text + " ");
            }
        }
        Console.WriteLine();
    }

    // Method to check if all words are hidden
    public bool AllWordsHidden()
    {
        return _words.All(word => word.IsHidden);
    }
}
