using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String
{
    internal class StringAssignments
    {
        static void Main(string[] args)
        {
            //Write Program to split  string into 2 tokens where string is "HELLO$WORD"
            /*string str = "HELLO$WORLD";
            string[] sarray = str.Split('$');
            Console.WriteLine(sarray[0]);
            Console.WriteLine(sarray[1]);*/

            //Write a C# program to find first occurrence of a character in a given string.
            /*string str = "HELLO$WORLD";
            Console.WriteLine(str.IndexOf('H'));*/

            //Write a C# program to count occurrences of a character in given string.
            /* string str = "HELLO$WORLD";
             Console.WriteLine(str.IndexOf('L') + "=1st Occurance of L"); ;
             char[] ch = str.ToCharArray();
             int cnt = 0;
             for (int i = 0; i < ch.Length; i++)
             {
                 if (ch[i] == 'L')
                 {
                     cnt++;
                 }
             }
             Console.WriteLine($"Occurance of L={cnt}");*/

            //Write a C# program to trim leading white space characters in a string.
            /*string str = "   HELLO$WORLD    ";
            string str1 = string.Concat(str.Trim());
            Console.WriteLine(str1);*/

            //Write a C# program to count total number of words in a string. 
            /*string str = "HELLO$WORLD";
            int wordscount = 0;
            for (int i = 0; i < str.Length; i++)
            {
                wordscount++;
            }
            Console.WriteLine($"Total Words in String={wordscount}");*/

            //Write a c# program to remove all the all occurances of a character from string.

            //Write a c# program to trim trailing while spaces characters in a string.

            //Write a c# program to toggle case of each character of a string.
            //Incomplete
            /*string str = "IiNDia";
            char[] ch = str.ToCharArray();

            for (int i=0; i<ch.Length; i++)
            {
                if (ch[i] >= 65 && ch[i] <= 90)
                {
                    int a = (int)ch[i] + 32;
                    ch[i] = (char)a;
                }
                else
                {
                    int A = (int)ch[i] - 32;
                    ch[i] = (char)A;
                }
            }*/

            string str = "InDiA";

            /*char[] ch = str.ToCharArray();
            
            
            for(int i=0; i<ch.Length; i++)
            {
                if (ch[i] >= 65 && ch[i] <= 90)
                {
                    char a = ch[i].ToU
                }
            }*/
            

            //Write c# program to count total numbers of constants and vowels in a string.
            /*Console.WriteLine("Enter String :");
            string str = Convert.ToString(Console.ReadLine());
            char[] c = str.ToCharArray();
            int cnt1 = 0; int cnt2 = 0;
            for (int i = 0; i < c.Length; i++)
            {
                if (c[i] == 'a' || c[i] == 'e' || c[i] == 'o' || c[i] == 'u' || c[i] == 'A' || c[i] == 'E' || c[i] == 'O' || c[i] == 'U')
                {
                    cnt1++;
                }

                else if (c[i] != ' ')
                {
                    cnt2++;
                }
            }
            Console.WriteLine("Vowels count : " + cnt1);
            Console.WriteLine("Constants : " + cnt2);*/

            //Write c# program to reverse order of a words in a given string
            // check again
            /*Console.WriteLine("Enter String :");
            string str = Convert.ToString(Console.ReadLine());
            for (int i = str.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(str[i]);
            }*/

            //Write a c# program to find total numbers of characters, digits or special characters in a string.
            /* string str = "dfvt12425,/=#";

             int alphacount = 0;
             int digcount = 0;
             int spcharcount = 0;
             char[] ch = str.ToCharArray();
             for(int i = 0; i<ch.Length; i++)
             {
                 if ((ch[i] >= 'A' && ch[i] <= 'Z') || (ch[i] >= 'a' && ch[i] <= 'z'))
                 {
                     alphacount++;
                 }
                 else if (ch[i] >= '0' && ch[i] <= '9')
                 {
                     digcount++;
                 }
                 else
                 {
                     spcharcount++;
                 }
             }
             Console.WriteLine($"Alphabet Count: {alphacount}, Digit Count: {digcount}, Special Charcater Count: {spcharcount}");*/

            //WAP to check wheather two strings are anagram or not.
            /*string str1 = "cArEE";
            string str2 = "race";

            char[] ch1 = str1.ToLower().ToCharArray();
            char[] ch2 = str2.ToLower().ToCharArray();

            Array.Sort(ch1);
            Array.Sort(ch2);

            string str3 = new string(ch1);
            string str4 = new string(ch2);

            if(str3==str4)
            {
                Console.WriteLine("Strings Are Anagram");
            }
            else
            {
                Console.WriteLine("Strings Are Not Anagram");
            }*/

            //Write the c# program to find the longest word in c# program.
            /*string str = "Shubham Sameer Khadke";
            Console.WriteLine(str);

            string[] str1 = str.Split(' ');
            string longestword = "";
            int max = 0;

            for(int i=0; i<str1.Length; i++)
            {
                int a = str1[i].Length;
                if(a>max)
                {
                    max = a;
                    longestword = str1[i];
                }
            }
            Console.WriteLine(longestword);*/


















        }



    }

}

