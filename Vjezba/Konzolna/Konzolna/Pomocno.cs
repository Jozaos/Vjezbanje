using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konzolna.Konzolna
{
    internal class Pomocno
    {
        public static bool dev;
        public static int ucitajBroj(string poruka, string greska, int poc, int kraj)
        {
            int i;
            while (true)
            {
                Console.Write(poruka);
                try
                {
                    i = int.Parse(Console.ReadLine());
                    if(i>=poc && i<= kraj)
                    {
                        return i;
                    }
                    Console.WriteLine(greska);
                }catch(Exception ex)
                {
                    Console.WriteLine(greska);
                }
            }
        }
    }
}
