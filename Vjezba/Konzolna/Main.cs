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
        private List<Racun> Racuni;
        public Main()
        {
            Racuni = new List<Racun>();
            TestPodaci();
            PozdravnaPoruka();
            PrikaziIzbornik();
        }

        private void TestPodaci()
        {
            Racuni.Add(new() { KorisnickoIme = "josip031", Ime = "Josip", Prezime = "Rebolj", BrOsobne = 1234567, Stanje = 135.39 });
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
                    PrikaziRacune(true);
                    break;
                case 2:
                    PrikaziPrihode();
                    UnosRacuna();//PRVO POKAZAT GLAVNI IZBORNIK, ONDA UNOS
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

        private void PrikaziPrihode()
        {
            //prihodi za svaki racun zadnjih par transakcija
        }

        private void UnosRacuna()
        {
            Racuni.Add(new()
            {
                KorisnickoIme = Pomocno.UcitajString("Unesi korisnicko ime: "),
                Ime=Pomocno.UcitajString("Unesi ime vlasnika racuna: "),
                Prezime=Pomocno.UcitajString("Unesi prezime vlasnika racuna: "),
                BrOsobne=Pomocno.UcitajCijeliBroj("Unesi broj osobne vlasnika racuna: "),
                Stanje=Pomocno.UcitajDecimalniBroj("Unesi stanje racuna: ")
            });
                
            

        }
        

        private void PrikaziRacune(bool PrikaziNaslov=false)
        {
            if (PrikaziNaslov)
            {
                Console.WriteLine("**********************");
                Console.WriteLine("** Računi u sustavu** ");
                Console.WriteLine("**********************");
            }
            if (Racuni.Count == 0)
            {
                Console.WriteLine("Nema računa u sustavu");
                return;
            }
            int i = 1;
            foreach(var o in Racuni)
            {
                Console.WriteLine(i++ +". "+o);
            }
            Console.WriteLine("**********************");
            Console.WriteLine("1. Povratak na izbornik");
            Console.WriteLine("2. Unos novog racuna");
            Console.WriteLine("3. Zatvori program");
            switch (Pomocno.UcitajCijeliBroj("Odaberi gdje želiš ići (1-3) "))
            {
                case 1:
                    PrikaziIzbornik();
                    break;
                case 2:
                    UnosRacuna();
                    break;
                case 3:
                    Console.WriteLine("Povratak na glavni izbornik");
                    return;
                default:
                    Console.WriteLine("Nisi odabrao dozvoljenu opciju");
                    Console.WriteLine("**********************");
                    break;
            }
        }
    }
}
