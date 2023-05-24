namespace Method.classes
{
    class Assalom
    {
        
        public void MyMethod()
        {
            Console.WriteLine("Hello world! ");
            Console.WriteLine ("Salom Dunyo!!!!!!");
            Console.WriteLine ("Hayr olam ");
            
        }
       
        public void Kvadrat ()
            {

            Console.Write("Istalgan son kiriting: ");
            int son =  Convert.ToInt32 (Console.ReadLine());
            Console.WriteLine ($"Siz kiritgan {son} sonining kvadrati {son*son} soniga teng!");
            }
            
            public void yoshniAniqla()
            {
                Console.Write("yoshingizni kiriting: ");
                int yosh = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Siz {2023-yosh} yilda  to'g'ilgan ekansiz " );
           

            }

            public void ifSharti()
            {
                int yosh  = 1;
                if (yosh > 18)
                {
                    Console.WriteLine ("Siz 18 yoshdan katta ekansiz!");
                }
                else if (yosh == 18)
                {
                    Console.WriteLine ("Siz 18 yosh ekansiz!");
                }
                else 
                {
                    Console.WriteLine ("Siz 18 yoshdan kichik ekansiz!");
                }
             }    
            public void Askar()
        {
            Console.Write ("Ismingiz nima: ");
            string ism = Console.ReadLine();
            Console.Write($"{ism}! yoshingiz nechida: ");
            short yosh = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine ($"{ism} {yosh} yoshda");
            Console.Write("Qaysi shahardan siz!");
            string shahar =  Console.ReadLine();
            Console.WriteLine ($"{ism} {yosh} yoshda, {shahar} shahridan.");
        }
           
       
    }
}