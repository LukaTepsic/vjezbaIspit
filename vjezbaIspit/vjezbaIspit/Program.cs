using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vjezbaIspit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 3;
            int y = 4;
            int z = 5;

            if (x > 0 && y > 0 && z > 0)
            {
                if (x * x + y * y == z * z)
                {
                    Console.WriteLine("Vrijednosti predstavljaju stranice pravokutnog trokuta.");
                }
                else
                {
                    Console.WriteLine("Vrijednosti ne predstavljaju stranice pravokutnog trokuta.");
                }
            }
            else
            {
                Console.WriteLine("Sve stranice moraju biti veće od 0.");
            }
        }

        private string GetDebuggerDisplay()
        {
            return ToString();
        }
    
        }
    }

