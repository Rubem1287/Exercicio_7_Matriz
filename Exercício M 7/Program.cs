using System;

namespace Exercício_M_7
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] soldados;
            string[,] vetgirar;

            int m = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            soldados = new string[m, n];
            vetgirar = new string[m,n];

            for(int l = 0; l<m;l++)
            {
                string[] matriz = Console.ReadLine().Split(' ');
                for (int c =0;c<n;c++ )
                {
                    
                    soldados[l, c] = matriz[c];
                    vetgirar[l, c] = matriz[c];
                    
                }
            }

            int girar = int.Parse(Console.ReadLine());

            while(girar>m||girar<0)
            {
                girar = int.Parse(Console.ReadLine());
            }

            girar = girar - 1;

            string ultimo = soldados[girar, n - 1];

            for (int j = n - 1; j > 0; j--)
            {
                soldados[girar, j] = soldados[girar, j - 1];
            }

            soldados[girar, 0] = ultimo;

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(soldados[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
