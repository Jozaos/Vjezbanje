using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VjezbaCs
{
    internal class CiklicnaMatrica
    {
        public static void Izvedi()
        {
            Console.WriteLine("Unesi prvi broj matrice: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Unesi drugi broj matrice: ");
            int b = int.Parse(Console.ReadLine());

            int[,] polje = new int[a, b];
            int x = a * b;
            for(int i = 0; i < a; i++)
            {
                for(int j = 0; j < b; j++)
                {
                    polje[i, j] = x;
                    x--;
                }
            }
            for(int i = 0;i < a; i++)
            {
                for (int j = 0;j < b; j++)
                {
                    Console.Write(polje[i,j]+"\t");
                }
                Console.WriteLine();
            }
        }
    }
}
