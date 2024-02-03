using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("V01")]
    public class Vjezba01:ControllerBase
    {
        [HttpGet]
        [Route("Zadatak")]
        public int Zad1(int a, int b)
        {
            var zbroj = a + b;
            if (zbroj % 2 == 0)
            {
                return a * b;
            }
            else
            {
                return zbroj;
            }
        }

        [HttpGet]
        [Route("Zadatak2")]
        public string Zad2(int ocjena)
        {
            switch (ocjena)
            {
                case 1: return ("NEDOVOLJAN!");
                case 2: return ("Dovoljan!");
                case 3: return ("Dobar");
                case 4: return ("Vrlo dobar");
                case 5: return ("ODLICAN");
                default: return ("Nije unešena dobra ocjena!");
            }
        }

        [HttpGet]
        [Route("Zadatak3")]
        public int Zad3(int i, int j)
        {
            if (i > j)
            {
                return i;
            }
            else
            {
                return j;
            }
        }

        [HttpGet]
        [Route("Zadatak4")]
        public int Zad4(int c, int d, int e)
        {
            if (c > d && c > e)
            {
                return c;
            }
            else if (d > e)
            {
                return d;
            }
            else
            {
                return e;
            }
        }
    }
}
