// switch , case: , default, break

using System;
namespace s
{
    class f
    {
        static void Main(string[] args)
        {
            // kuni  aniqlovchi dastur
            int day = 5;
            switch (day)
            {
                case 1:
                    Console.WriteLine("Dushanba");
                    break;
                case 2:
                    Console.WriteLine("Seshanba");
                    break;
                case 3:
                    Console.WriteLine("Chorshanba");
                    break;
                case 4:
                    Console.WriteLine("Payshanba");
                    break;
                case 5:
                    Console.WriteLine("Juma");
                    break;
                case 6:
                    Console.WriteLine("Shanba");
                    break;
                case 7:
                    Console.WriteLine("Yakshanba");
                    break;

            }

            Console.Write("Bugun nima kun: ");
            string kun = Console.ReadLine();
            switch (kun.ToLower())
            {
                case "dushanba":
                    Console.WriteLine($"{kun} kuni haftaning 1- kuni!");
                    break;
                case "seshanba":
                    Console.WriteLine($"{kun} kuni haftaning 2- kuni!");
                    break;
                case "chorshanba":
                    Console.WriteLine($"{kun} kuni haftaning 3- kuni!");
                    break;
                case "payshanba":
                    Console.WriteLine($"{kun} kuni haftaning 4- kuni!");
                    break;
                case "juma":
                    Console.WriteLine($"{kun} kuni haftaning 5- kuni!");
                    break;
                case "shanba":
                    Console.WriteLine($"{kun} kuni haftaning 6- kuni!");
                    break;
                case "yakshanba":
                    Console.WriteLine($"{kun} kuni haftaning 7- kuni!");
                    break;
                // default sharti  ixtiyoriy shart
                default:
                    Console.WriteLine("Xato qiymat kiritdingiz!");
                    break; // case dan chiqib boshqa case ga o'tish uchun qulaniladi.
            }
            // biror bir fanning imthon vaqtini aniqlovchi dastur 

            Console.Write("Salom student Ismingizni kiriting: ");
            string ism = Console.ReadLine();
            Console.WriteLine($"Salom {ism} dasturga hush kelibsiz! \n fani nomini kiriting: ");
            string imthon = Console.ReadLine();
            switch (imthon)
            {
                case "Matematika":
                    Console.WriteLine("Matematika fanidan imthon 3.06.2023 kuni soat 8:00 da bo'lib o'tadi.");
                    break;
                case "Rus tili":
                    Console.WriteLine(" Rus tili fanidan imthon 13.06.2023 kuni soat 8:00 da bo'lib o'tadi.");
                    break;
                case "Adabiyot":
                    Console.WriteLine("Adabiyot fanidan imthon 6.06.2023 kuni soat 9:30 da bo'lib o'tadi.  ");
                    break;
                case "Ona tili":
                    Console.WriteLine("Ona tili fanidan imthon 9.06.2023 kuni soat 8:00 da bo'lib o'tadi.");
                    break;
                case "Ximiya":
                    Console.WriteLine("Ximiya fanidan imthon 12.06.2023 kuni soat 11:00 da bo'lib o'tadi.");
                    break;
                case "Fizika":
                    Console.WriteLine("Fizika fanidan imthon 15.06.2023 kuni soat 13:00 da bo'lib o'tadi.");
                    break;
                default:
                    Console.WriteLine($"Sizning imthonningizda {imthon} fanni mavjud emas!");
                    break;

            }

        }



    }

}

