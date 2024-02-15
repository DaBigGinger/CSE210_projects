using System;

public class Scripture
{
    private List<Word> _words;

    // Constructor
    public Scripture(string text)
    {
        _words = text.Split(' ').Select(word => new Word(word)).ToList();
    }

    // Method to hide random words
    public void HideRandomWords()
    {
        Random rand = new Random();
        int numWordsToHide = rand.Next(1, _words.Count / 2); // Adjust range as needed
        int wordsHidden = 0;

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
