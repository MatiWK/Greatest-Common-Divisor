using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NWD
{
    class Program
    {
        static void Main(string[] args)
        {
            int m, n, roznica;
            int c = 1;
            Console.Write("Podaj wartość zmiennej n: ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Podaj wartość zmiennej m: ");
            m = Convert.ToInt32(Console.ReadLine());


            do
            {
                roznica = GetAbsRoznica(n, m);
                PrzypiszRoznicaDoWiekszejWartosci(ref n, ref m, roznica);
            }
            while (roznica != 0);


            Console.WriteLine("Największy wspólny dzielnik podanych liczb to " + n);

            Console.ReadLine();
        }

        private static int GetAbsRoznica(int n, int m)
        {
            return Math.Abs(n - m);
        }

        private static void PrzypiszRoznicaDoWiekszejWartosci(ref int n, ref int m, int roznica)
        {
            if (m >= n)
            {
                m = roznica;
                return;
            }
            n = roznica;
        }

    }
}
