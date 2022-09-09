using System;
namespace Uppgift_2._11
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("Hur högt kan alma hoppa svara i meter ");
                string almaText= Console.ReadLine();
                double alma= double.Parse(almaText);
                double skillnad = 1 + alma;
                Console.WriteLine("  elin hoppade  " + skillnad + "  meter högre");
            }
    }
}
}
