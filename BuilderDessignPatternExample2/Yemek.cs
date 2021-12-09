using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDessignPatternExample2
{
    class Yemek
    {
        public YemekTipi YemekTipi { get; set; }
        public string YemekAdi { get; set; }
        public double Protein { get; set; }
        public override string ToString()
        {
            Console.WriteLine($"{YemekTipi} -> Protein Oranı : {Protein}");
            return base.ToString();
        }
    }


    enum YemekTipi
    {
        Sulu,
        Etli,
        Sebzeli
    }
}
