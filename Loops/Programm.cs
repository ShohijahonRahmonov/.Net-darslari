// Loops: while, do while, for, foreach;

using System;
namespace ConsoleApp
{
    class App
    {
        static void Main(string[] args)
        {
            int son = 0;
            while (son <= 10)
            {
                Console.WriteLine(son);
                son++;
            }

            Console.Write("Istalgan son kiriting:");
            int son1 = Convert.ToInt32(Console.ReadLine());
            while (son1 <= 50)
            {
                if (son1 <= 50)
                {
                    Console.WriteLine(son1);
                    son1++;

                }
                else
                {
                    Console.WriteLine("Xato qiymat kiritingiz!");
                }
            }
            Console.Write("Istalgan son kirting:");
            int s = Convert.ToInt32(Console.ReadLine());
            while (s <= 20)
            {
                if (s > 20)
                {
                    Console.WriteLine("Son 20 sonidan katta");
                }
                else
                {
                    Console.WriteLine(s);
                    s++;
                }
            }

            //do while loop 
            int parol;
            do
            {
                Console.Write("Parolni kiriting: ");
                parol = Convert.ToInt32(Console.ReadLine());


            } while (parol != 2002);
            Console.WriteLine("Parolni to'g'ri kiritingiz!");
            string n = "";
            do
            {
                Console.Write("Userni  ismini kiriting: ");
                n = Console.ReadLine();
            } while (n != "Shohijahon");
            Console.WriteLine("User nomini to'g'ri kiritdingiz");
            // for loop

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{i} Salom Dunyo!");

            }


            for (int e = 0; e <= 60; e = e + 2)
            //i = i + 2) - qiymatni ikki marotiba oshiraveradi. 

            {
                Console.WriteLine(e);

            }
            Console.WriteLine("break ***********");
            for (int i = 0; i < 10; i++)
            {
                if (i == 4)
                {

                    break; // kodni toxtatadi 

                }
                Console.WriteLine(i);

            }
            Console.WriteLine("Continue ***********");
            for (int i = 0; i < 10; i++)
            {
                if (i == 4)
                {

                    continue; //bitta son tashlab o'tib ketadi.
                    ;
                }
                Console.WriteLine(i);
            }


            //forach loop 

            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            foreach (string car in cars)
            {
                Console.WriteLine(car);
            }
            Console.WriteLine("*****************");

            string[] names = { "Shahboz", "Nodir", "Javohir", "Abbos", "Vali", "Botir", "Qodir" };
            foreach (string name in names)
            {
                Console.WriteLine($"Salom {name} ertaga to'g'ilgan kunimga taklif etaman");
                Console.WriteLine("Hurmat bilan Shohijahon!");
            }
        int [] numbers = {5, 43, 56, 897, 95, 90, 12};
        foreach(int number in numbers)
        {
        Console.WriteLine(number);
        }
        


        }
    }
}




