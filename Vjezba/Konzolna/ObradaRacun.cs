using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Konzolna.Model;

namespace Konzolna
{
    internal class ObradaRacun
    {
        private List<Racun> Racuni { get; }
        private Main Main;
        public ObradaRacun(Main main) : this()
        {
            this.Main = main;
            if (Pomocno.dev)
            {
                TestniPodaci();
            }
        }

        

        public ObradaRacun()
        {
            Racuni = new List<Racun>();
        }

        private void TestniPodaci()
        {
            Racuni.Add(new Racun()
            {
                KorisnickoIme = "Joza",
                Ime = "Josip",
                Prezime = "Rebolj",
                BrOsobne = 125632,
                Stanje = 482.93m

            });
        }

        public void PrikaziIzbornik()
        {
            Console.WriteLine("Izbornik za upravljanje računima");
            Console.WriteLine("1. Pregled postojećih računa");
            Console.WriteLine("2. Unos novog računa");
            Console.WriteLine("3. Promjena postojećeg računa");
            Console.WriteLine("4. Brisanje računa");
            Console.WriteLine("5. Povratak na glavni izbornik");
            switch(Pomocno.ucitajBrojRaspon("Odaberi gdje želiš ići: ","Moraš odabrati 1-5", 1, 5))
            {
                case 1:
                    PrikaziRacune();
                    PrikaziIzbornik();
                    break;
                case 2:
                    UnosRacuna();
                    PrikaziIzbornik();
                    break;
                case 3:
                    PromjenaRacuna();
                    PrikaziIzbornik();
                    break;
                case 4:
                    BrisanjeRacuna();
                    PrikaziIzbornik();
                    break;
                case 5:
                    Console.WriteLine("Gotov rad sa racunima");
                    break;

            }
        }

        private void BrisanjeRacuna()
        {
            PrikaziRacune();
            int index = Pomocno.ucitajBrojRaspon("Odaberi redni broj racuna: ", "Nije dobar odabir", 1, Racuni.Count());
            Racuni.RemoveAt(index - 1);
        }

        private void PromjenaRacuna()
        {
            PrikaziRacune();
            int index = Pomocno.ucitajBrojRaspon("Odaberi redni broj racuna: ", "Nije dobar odabir", 1, Racuni.Count());
            var p = Racuni[index - 1];
            p.Sifra = Pomocno.ucitajCijeliBroj("Unesite sifru racuna(" + p.Sifra + "): ", "Unos mora biti pozitivni cijeli broj");
            p.KorisnickoIme = Pomocno.UcitajString("Unesite korisnicko ime (" + p.KorisnickoIme + ")");
            p.Ime = Pomocno.UcitajString("Unesi ime (" + p.Ime + ")");
            p.Prezime = Pomocno.UcitajString("Unesi prezime (" + p.Prezime + ")");
            p.BrOsobne = Pomocno.UcitajCijeliBroj("Unesi broj osobne (" + p.BrOsobne + ")");
            p.Stanje = Pomocno.UcitajDecimalniBroj("Unesi stanje racuna (" + p.Stanje + ")");

            Console.WriteLine("#####################");
            Console.WriteLine("#### R A C U N I ####");
            Console.WriteLine("#####################");
            int b = 1;
            foreach(Racun racun in Racuni)
            {
                Console.WriteLine("{0}. {1}",b++,racun);
            }
            Console.WriteLine("#####################");


        }

        private void PrikaziRacune()
        {
            Console.WriteLine("#####################");
            Console.WriteLine("#### R A C U N I ####");
            Console.WriteLine("#####################");
            int b = 1;
            foreach(Racun racun in Racuni)
            {
                Console.WriteLine("{0}. {1} ({2}) ({3}) ({4}) ({5})",b++,racun.KorisnickoIme, racun.Ime, racun.Prezime, racun.BrOsobne ,racun.Stanje+"eur");
            }
        }

        private void UnosRacuna()
        {
            Racuni.Add(new()
            {
                KorisnickoIme = Pomocno.UcitajString("Unesi korisnicko ime "),
                Ime = Pomocno.UcitajString("Unesi ime vlasnika racuna "),
                Prezime = Pomocno.UcitajString("Unesi prezime vlasnika racuna "),
                BrOsobne = Pomocno.UcitajCijeliBroj("Unesi broj osobne vlasnika racuna "),
                Stanje = Pomocno.UcitajDecimalniBroj("Unesi stanje racuna ")
            });
        }

    }
}
