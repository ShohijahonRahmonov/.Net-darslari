// if, else, else if
using System;
namespace world
{
    class h
    {
        static void Main(string[] args)
        {
            int son = 21;
            // if sharti true bo'lsa, else shartini tekshirib o'tirmaydi.
            // if sharti  false bo'lsa else shartiga o'tib ketadi.

            if (son >= 0)
            {
                Console.WriteLine("Musbat son");
            }
            else
            {
                Console.WriteLine("Manfiy son");

            }
            Console.Write("Ismingizni kiriting: ");
            string name = Console.ReadLine();
            if (name == "Shohijahon")
            {
                Console.WriteLine("Salom Shohijahon dasturimizga hush kelibsiz");
            }
            else
            {
                Console.WriteLine($"Kechirasiz {name}, bizga  Shohijahon kerak");
            }
            Console.Write("Ismingizni kiriting: ");
            string ism = Console.ReadLine();
            Console.Write($"{ism} yoshingizni kiriting:");
            int yosh = Convert.ToInt32(Console.ReadLine());
            if (yosh < 18)
            {
                Console.WriteLine("Siz \"Coved 19\" vaksinasini  olishga hali yoshsiz!");
            }
            else if (yosh >= 50)
            // else ifni bir pragrammada bir qancha ishlatish mumkin.
            {
                Console.WriteLine("Siz \"Coved 19\" vaksinasini olishga keksalik qilasiz!");
            }
            else
            {
                Console.WriteLine("Siz vaksina olish yoshidasiz, Vaksina olishga tayormisiz, qani boshladik!");
            }
            Console.Write("bugun nima kun: ");
            string kun = Console.ReadLine();
            
            // || - yoki belgisi
            
            if (kun.ToLower() == "yakshanbe" || kun.ToLower() == "shanbe")
            {
                Console.WriteLine("Bugun dam olish kuni");
            }
            else
            {
              Console.WriteLine("Bugun ish kuni ");
            }
            Console.Write("Havo harorati qanday: ");
            int harorat = Convert.ToInt32(Console.ReadLine());
            // && va belgisi 
            if (kun == "yakshanbe" || kun == "shanbe" && harorat >= 36 )
            {
                Console.WriteLine("Bugun dam olish kuni chumilgani ketdik!");
                
            }
            else if (kun == "yakshanbe" || kun == "shanbe" && harorat < 36 )
            {
                Console.WriteLine ("Bugun dam olish kuni lekin havo harorati past tufayli uyda dam olamiz!");
            }
            else if (kun != "yakshanbe" || kun != "shanbe" && harorat > 36)
            {
                Console.WriteLine ("Bugun ish kuni, lekin havo harorati yuqori tufayli chumilgani ketdik!");
            }
            else if (kun != "yakshanbe" || kun != "shanbe" && harorat < 36)
            {
                Console.WriteLine("Bugun ish kuni "); 
               // bazan else shartini yozsak boladi, ba'zida yo'q, else sharti ixtiyoriy.
            }
            // qisqa if -? va qisqa else : belgisi 
            Console.Write("Butun son kiriting: ");
            int a = Convert.ToInt32(Console.ReadLine());
            string b = (a > 50) ?  $"{a} soni 50 sonidan katta" : $"{a} soni 50 sonidan kichik"; 
            Console.WriteLine(b);
            
            Console.Write("Ismingizni kiriting: ");
            string s  = Console.ReadLine();
            s = (name == "Abbos") ?  $"Salom {s} " : $"Kechirasiz{s}, menga Abbos kerak";
            Console.WriteLine(s);



        }
    }
}