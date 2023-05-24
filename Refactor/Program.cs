using System;
namespace Calculate 
{
    class Calculator
    {
        static void Main (string [] args)
        {
            Console.Write("Enter you name: ");
            string name = Console.ReadLine();
            Console.Write("Enter you surname: ");
            string surname = Console.ReadLine();
            Console.Write("How old are you: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Where are you from: ");
            string town =  Console.ReadLine ();
           
            Console.WriteLine ($"{name} {surname} {age} yoshda\n{name} {town} shahrida yashaydi.");

        }
    }
}