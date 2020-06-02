using System;
using System.Collections.Generic;

namespace boxing_unboxing
{
    class Program
    {

        static List<object> GetObjectList ()
        {
            return new List<object> ()
            {
                7,
                28,
                -1,
                true,
                "chair"
            };
        }

        static void PrintObjectList (List<object> ol)
        {
            string s = "";
            int num = 0;
            for (int i = 0; i < ol.Count; i++)
            {
                if (ol[i] is int)
                {
                    num += (int) ol[i];
                }
                else if (ol[i] is string)
                {
                    s += ol[i] + " ";
                }
            }
            Console.WriteLine($"the strings are:\n{s}");
            Console.WriteLine($"the numbers are:\n{num}");
        }

        static void Main(string[] args)
        {
            PrintObjectList( GetObjectList () );
        }
    }
}
