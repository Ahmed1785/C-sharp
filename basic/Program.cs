using System;
using System.Collections.Generic;
using System.Linq;

namespace basic
{
    class Program
    {
        public static void print255()
        {
            for(int i = 1; i <= 255; i++){
                Console.WriteLine(i);
            }
        }

        public static void PrintOdd255()
        {
            for(int i = 1; i <= 255; i++){
                if(i%2 == 1){
                    Console.WriteLine(i);
                }
            }
        }

        public static void Iterate()
        {
            int[] arrayOfInts = new int[10];
            for(int i = 0; i < arrayOfInts.Length; i++){
                    Console.WriteLine(arrayOfInts[i]);
                }
            }


        public static void PrintSum()
        {
            int sum = 0;
            for(int i = 1; i <= 255; i++){
                sum = sum + i;
                Console.WriteLine(sum);
            }
        }

        public static void Max()
        {
            int[] arrayOfInts = new int[10];
            int max = arrayOfInts[0];
            for(int i = 0; i < arrayOfInts.Length; i++){
                if(arrayOfInts[i] > max){
                    max = arrayOfInts[i];
                }
                Console.WriteLine(max);
            }
        }

        public static void avg()
        {
            int[] arrayOfInts = new int[10];
            int sum = 0;
            int average = 0;
            for(int i = 0; i < arrayOfInts.Length; i++){
                sum = sum + i;
                average = sum/arrayOfInts.Length;
                }
                Console.WriteLine(average);
            }

        public static void odd()
        {
            List<int> array = new List<int>();
            for(int i = 0; i < 256; i++){
                if(i%2 == 1){
                    array.Add(i);
                }
                Console.WriteLine(array);
            }
        }

        public static void greater(int y) {
            List<int> array = new List<int>();
            for(int i = 0; i < array.Count; i++){
                if(i > y){
                    array.Add(i);
                }
                Console.WriteLine(array);
            }
        }

        public static void square() {
            List<int> array = new List<int>();
            for(int i = 0; i < array.Count; i++){
                array[i] = i*i;
            }
            Console.WriteLine(array);
        }

        public static void negative() {
            List<int> array = new List<int>();
            for(int i = 0; i < array.Count; i++){
                if(array[i] < 0){
                    array[i] = 0;
                }
                Console.WriteLine(array);
            }
        }

        public static void mma() {
            List<int> array = new List<int>();
            int min = array[0];
            int max = array[0];
            int sum = 0;
            int average = 0;
            for(int i = 0; i < array.Count; i++){
                sum = sum + i;
                if(array[i] < min){
                    min = array[i];
                }
                else if(array[i] > max){
                    max = array[i];
                }
                else{
                    average = sum/array.Count;
                }
            }
        }
        public static void ShiftLeft() {
            List<int> array = new List<int>();
            for(int idx = 0; idx < array.Count - 1; idx++){
                array[idx] = array[idx + 1];
            }
            array[array.Count - 1] = 0;
        }
        public static void numbertostring() {
            // List<object> object = new List<object>();
            object[] arr = new Object[10];
            for(int i = 0; i < arr.Length; i++){
                if((int)arr[i] < 0){
                    arr[i] = "Dojo";
                }
            }
        }

        public static void randomarray() {
            Random rand = new Random();
            int[] test = new int[10];
            int sum = 0;
            for(int i = 0; i < 10; i++){
                test[i] = rand.Next(5, 26);
                sum = sum + i;
            }
            Console.WriteLine("The max value of the random array is {0}", test.Max());
            Console.WriteLine("The min value of the random array is {0}", test.Min());
            Console.WriteLine(sum);
        }

        public static void coinflip(Random rand) {
            Console.WriteLine("tossing a coin");
            string result = "Tails";
            if(rand.Next() == 0){
                result = "Heads";
            }
            Console.WriteLine(result);
        }
        
        static void Main(string[] args)
        {
            // print255();
            // PrintOdd255();
            // PrintSum();
            // Iterate();
            // Max();
            // avg();
            // odd();
            // greater(5);
            // square();
            // negative();
            // mma();
            // ShiftLeft();
            // numbertostring();

        }
    }
}

