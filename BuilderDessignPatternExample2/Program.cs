using System;

namespace BuilderDessignPatternExample2
{
    class Program
    {
        static void Main(string[] args)
        {
            YemekBuilder builder = new SuluYemekConcreteBuilder();
            YemekYapici yemekYapici = new YemekYapici();
            yemekYapici.YemekYap(builder);
            builder.Yemek.ToString();

            builder = new EtliYemekConcreteBuilder();
            yemekYapici.YemekYap(builder);
            builder.Yemek.ToString();

            Console.Read();
        }
    }
}