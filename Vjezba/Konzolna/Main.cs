using System;
using System.Buffers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konzolna
{
    internal class Main
    {
        private ObradaRacun ObradaRacun;
        
        public Main()
        {
            ObradaRacun = new ObradaRacun(this);
            
            PozdravnaPoruka();
            PrikaziIzbornik();
        }

        

        private void PozdravnaPoruka()
        {
            Console.WriteLine("*************************************");
            Console.WriteLine("*****  N  O  V  Č  A  N  I  K  ******");
            Console.WriteLine("*************************************");
        }

        private void PrikaziIzbornik()
        {
            Console.WriteLine("Glavni izbornik");
            Console.WriteLine("1. Računi");
            Console.WriteLine("2. Prihodi");
            Console.WriteLine("3. Troškovi");
            Console.WriteLine("4. Gašenje programa");
            Odaberi();
        }

        private void Odaberi()
        {
            
            switch(Pomocno.UcitajCijeliBroj("Odaberi gdje želiš ići (1-4) "))
            {
                case 1:
                    ObradaRacun.PrikaziIzbornik();
                    break;
                case 2:
                    
                    break;
                case 3:
                    break;
                case 4:
                    Console.WriteLine("Gasim program, pozdrav.");
                    return;
                default:
                    Console.WriteLine("Nisi odabrao dozvoljenu opciju");
                    Console.WriteLine("**********************");
                    break;
            }
            PrikaziIzbornik();
        }

    }
}
