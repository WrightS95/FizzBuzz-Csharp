using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int num = 1; num <= 100; num++) 
            {                                    
                if(num % 3 == 0 && num % 5 == 0) 
                {
                    Console.WriteLine("FizzBuzz"); //number is multiple of 3 and 5, prints fizzbuzz
                }
                else if (num % 3 == 0)
                {
                    Console.WriteLine("Fizz"); //number is multiple of 3, prints fizz
                }
                else if (num % 5 == 0)
                {
                    Console.WriteLine("Buzz"); //number is multiple of 5, prints buzz
                }
                else
                {
                    Console.WriteLine($"{num}"); //prints numbers from 1 to 100
                }
            }
        }
    }
}
