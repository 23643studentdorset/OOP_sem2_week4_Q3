using System;
using System.Collections.Generic;

namespace OOP_sem2_week4_Q3
{
    class Program
    {
        /*
        Create a method named Sum() that accepts any number of integer parameters and displays their sum.Write a Main() method 
        that demonstrates the Sum() method works correctly when passed one, three, or five integers, or an array of ten integers
        */
        
        public static void sum(List<int> numbers)
        {
            int result = 0;
            foreach ( int element in numbers)
            {
                result += element; 
            }
            Console.WriteLine(result);
        }
        
        static void Main(string[] args)
        {
          
            List<int> inputs = new List<int>();
            
            bool flag = false;
            int number = 0;
            
            do
            {
                

                do
                {
                    Console.WriteLine("input an integer or `-1` to finish" );
                    flag = !int.TryParse(Console.ReadLine(), out number);
                    if (number == -1)
                    {
                        break;
                    }
                    if (flag)
                    {
                        Console.WriteLine("The value is not an integer");
                    }
                } while (flag);

                inputs.Add(number);
            
            } while (number != -1);

            inputs.RemoveAt(inputs.Count-1);
            Program.sum(inputs);

        }
    }
}
