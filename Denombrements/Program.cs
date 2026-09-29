using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Denombrements
{
    class Program
    {
        //FONCTION UNIQUE 6 plus de duplication!
        static long Factorielle(int n)
        {
            long r = 1;
            for (int k = 1; k <= n; k++) r *= k;
            return r;
        }
        static void Main(string[] args)
        {
            int c = 1;
            while (c != 0)
            {
                Console.WriteLine("Permutation ...................... 1");
                Console.WriteLine("Arrangement ...................... 2");
                Console.WriteLine("Combinaison ...................... 3");
                Console.WriteLine("Quitter .......................... 0");
                Console.Write("Choix :                                 ");
                c = int.Parse(Console.ReadLine());

                if (c == 0) { Environment.Exit(0); }

                if (c == 1)
                {
                    Console.Write("nombre total d'éléments à gérer = ");
                    int n = int.Parse(Console.ReadLine());
                    long r = Factorielle(n);
                    Console.WriteLine(n + "! = " + r);
                }
                else
                {
                    if (c == 2)
                    {
                        Console.Write("nombre total d'éléments à gérer = ");
                        int n = int.Parse(Console.ReadLine());
                        Console.Write("nombre total d'éléments à prendre");
                        int p = int.Parse(Console.ReadLine());
                        long r = Factorielle(n) / Factorielle(n - p);
                        Console.WriteLine($"A{n},{p} = {r}");
                    }
                    else if (c == 3)
                    {
                        {
                            Console.Write("nombre total d'éléments à gérer = ");
                            int n = int.Parse(Console.ReadLine());
                            Console.Write("nombre d'éléments à prendre");
                            int p = int.Parse(Console.ReadLine());
                            long r = Factorielle(n) / (Factorielle(p) * Factorielle(n - p));
                            Console.WriteLine($"{n}, {p} = {r}");
                        }
                    }
                }

            }
        }
    }
}