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
            Console.Write("Unesi redove matrice: ");
            int red = int.Parse(Console.ReadLine());
            Console.Write("Unesi stupce matrice: ");
            int stupac = int.Parse(Console.ReadLine());
            int a = 1;
            int PocetakRed = 0;
            int KrajRed = red - 1;
            int PocetakStupac = 0;
            int KrajStupac = stupac - 1;
            int[,] matrica = new int[red, stupac];
            int ukupno = red* stupac;


            while (a <= ukupno)
            {
                for (int i = KrajStupac; i >= PocetakStupac; i--)
                {

                    matrica[KrajRed, i] = a++;
                }

                if (a > ukupno) { break; }

                KrajRed--;

                for (int i = KrajRed; i >= PocetakRed; i--)
                {
                    matrica[i, PocetakStupac] = a++;
                }
                if (a > ukupno) { break; }
                PocetakStupac++;

                for (int i = PocetakStupac; i <= KrajStupac; i++)
                {
                    matrica[PocetakRed, i] = a++;
                }
                if (a > ukupno) { break; }
                PocetakRed++;

                for (int i = PocetakRed; i <= KrajRed; i++)
                {
                    matrica[i, KrajStupac] = a++;
                }
                if (a > ukupno) { break; }
                KrajStupac--;

            }

            for (int i = 0; i < red; i++)
            {
                for (int j = 0; j < stupac; j++)
                {
                    Console.Write("{0,4}", matrica[i, j]);
                }
                Console.WriteLine();
            }

        }
    }
}