using System;
using System.Collections.Generic;
using System.Text;

namespace StringReverse
{
    internal class Class1
    {
        public static void Array()
        {
            Console.WriteLine("Enter number of character want to use:");
            int n= int.Parse(Console.ReadLine());

            char [] array = new char[n];

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Enter character in Position {0}:", i);
                array[i] = char.Parse(Console.ReadLine());
            }

            Console.WriteLine("Character Stored in Array Are: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("{0}", array[i]);
            }

            Console.WriteLine("\n\nReverse String of Array :");
            for (int i = array.Length - 1; i >= 0; i--)
            {
                Console.Write("{0}", array[i]);
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}

