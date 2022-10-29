using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;

namespace Supp_Q2
{
    class Program
    {
        class List
        {
            // Created a list to store our numbers
            List<int> numbers;
            public List()
            {
                // Added a few values to the list so we can test it out
                numbers = new List<int>();
                numbers.Add(25);
                numbers.Add(3);
                numbers.Add(5);
                numbers.Add(17);
                numbers.Add(12);
                numbers.Add(2);
            }
            //1) List with the odd numbers
            public List<int> Copy()
            {
                // New list that will store all odd numbers
                List<int> odds = new List<int>();
                foreach(int number in numbers)
                {
                    if (!(number % 2).Equals(0)) // If the remainder is not 0 then the number is odd
                    {
                        odds.Add(number);
                    }
                }
                return odds;
            }
            // 2) How times X occurs in the list
            public int Count(int x)
            {
                int count = 0;
                if (numbers.Contains(x)) // Check if your list has the value
                {
                    foreach(int number in numbers)
                    {
                        if (number.Equals(x))
                        {
                            count++;
                        }
                    }
                    
                }
                else // Incase the value does not exist
                {
                    throw new Exception("Value is not in the list");
                }
                return count;
                
            }
            //3) Average of the numbers <= to a given value
            public double Average(int value)
            {
                double sum = 0;
                int count = 0;
                foreach (int number in numbers)
                {
                    if (number <= value)
                    {
                        sum += number;
                        count++;
                    }
                }
                return sum / count;
            }
        }
        static void Main(string[] args)
        {
            List l = new List();
            Console.WriteLine(String.Join(" ",l.Copy())); // Print out the list with odds
            try
            {
                Console.WriteLine(l.Count(2));
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine(l.Average(12));
        }
    }
}