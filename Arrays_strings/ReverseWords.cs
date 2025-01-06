namespace Arrays_Strings;
using System.Collections.Generic;

// Write a program that reverses the words in a given sentence without changing the
// punctuation and spaces
//     Use the following separators between the words: . , : ; = ( ) & [ ] " ' \ / ! ? (space).
// All other characters are considered part of words, e.g. C++, a+b, and a77 are
//     considered valid words.
//     The sentences always start by word and end by separator.
//     C# is not C++, and PHP is not Delphi!
// Delphi not is PHP, and C++ not is C#!
//     The quick brown fox jumps over the lazy dog /Yes! Really!!!/.
// Really Yes dog lazy the over jumps fox brown /quick! The!!!/.
public class ReverseWords
{
    public string Reverse(string sentence)
    {
        if (string.IsNullOrEmpty(sentence))
        {
            return sentence;
        }

        // Define separators as characters
        char[] separators = { '.', ',', ':', ';', '=', '(', ')', '&', '[', ']', '"', '\'', '\\', '/', '!', '?', ' ' };
        List<string> words = new List<string>();
        List<string> tokens = new List<string>();

        string currentWord = "";
        string currentSeparator = "";

        // Extract words and separators
        foreach (char ch in sentence)
        {
            if (Array.Exists(separators, sep => sep == ch))
            {
                if (!string.IsNullOrEmpty(currentWord))
                {
                    tokens.Add(currentWord); // Add word to tokens
                    words.Add(currentWord); // Add word to words list
                    currentWord = "";
                }

                currentSeparator += ch; // Build separator string
            }
            else
            {
                if (!string.IsNullOrEmpty(currentSeparator))
                {
                    tokens.Add(currentSeparator); // Add separator to tokens
                    currentSeparator = "";
                }

                currentWord += ch; // Build word
            }
        }

        if (!string.IsNullOrEmpty(currentWord))
        {
            tokens.Add(currentWord);
            words.Add(currentWord);
        }

        if (!string.IsNullOrEmpty(currentSeparator))
        {
            tokens.Add(currentSeparator);
        }

        // Reverse the words
        words.Reverse();

        // Reconstruct the sentence
        string result = "";
        int wordIndex = 0;

        foreach (string token in tokens)
        {
            if (words.Contains(token))
            {
                result += words[wordIndex]; // Add reversed word
                wordIndex++;
            }
            else
            {
                result += token; // Add separator
            }
        }

        return result;
    }
}