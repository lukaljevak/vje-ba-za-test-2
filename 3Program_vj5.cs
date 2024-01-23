using System;

namespace PDV
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite cijenu bez PDV-a: ");
            double cijenaBezPDVa = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Unesite stopu PDV-a (%): ");
            double stopaPDVa = Convert.ToDouble(Console.ReadLine());

            double iznosPDVa = cijenaBezPDVa * (stopaPDVa / 100);
            double cijenaSaPDVom = cijenaBezPDVa + iznosPDVa;

            Console.WriteLine("Iznos PDV-a: " + iznosPDVa);
            Console.WriteLine("Cijena sa PDV-om: " + cijenaSaPDVom);
            Console.ReadKey();
        }
    }
}
