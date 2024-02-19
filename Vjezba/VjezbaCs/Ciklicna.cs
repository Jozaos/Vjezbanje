using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VjezbaCs
{
    internal class Ciklicna
    {
        public static void Izvedi()
        {
            Console.Write("Unesi prvi broj matrice: ");
            int red= int.Parse(Console.ReadLine());
            Console.Write("Unesi drugi broj matrice: ");
            int stupac= int.Parse(Console.ReadLine());
            int a = 1;
            int PocetakRed = 0;
            int KrajRed = red - 1;
            int PocetakStupac = 0;
            int KrajStupac = stupac - 1;
            int[,] matrica = new int[red,stupac];

            while (a <= red * stupac)
            {
                for(int i=KrajStupac;i>=PocetakStupac;i--)
                    matrica[KrajRed,i] = a++;
                KrajRed--;
                for(int i=KrajRed;i>=PocetakRed;i--)
                    matrica[i, PocetakStupac] = a++;
                PocetakStupac++;

                for (int i = PocetakStupac; i<= KrajStupac; i++)
                    matrica[PocetakRed, i] = a++;
                PocetakRed++;
                
                
                for(int i=PocetakRed;i <= KrajRed; i++)
                    matrica[i,KrajStupac] = a++;
                KrajStupac--;

            }

            for(int i=0; i<red; i++)
            {
                for(int j=0; j<stupac; j++)
                {
                    Console.Write(matrica[i,j]+"\t");
                }
                Console.WriteLine();
            }

        }
    }
}
