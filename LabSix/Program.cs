using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSix
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcom to the Pig Latin Translater!!!\n");

            char goAgain = 'y';
            do
            {
                Console.WriteLine("Enter in words to be translated into pig latin:\n");
                string input = Console.ReadLine().ToLower().Trim();

                string[] array = input.Split(' ');


                foreach (string word in array)
                {
                    Char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
                    Char[] numbersSymbols =
                    {
                        '1', '2', '3', '4', '5', '6', '7', '8', '9', '0',
                        '!', '@', '#', '$', '%', '^', '&', '*', '(',
                    };

                    if (vowels.Contains(word[0]))
                    {
                        Console.WriteLine($"{word}way");
                    }

                    else if (numbersSymbols.Contains(word[0]))
                    {
                        Console.WriteLine(word);
                        continue;
                    }

                    else
                    {
                        Char[] letters = word.ToCharArray();
                        string translatedWord = word;
                        foreach (char letter in letters)
                        {
                            if (vowels.Contains(letter))
                            {
                                break;
                            }
                            else
                            {
                                translatedWord = translatedWord.Insert(translatedWord.Length - 1, letter.ToString())
                                    .Remove(0, 1);
                            }
                        }
                        Console.WriteLine($"{translatedWord}ay");
                    }
                }
                Console.WriteLine("Would you like to translate more words?");
                Console.ReadLine();
            } while (goAgain == 'y');
            Console.WriteLine("OK, goodbye");

        }
    }
}
