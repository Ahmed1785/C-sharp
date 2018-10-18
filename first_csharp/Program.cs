using System;
using System.Collections.Generic;


namespace first_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // Console.WriteLine("The {0} cow jumped over the {1} {2} times", "orange", "sun", 7);
            // Random rand = new Random();

            // for(int val = 1; val <= 100; val++){
            //     if (val % 3 == 0)
            //     {
            //         if( val % 5 == 0){
            //             Console.WriteLine("fizzbuzz");
            //         }
            //         else{
            //             Console.WriteLine("fizz");
            //         }
            //     }
            //     else if (val % 5 == 0)
            //     {
            //         Console.WriteLine("buzz");
            //     }
            // }
            // for(int val = 1; val <= 100; val++){
            //     if(val % 3 == 0 || val % 5 == 0){
            //         Console.WriteLine(val);
            //     }
            // }

            // for(int val = 1; val <= 255; val++){
            //     Console.WriteLine(val);
            // }
// for(int val = 1; val <= 100; val++)
// {
//     //Prints the next random value between 2 and 8
//     // Console.WriteLine(rand.Next(2,75));
//     Console.WriteLine(val);
// }

        Dictionary<string,string> profile = new Dictionary<string,string>();
//Almost all the methods that exists with Lists are the same with Dictionaries
profile.Add("Name", "Speros");
profile.Add("Language", "PHP");
profile.Add("Location", "Greece");
Console.WriteLine("Instructor Profile");
Console.WriteLine("Name - " + profile["Name"]);
Console.WriteLine("From - " + profile["Location"]);
Console.WriteLine("Favorite Language - " + profile["Language"]);

foreach (var entry in profile)
{
 Console.WriteLine(entry.Key + " - " + entry.Value);
}

        }
    }
}
