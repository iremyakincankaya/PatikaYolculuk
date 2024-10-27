using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Sources;

namespace IMDBList
{
    public class Filmler
    {
        public string Ad { get; set; }
        public double IMDB { get; set; }

        public Filmler(string ad, double imdb)
        {
            Ad = ad;
            IMDB = imdb;
        }

        public override string ToString()
        {
            return $"Filmin adı: {Ad} IMDB: {IMDB}";
        }

    }

    
}
