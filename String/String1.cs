using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String
{
    internal class String1
    {
        static void Main(string[] args)
        {
            // concat,Trim,TrimStart,TrimEnd,IndexOf,LastIndexOf ,ToUpper , ToLower
            // Split, ToCharArray,
            // Length - property
            string message = "Hello to all";
            string message2 = "hello to all";
            // Methods of string class
            string str1 = string.Concat(message, " ", message2.TrimEnd());
            Console.WriteLine(str1);
            Console.WriteLine(str1.Trim());

            Console.WriteLine(message2.ToUpper());
            Console.WriteLine(message2.ToLower());
            Console.WriteLine("index  - " + message2.IndexOf('o'));// returns the first occurance
            Console.WriteLine("last index" + message2.LastIndexOf('o'));

            // convert string to string array

            string[] strarr = message2.Split(',');
            // convert string to char array
            char[] ch = message.ToCharArray();

            // convert char array to a string
            string str2 = new string(ch);
            Console.WriteLine(str2);

            foreach (char c in ch)
            {
                Console.WriteLine(c);
            }

            //Console.WriteLine(strarr[0]);// Good
            //Console.WriteLine(strarr[1]); // morning

            foreach (string s in strarr)
            {
                Console.WriteLine(s);
            }

            for (int i = 0; i < message2.Length; i++)
            {
                Console.WriteLine(message2[i]);
            }
        }

    }
}
