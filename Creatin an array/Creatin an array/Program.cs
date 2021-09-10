using System;

namespace Creatin_an_array
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("How many numbers do you want to write");
            int n = Convert.ToInt32(Console.ReadLine());
            int [] Numbers =  new int[n];
            
            for(int i = 0; i<n; i++)
            {
                Console.WriteLine("Enter the " + i + " number");
                Numbers [i]= Convert.ToInt32(Console.ReadLine());
            }
            foreach (var number in Numbers)
            {
                Console.Write(number + "\t");
            }
        }
    }
}
