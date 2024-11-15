using System;
using System.Data;
using System.Globalization;

namespace MethodsExercise
{
    public class Program
    {
        public static void StoryCreation()
        {
            //collect user input for story
            Console.WriteLine("What is your name?");
            string username = Console.ReadLine();
            Console.WriteLine("What is your favorite color?");
            string favcolor = Console.ReadLine();
            Console.WriteLine("What is your favorite animal");
            string favanimal = Console.ReadLine();
            Console.WriteLine("What is your favorite band?");
            string favband = Console.ReadLine();

            //write story
            Console.WriteLine($"{username}'s favorite color is {favcolor}, favorite animal is a {favanimal}, and favorite band are the {favband}");
        }
        
        //Methods for Math Operations
        public static int Add(int a, int b)
         {
             return a + b; 
         }

        public static int Subtract(int a, int b)
        {
            return a - b;
        }

        public static int Multiply(int a, int b)
        {
            return a * b;
        }
        public static int Divide(int a, int b)
        {
            return a / b;
        }
        public static int Sum(params int[] numbers) 
         { 
            int sum = 0;
            foreach (int number in numbers) 
              {
                sum += number; 
              }
            return sum;  
         }

        static void Main(string[] args)
        {
            //call story creation method
            StoryCreation();

            //call and write Math operation methods
            Console.WriteLine(Add(a: 2, b: 2));
            Console.WriteLine(Subtract(a: 2, b: 2));
            Console.WriteLine(Multiply(a: 2, b: 2));
            Console.WriteLine(Divide(a: 2, b: 2));
            Console.WriteLine(Sum(2,2,2));
        }
    }
}
