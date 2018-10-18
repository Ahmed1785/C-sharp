using System;
using System.Collections.Generic;

namespace boxed
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            List<object> flavors = new List<object>();
            flavors.Add(7);
            flavors.Add(28);
            flavors.Add(-1);
            flavors.Add(true);
            flavors.Add("chair");
            Console.WriteLine(flavors.Count);
            Console.WriteLine(flavors[3]);

             int sum = 0;
            foreach(var obj in flavors) {
                Console.WriteLine(obj);
                if(obj is int) {
                    sum += (int)obj;
                }
            }
            Console.WriteLine("The sum of all the integers in the list is {0}", sum);
        }
    }
}

