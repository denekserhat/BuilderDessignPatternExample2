using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDessignPatternExample2
{
    class SuluYemekConcreteBuilder : YemekBuilder
    {
        public SuluYemekConcreteBuilder()
        {
            yemek = new Yemek();
        }
        public override void SetProtein() => yemek.Protein = 5;
        public override void SetYemekAdi() => yemek.YemekAdi = "Çorba";
        public override void SetYemekTipi() => yemek.YemekTipi = YemekTipi.Sulu;
    }
    //ConcreteBuilder Class
    class EtliYemekConcreteBuilder : YemekBuilder
    {
        public EtliYemekConcreteBuilder()
        {
            yemek = new Yemek();
        }
        public override void SetProtein() => yemek.Protein = 65;
        public override void SetYemekAdi() => yemek.YemekAdi = "Etli Pilav";
        public override void SetYemekTipi() => yemek.YemekTipi = YemekTipi.Etli;
    }
    //ConcreteBuilder Class
    class SebzeliYemekConcreteBuilder : YemekBuilder
    {
        public SebzeliYemekConcreteBuilder()
        {
            yemek = new Yemek();
        }
        public override void SetProtein() => yemek.Protein = 15;
        public override void SetYemekAdi() => yemek.YemekAdi = "Pırasa";
        public override void SetYemekTipi() => yemek.YemekTipi = YemekTipi.Sebzeli;
    }
}
