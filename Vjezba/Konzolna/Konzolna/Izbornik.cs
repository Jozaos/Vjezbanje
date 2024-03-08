using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konzolna.Konzolna
{
    internal class Izbornik
    {
        public ObradaRacun ObradaRacun { get; }
        public ObradaTrosak ObradaTrosak { get; }


        public Izbornik()
        {
            Pomocno.dev = true;
            ObradaRacun=new ObradaRacun();
            ObradaTrosak=new ObradaTrosak();
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

            switch(Pomocno.ucitajBroj("Odaberite broj za kretanje izbornikom (1-4): "))
            {
                
                    
                    
            }


        }

        


    }
}
