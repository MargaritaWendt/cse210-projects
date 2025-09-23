using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();
        foreach (var w in text.Split(' '))
        {
            _words.Add(new Word(w));
        }
    }

    public void HideRandomWords(int count = 3)
    {
        Random rand = new Random();

        List<int> visibleIndexes = new List<int>();
        for (int i = 0; i < _words.Count; i++)
            if (!_words[i].IsHidden())
                visibleIndexes.Add(i);

        if (visibleIndexes.Count >= count)
        {
            for (int i = 0; i < count; i++)
            {
                int randIndex = rand.Next(visibleIndexes.Count);
                int wordIndex = visibleIndexes[randIndex];
                _words[wordIndex].Hide();
                visibleIndexes.RemoveAt(randIndex);
            }
        }
        else
        {
            foreach (int index in visibleIndexes)
            {
                _words[index].Hide();
            }
        }
    }

    public bool IsCompletelyHidden()
    {
        foreach (var word in _words)
            if (!word.IsHidden())
                return false;
        return true;
    }

    public void Display()
    {
        Console.Clear();
        Console.WriteLine(_reference.GetReferenceText());
        foreach (var word in _words)
        {
            Console.Write(word.Display() + " ");
        }
        Console.WriteLine();
    }
}