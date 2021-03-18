using System;

namespace Extension_Method
{
    class Program
    {
        static void Main(string[] args)
        {

            DateTime dt = new DateTime(2021, 03, 18, 8, 10, 45);

            Console.WriteLine(dt.ElapsedTime());

            string s1 = "Good morning dear students!";

            Console.WriteLine(s1.Cut(12));

            

            Console.ReadKey();
        }
    }
}
