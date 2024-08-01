using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Öröklödés
{
    class Auto
    {
        public static string jarmu = "indulhatunk";
        public string márka;
        public string uzemanyag;
        public double fogyasztas;
        public int km;

        public Auto(string márka, string uzemanyag, double fogyasztas, int km)
        {
            this.márka = márka;
            this.uzemanyag = uzemanyag;
            this.fogyasztas = fogyasztas;
            this.km = km;


        }
    }
        class Volkswagen : Auto
        {
            public string golf;
            public string generáció;
            public int rank;

            public Volkswagen(string márka, string uzemanyag, double fogyasztas, int km, string golf, string generáció, int rank) : base(márka, uzemanyag, fogyasztas, km)
            {
                this.golf = golf;
                this.generáció = generáció;
                this.rank = rank;

            }
        }
    
    internal class Program
    {
        static void Main(string[] args)
        {
            Auto auto = new Auto("Suzuki", "Benzin", 5.6 , 180000);
            Console.WriteLine($" márka: {auto.márka},\n üzemanyag: {auto.uzemanyag},\n fogyasztása: {auto.fogyasztas}l,\n futott km: {auto.km} km\n\n");
            Volkswagen golf = new Volkswagen("Volkswagen", "diesel", 6.1, 264000, "golf", "4.generáció", 1);

            Console.WriteLine($" márka: {golf.márka},\n üzemanyag: {golf.uzemanyag},\n fogyasztása: {golf.fogyasztas}l,\n futott km: {golf.km}km\n típus: {golf.golf}\n generáció: {golf.generáció}\n rank: {golf.rank}");
            Console.ReadKey();
        }
    }
}
