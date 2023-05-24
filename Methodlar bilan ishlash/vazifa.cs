namespace Method.classes
{
    public class Vazifa 
    {
        public  void Kescha()
        {
            Console.Write("To'tiqushning ismini kiriting: ");
            string ism = Console.ReadLine();
            Console.Write($"{ism}ning yoshini kiriting: ");
            int yosh = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{ism} {yosh} yoshda");
        }
    }
}