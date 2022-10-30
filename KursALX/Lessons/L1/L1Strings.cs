using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace KursALX.Lessons.L1
{
    public class L1Strings
    {
        public static void Test()
        {
            string name = "Mateusz";
            name = "Ala";
            name = name + " ma kota";
            name = name + " ma kota";
            Console.WriteLine(name);

            ExpandString(name, "hello");
            Console.WriteLine(name);
            ExpandString(name, "world");
            Console.WriteLine(name);
            ExpandString(name, "something");
            Console.WriteLine(name);
        }

        public static void ExpandString(string word, string extension)
        {
            word = word + extension;
        }

        public static void ConcatinationTest()
        {
            string word1 = "Ala ma";
            string word2 = "koty dwa";

            string concat1 = word1 + word2;
            Console.WriteLine(concat1);

            string concat2 = word1 + " " + word2;
            Console.WriteLine(concat2);

            string concat3 = $"{word1} {word2} i dobrze się ma";
            Console.WriteLine(concat3);
        }
    }
}

