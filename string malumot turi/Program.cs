// string malumot turi
using System;
namespace w {
    class h{
        static void Main(string [] args)
        {
            Console.WriteLine("Hello World");
            string name  = "Shohijahon";
            // matnlarni bir biriga qo'shish
            Console.WriteLine("Salom" + " " + name );// 1- usul
            // $- interpolition matn ichidagi o'zgaruvchini qiymatini kiritish uchun xizmat qiladi. 
            Console.WriteLine($"Salom {name}");     // 2- usul
            string ism =  "Botir";
            string familiya = "Qodirov";
            Console.WriteLine($"Uzbekiston halq artesti {ism} {familiya}");
            Console.WriteLine("Uzbekiston halq artesti "+ ism + " " + familiya);
              //ToUpper() metodi barcha harflarni katta qiladi
             Console.WriteLine("Mening ismim: " + " "+ism.ToUpper());
             Console.WriteLine($"Mening familiyam: {familiya.ToUpper()}");
             // ToLower() barcha harflarni kichik qiladi.
             Console.WriteLine("Mening ismim: " + " "+ism.ToLower());
             Console.WriteLine($"Mening familiyam: {familiya.ToLower()}");
             // ToString()- boshqa malumot turidagi qiymatni string malumot turiga o'tqizadi.
            int son = 21;
            Console.WriteLine($"Men {son.ToString()} yoshdaman!");
            short yil  = 2002;
            Console.WriteLine($"Men {yil.ToString()} yilda to'g'ilganman!");
             // Length - matni uzunligini aniqlaydi.
             string txt = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
             Console.WriteLine("Bu matning uzunligi: "+" " + txt.Length + "ta harfdan iborat");
             Console.WriteLine($"Bu matning uzunligi: { txt.Length} ta harfdan iborat");
              // index[] 
             string myString = "Hello";
             Console.WriteLine(myString[4]); // output : //o"
             string shahar = "Toshkent";
             Console.WriteLine(shahar.IndexOf("o")); // output //1
             
             
             

            
       
       
       
       
       
        }
    }   
}         
             
             