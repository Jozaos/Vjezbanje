using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konzolna.Konzolna.Model
{
    internal class Prihod:Racun
    {
        public bool VrstaPrihoda { get; set; }
        public int Korisnik { get; set; }
    }
}
