//Arrays - Massivlar bilan ishlash
using System;
namespace ConsoleApp
{
    class Programm
    {
        static void Main(string[] args)
        {
            //Massivlarni ishlatish uchun o'zgaruvchilardan kiyin kvadrat qavslar "[]" ishlatiladi.
            string[] cars = { "Opel", "Spark", "Gentra", "Tayota", "Ferari" };
            Console.WriteLine(cars[0]); //Output // Opel
            int[] narhlar = { 65000, 320000, 540000, 12000, 65476 };

            Console.WriteLine(cars[1]);
            Console.WriteLine("Salonimizdagi moshinalar ro'yhati bilan tanishing:");
            foreach (string car in cars)
            {
                Console.WriteLine(car);
            }
            // Lengh  massivni  ichidagi qiymatlar sonni chiqaradi
            Console.WriteLine($"Cars massivi ichida {cars.Length} ta element bor");
            Console.WriteLine($"Narhlar massivi ichida {narhlar.Length} ta son bor");
            string[] mevalar;
            mevalar = new string[] { "Olma", "Uzum", "Shaftoli", "Anor" };
            Console.WriteLine(mevalar[1]);

            // massivlarni qiymatini o'zgartirish mumkin
            string[] mevalars = { "Olma ", "Anor", "Uzum", "Bodom", "Shaftoli" };
            Console.WriteLine(mevalars[2]);
            mevalars[2] = "Qovun";
            Console.WriteLine(mevalars[2]); // index[2] qovunga o'zgardi
            cars[1] = "Mersades Bens";
            cars[3] = "BMW";
            Console.WriteLine(cars[1]);
            Console.WriteLine(cars[3]);
            Console.WriteLine("*************");
            foreach (string c in cars)
            {
                Console.WriteLine(c);
            }

            // Array.Sort()- elementlarni alifbo kitma kitligida taxlaydi.
            Console.WriteLine("Alifbo ketma ketligida taxla");

            Array.Sort(cars);
            foreach (string i in cars)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Sonlarni tartibla");
            Array.Sort(narhlar);
            foreach (int s in narhlar)
            {
                Console.WriteLine(s);

            }
            for (int son = 0; son <= cars.Length; son++)
            {
                Console.WriteLine($"Menga {cars[son]} bor!");
            }
            







        }

    }
}








