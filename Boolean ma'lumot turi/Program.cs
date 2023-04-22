 //boolean  True, False

using System;
namespace App
{
    class Apps
    {
       static void Main(string [] args)
       {
         int a = 5;
         int b = 8;
         // <, <=, >, >= operatorlari 
         Console.WriteLine(a < b); // True
         Console.WriteLine (a > b); // False
         Console.WriteLine (12 <= 12);
         Console.WriteLine (45>=50);
         Console.WriteLine("***************");
         
         int x = 15;
         int y = 13;
         Console.WriteLine(x > y); 
         // returns True, chunki 15soni 13 sonidan katta
         Console.WriteLine(15 < 13); // False
         
         Console.WriteLine("***************");

         // == tengmi , != teng emas operatorlari
         
         //  == tengmi operatori 
         int s = 976;
         Console.WriteLine($"{s}- soni tengmi 978 soniga:  {s == 978}");
         
         Console.WriteLine("***************");
         
         Console.Write("Istalgan son kiriting: ");
         int son = Convert.ToInt32(Console.ReadLine());
         Console.WriteLine($"{son}- soni tengmi 978 soniga: \t {son == 978}");
         
         Console.WriteLine("***************");
        // != teng emas operatori 
         int myAge = 25;
         int votingAge = 18;
          Console.WriteLine(myAge != votingAge);

         string name  = " ";
         do 
         {
            Console.Write("Parolni kiriting: ");
            name  = Console.ReadLine();
         } while(name != "Shohijahon");
         Console.WriteLine("Parolni to'gri kiritdingiz!");
    
    
       }
    }
}