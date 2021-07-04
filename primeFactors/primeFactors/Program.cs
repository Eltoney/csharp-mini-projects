using System;

namespace primeFactors
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello User!");
            System.Console.WriteLine("Enter your number: ");
            int num;
            try{
                num = Int32.Parse(Console.ReadLine());
            }catch{
                System.Console.WriteLine("You enterd invalid number");
            }
        }
    }
}
