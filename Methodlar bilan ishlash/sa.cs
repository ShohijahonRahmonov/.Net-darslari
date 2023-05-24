namespace Method.classes
{
    class Ashabod
    {

        public void Hisobla()
        {
            for (int s = 1; s <= 10; s++)
            {
                for (int t = 1; t <= 10; t++)
                {
                    Console.WriteLine($"{s} x {t} = {s * t}");

                }
                Console.WriteLine("\n");
            }
            Console.WriteLine("***********************");

        }
        public void Shahar()
        {
            Console.WriteLine("Bugungi kuning indexisini yozing: ");
            int kun = Convert.ToInt32(Console.ReadLine());
            switch (kun)
            {
                case 1:
                    Console.WriteLine("Bugun Dushanba kuni");
                    break;
                case 2:
                    Console.WriteLine("Bugun Seshanba kuni ");
                    break;
                case 3:
                    Console.WriteLine("Bugun Chorshanba  kuni");
                    break;

                case 4:
                    Console.WriteLine("Bugun Payshanba kuni");
                    break;
                case 5:
                    Console.WriteLine("Bugun Juma  kuni");
                    break;
                case 6:
                    Console.WriteLine("Bugun Shanba   kuni");
                    break;
                case 7:
                    Console.WriteLine("Bugun Yakshanba kuni");
                    break;

            }



        }
    }
}
