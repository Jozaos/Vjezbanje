using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konzolna
{
    internal class Racun
    {
        public string? KorisnickoIme { get; set; }
        public string? Ime { get; set; }
        public string? Prezime { get; set; }
        public int? BrOsobne { get; set; }
        public double? Stanje { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new();
            sb.Append(KorisnickoIme);
            sb.Append(' ');
            sb.Append(Ime);
            sb.Append(' ');
            sb.Append(Prezime);
            sb.Append(" (");
            sb.Append(BrOsobne);
            sb.Append(") (");
            sb.Append(Stanje);
            
            return sb.Append("eur)").ToString();
        }
    }
}
