using System;
using System.Collections.Generic;
using System.Text;

namespace Homework61PigLatin
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Char> vowels = new List<Char>();
            vowels.Add('a');
            vowels.Add('e');
            vowels.Add('i');
            vowels.Add('o');
            vowels.Add('u');
            vowels.Add('A');
            vowels.Add('E');
            vowels.Add('I');
            vowels.Add('O');
            vowels.Add('U');

            Console.Write("Va rog introduceti textul pentru tradus: ");
            string text = Console.ReadLine();
            bool newWord = true;
            StringBuilder wordToAdd = new StringBuilder();
            StringBuilder wordRemaining = new StringBuilder();
            StringBuilder textTranslated = new StringBuilder();
            for (int i=0;i<text.Length;i++)
            {
                bool newWordBackup = newWord;
                if (newWordBackup==true && text[i]!=' ' && vowels.Contains(text[i]))
                {
                    wordRemaining.Append(text[i]);
                    newWord = false;
                }
                if (newWordBackup == true && text[i] != ' ' && !vowels.Contains(text[i]))
                {
                    wordToAdd.Append(text[i]);                   
                }
                if (newWordBackup == false && (text[i] == ' ' || i==text.Length-1))
                {
                    if (i == text.Length - 1) wordRemaining.Append(text[i]);
                    textTranslated.Append(wordRemaining);
                    textTranslated.Append(wordToAdd);
                    textTranslated.Append("ay");
                    if (i != text.Length - 1) { textTranslated.Append(' '); }
                    wordRemaining.Clear();
                    wordToAdd.Clear();
                    newWord = true;
                }
                if (newWordBackup == false && text[i] != ' ')
                {
                    wordRemaining.Append(text[i]);
                }

            }
            Console.WriteLine($"Textul tradus este: {textTranslated}");
        }
    }
}
