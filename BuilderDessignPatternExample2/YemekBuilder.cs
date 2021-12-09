using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDessignPatternExample2
{
    abstract class YemekBuilder
    {
        protected Yemek yemek;

        public Yemek Yemek
        {
            get { return yemek; }
        }
        abstract public void SetYemekTipi();
        abstract public void SetYemekAdi();
        abstract public void SetProtein();
    }
}
