using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch_program
{
    //This program is used to find that vowel.
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any Char ");
            char ch = char.Parse(Console.ReadLine());
            String st = ch.ToString().ToLower();
            switch (st)
            {
                case "a":
                    Console.WriteLine(st + " is a vowel");
                    break;
                case "e":
                    Console.WriteLine(st + " is a vowel");
                    break;
                case "i":
                    Console.WriteLine(st + " is a vowel");
                    break;
                case "0":
                    Console.WriteLine(st + " is a vowel");
                    break;
                case "u":
                    Console.WriteLine(st + "is a vowel");
                    break;
                default:
                    Console.WriteLine(st + " is a vowel");
                    break;

            }
        }
    }
}
