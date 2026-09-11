using System;
namespace övning2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur mycket kännar den första personen i kr");
            double första = double.Parse(Console.ReadLine());
            Console.WriteLine("Hur mycket kännar andra personen i kr");
            double andra = double.Parse(Console.ReadLine());
            Console.WriteLine("Hur mycket kännar tredje personen i kr");
            double tredje = double.Parse(Console.ReadLine());
            double medelön = (tredje + andra + första) / 3;
            Console.WriteLine("Medelönen av alla tre personer är " + medelön + " kr");
        }
    }
}