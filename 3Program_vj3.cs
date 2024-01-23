using System;

namespace ProvjeraStranicaTrokuta
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 3;
            int y = 4;
            int z = 5;

            if (x > 0 && y > 0 && z > 0)
            {
                if (x * x + y * y == z * z || x * x + z * z == y * y || y * y + z * z == x * x)
                {
                    Console.WriteLine("Stranice x, y i z čine pravokutni trokut.");
                }
                else
                {
                    Console.WriteLine("Stranice x, y i z ne čine pravokutni trokut.");
                }
            }
            else
            {
                Console.WriteLine("Vrijednosti stranica moraju biti veće od 0.");
            }
            Console.ReadKey();
        }
    }
}
