using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VjezbaCs
{
    internal class LjubavniKalk
    {
        public static void Izvedi()
        {
            string PrvoIme, DrugoIme, ukupno;
            PrvoIme=UnosImena("Unesi prvo ime").ToLower();
            DrugoIme = UnosImena("Unesi drugo ime").ToLower();
            ukupno = PrvoIme + DrugoIme;
            int[] brojevi = new int[2];
            char[] PoljeZnakovi=ukupno.ToCharArray();
            int[] PoljeBrojevi = new int[PoljeZnakovi.Length];
            int pocetak = 0;
            int zbroj = 0;

            foreach(char c in PoljeZnakovi)
            {
                foreach(char d in PoljeZnakovi)
                {
                    if (c == d)
                    {
                        zbroj++;
                    }
                }
                PoljeBrojevi[pocetak++] = zbroj;
            }
            //Console.WriteLine(zbroj);
        }

        


        private static string UnosImena(string poruka)
        {
            string a;
            for(; ; )
            {
                Console.Write(poruka+": ");
                a = Console.ReadLine().Trim();
                if (a.Length == 0)
                {
                    Console.WriteLine("Obavezan unos");
                    continue;
                }
                try
                {
                    int.Parse(a);
                    Console.WriteLine("Unos ne smije biti cijeli broj");
                    continue;
                }catch(Exception){}
                try
                {
                    float.Parse(a);
                    Console.WriteLine("Unos ne smije biti decimalni broj");
                    continue;
                }catch(Exception){}
                return a;
            }
        }
    }
}
