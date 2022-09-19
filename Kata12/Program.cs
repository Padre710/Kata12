using System;
using System.Collections.Generic;
using System.Linq;

//Write a function that takes in a string of one or more words, 
//and returns the same string, but with all five or more letter words reversed 
//(Just like the name of this Kata). Strings passed in will consist of only letters and spaces.
//Spaces will be included only when more than one word is present.

//Examples:

//spinWords("Hey fellow warriors") => returns "Hey wollef sroirraw"
//spinWords("This is a test") => returns "This is a test"
//spinWords("This is another test")=> returns "This is rehtona test"

namespace Kata12
{
    public class Kata
    {
        public static string SpinWords(string sentence)
        {
            List<string> list = new List<string>();

            foreach (var a in sentence.Split(" "))
            {
              if (a.Length < 5)
                {
                    list.Add(a);
                }
              else
                {
                    string something = string.Empty;
                    for (int i = a.Length-1; i >=0; i--)
                    {
                        something += a[i];
                    }
                    list.Add(something);
                }              
            }

            string answer = string.Join(" ", list);
            

            return answer;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            Console.WriteLine(Kata.SpinWords("Hey fellow warriors"));
            Console.WriteLine(Kata.SpinWords("This is another test"));
            Console.WriteLine(Kata.SpinWords("This is a test"));
        }
    }
}
