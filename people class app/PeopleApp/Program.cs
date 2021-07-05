using System;
using Packt.Shared;
using static System.Console;

namespace PeopleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var bob = new Person();
            // WriteLine(bob.ToString());
            bob.Name = "Bob";
            bob.DateOfBirth = new DateTime(1999, 8, 2);
            bob.BucketList = (WondersOfTheAncientWorld)21;

            // WriteLine($"{bob.Name}'s bucket list is {bob.BucketList}");
            // bob.Children.Add(new Person { Name = "jack" });
            // bob.Children.Add(new Person { Name = "Eva" });

            // WriteLine(format: "{0} has {1} children",
            //             arg0: bob.Name,
            //             arg1: bob.Children.Count);

            // foreach (Person child in bob.Children)
            // {
            //     WriteLine(child.Name);
            // }

            // BankAccount.InterestRate = 0.012M;

            // var bobAccount = new BankAccount();
            // bobAccount.AccountName = "savings";
            // bobAccount.Balance = 1000;

            // WriteLine(format: "{0} earned {1:C} interest.",
            //             arg0: bobAccount.AccountName,
            //             arg1: bobAccount.Balance * BankAccount.InterestRate);
            // bob.SayHello();

            // int a = 10;
            // int b = 20;
            // int c = 30;
            // WriteLine($"Before: a = {a}, b = {b}, c = {c}");
            // bob.PassingParameters(a, ref b, out c);
            // WriteLine($"After: a = {a}, b = {b}, c = {c}");

            var sam = new Person
            {
                Name = "Sam",
                DateOfBirth = new DateTime(1972, 1, 27)
            };
            WriteLine(sam.Origin);
            WriteLine(sam.Greeting);
            WriteLine(sam.Age);

        }
    }
}
