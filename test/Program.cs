using System;
using System.Collections.Generic;
using System.Linq;

namespace test
{
    class Program
    {
        public static void RandomArray() {
            Random rand = new Random();
            int[] randomArr = new int[10];
            int sum = 0;
            for(int i = 0; i < randomArr.Length; i++){
                int val = rand.Next(5,26);
                randomArr[i] = val;
                sum += val;
            }
            Console.WriteLine(randomArr.Max());
            Console.WriteLine(randomArr.Min());
            Console.WriteLine(sum);
        }
    
        public static void TossCoin() {
            Console.WriteLine("Tossing a Coin");
            Random rand = new Random();
            string results = "tails";
            if(rand.Next() == 1){
                results = "heads";
            }
            Console.WriteLine(results);
        }

        public static void Names() {
            string[] names = new string[5] {"Todd", "Tiffany", "Charlie", "Geneva", "Sydney"};
            Random rand = new Random();
            for(var i = 0; i < names.Length - 1; i++){
                int randomindex = rand.Next(i + 1, names.Length - 1);
                string temp = names[i];
                names[i] = names[randomindex];
                names[randomindex] = temp;
                //Print each name in it's new position
                Console.WriteLine(names[i]);
            }
            Console.WriteLine(names[names.Length - 1]);

            List<string> nameList = new List<string>();
            foreach(var name in names) {
                nameList.Add(name);
            }
            nameList.ToArray();
            Console.WriteLine(nameList);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // RandomArray();
            // TossCoin();
            Names();
        }
    }
}

