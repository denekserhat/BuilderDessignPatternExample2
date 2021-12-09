using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDessignPatternExample2
{
    class YemekYapici
    {
        public void YemekYap(YemekBuilder builder)
        {
            builder.SetProtein();
            builder.SetYemekAdi();
            builder.SetYemekTipi();
        }
    }
}
