using System;
using static System.Net.Mime.MediaTypeNames;
using System.Linq;
using System.Text.RegularExpressions;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main()
        {
            //Console.Write("Enter an arithmetic expression with '+' and '-' operators: ");
            //string inputExpression = Console.ReadLine();

            //string[] tokens = inputExpression.Split(new char[] { '+', '-' }, StringSplitOptions.RemoveEmptyEntries);

            //double result = Convert.ToDouble(tokens[0]);

            //for (int i = 1; i < tokens.Length; i++)
            //{
            //    char operatorToken = inputExpression[inputExpression.IndexOf(tokens[i]) - 1];
            //    double numberToken = Convert.ToDouble(tokens[i]);

            //    if (operatorToken == '+')
            //    {
            //        result += numberToken;
            //    }
            //    else if (operatorToken == '-')
            //    {
            //        result -= numberToken;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Invalid operator: " + operatorToken);
            //        return;
            //    }
            //}

            //Console.WriteLine("Result: " + result);







            // string ChangeSentenceCase(string text)
            //{
            //    if (string.IsNullOrEmpty(text))
            //        return text;

            //    string[] sentences = text.Split(new char[] { '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

            //    for (int i = 0; i < sentences.Length; i++)
            //    {
            //        if (!string.IsNullOrEmpty(sentences[i]))
            //        {
            //            sentences[i] = char.ToUpper(sentences[i][0]) + sentences[i].Substring(1);
            //        }
            //    }

            //    string newText = string.Join(". ", sentences);

            //    return newText;
            //}

            //   Console.Write("Please enter a text: ");
            //   string inputText = Console.ReadLine();

            //   string outputText = ChangeSentenceCase(inputText);

            //   Console.WriteLine("Input text: " + inputText);
            //   Console.WriteLine("Source text: " + outputText);
            ////я використала  StringSplitOptions.RemoveEmptyEntries для того щоб видалити пусті записи











            
            
            string text = @"To be, or not to be, that is the question,
            Whether 'tis nobler in the mind to suffer
            The slings and arrows of outrageous fortune,
            Or to take arms against a sea of troubles,
            And by opposing end them? To die: to sleep;
            No more; and by a sleep to say we end
            The heart-ache and the thousand natural shocks
            That flesh is heir to, 'tis a consummation
            Devoutly to be wish'd. To die, to sleep";

            string forbiddenWord = "die";
            string replacement = new string('*', forbiddenWord.Length);

            int replacementsCount;
            string newText = text.Replace(forbiddenWord, replacement);
            replacementsCount = (text.Length - newText.Length) / forbiddenWord.Length;

            Console.WriteLine("New text:\n" + newText);
            Console.WriteLine("\nStatistics: " + replacementsCount + " replacements of the word '" + forbiddenWord + "'");
            
        }
    }
}