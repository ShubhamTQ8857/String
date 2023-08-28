using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String
{
    internal class AllStringMethods
    {
        static void Main(string[] args)
        {
            /*string message = "Hello to all";
            Console.WriteLine(message);

            string message1 = "I Love Cricket";
            Console.WriteLine(message1);

            Console.WriteLine(message.GetHashCode()); //returns the address location of variable
            Console.WriteLine(message1.GetHashCode());

            message = message + " How are you all";
            Console.WriteLine(message);
            Console.WriteLine(message.GetHashCode());*/

            /*string s1 = " Hi All ";
            Console.WriteLine(s1);
            //Trim method is used to to remove all leading and white-space characters from the current string object.
            Console.WriteLine(s1.Trim()); */

            /*string str1 = "Hello";
            string str2 = "C#";
            string str3 = ".Net Framework";
            // Concat() method is used to concatenate multiple string objects.
            string str = string.Concat(str1," ", str2, str3);
            Console.WriteLine(str);*/

            /*string str = "I a finding Index";
            //The C# IndexOf() is used to get index of the specified character present in the string. It returns index as an integer value.
            Console.WriteLine("Index of f is: "+str.IndexOf("f"));
            int index = str.IndexOf("i"); //returns the  1st occurance of i
            Console.WriteLine(index);
            Console.WriteLine(str.IndexOf("J")); // It will return -1 if char */

            /*string str = "Hi i AM ShuBham";
            //The C# ToLower() method is used to convert a string into lowercase. It returns a string in lower case.
            Console.WriteLine("String In Lower Case: " + str.ToLower());
            //The C# ToUpper() method is used to convert a string into uppercase. It returns a string in upper case.*/

            string str = "Hi I Am String Array";
            Console.WriteLine(str);
            //The C# Split() method is used to split a string into substrings on the basis of characters in an array. It returns string array.
            
            string[] str1 = str.Split(',');
        }

    }
}
