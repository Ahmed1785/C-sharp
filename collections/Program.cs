using System;
using System.Collections.Generic;

namespace collections
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] arrayOfInts = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            for(int idx = 0; idx < arrayOfInts.Length; idx++){
                Console.Write(arrayOfInts[idx]);
            }

            string[] arrayOfStrings = {"Tim"+ " "+ "Speros"+ " "+ "Martin"+ " "+ "Nikki"+ " "+ "Sarah"};
            for(int idx = 0; idx < arrayOfStrings.Length; idx++){
                Console.Write(arrayOfStrings[idx]);
            }

            bool[] boolArray = new bool[10];
            for(int i = 0; i < 10; i++)
            {
                if(i % 2 == 0){
                    boolArray[i] = true;
                }
                else {
                    boolArray[i] = false;
                }
                Console.WriteLine(boolArray[i]);
            }

            int[,] mult = new int[10,10];
            for(int x = 0; x < 10; x++)
            {
                for(int y = 0; y < 10; y++)
                {
                    mult[x, y] = (x + 1) * (y + 1);
                }
            }

            //Following code displays the multiplication table
            for(int x = 0; x < 10; x++)
            {
                string display = "[ ";
                for(int y = 0; y < 10; y++)
                {
                    display += mult[x, y] + ", ";
                    //Add an extra space for single digit values
                    if(mult[x,y] < 10)
                    {
                        display += " ";
                    }
                }
                display += "]";
                Console.WriteLine(display);
            }
            List<string> flavors = new List<string>();
            flavors.Add("Vanilla");
            flavors.Add("Chocolate");
            flavors.Add("Strawberry");
            flavors.Add("Cookies and Creame");
            flavors.Add("Carmel");
            Console.WriteLine(flavors.Count);
            Console.WriteLine(flavors[2]);
            flavors.RemoveAt(2);
            Console.WriteLine(flavors.Count);

            Dictionary<string,string> profile = new Dictionary<string,string>();
            profile.Add("Tim", "Vanilla");
            profile.Add("Sarah", "Carmel");
            profile.Add("Nikki", "Chocolate");
            profile.Add("Martin", "Strawberry");

            foreach (var entry in profile)
            {
            Console.WriteLine(entry.Key + " - " + entry.Value);
            }
        }
    }
}
