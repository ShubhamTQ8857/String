using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String
{
    internal class String3
    {
        static void Main(string[] args)
        {
           
            {
                string str = "";
                if (string.IsNullOrEmpty(str))
                {
                    Console.WriteLine("string is Empty");
                }
                Console.WriteLine(str);

                Console.WriteLine("Enter Name");
                string name = Console.ReadLine();
                if (string.IsNullOrEmpty(name))
                {
                    Console.WriteLine("Name is required");
                }
                else
                {
                    Console.WriteLine("Hello " + name);
                }

            }
        }
    }
}

