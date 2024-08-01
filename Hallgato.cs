using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Öröklödés
{
 class Hallgato
    {
        public string azonositó;
        public int evfolyam;
        public int kreditszam;
        private string kedvencTargy;
        public static string egyetem;

        public Hallgato(string azonositó, int evfolyam, int kreditszam, string kedvencTargy)
        {
            this.azonositó = azonositó;
            this.evfolyam = evfolyam;
            this.kreditszam = kreditszam;
            this.kedvencTargy = kedvencTargy;

        }

        public Hallgato(string azonositó)
        {
            this.evfolyam = 1;

            this.azonositó = azonositó;
            this.kreditszam = 0;
        }
        public void Targyfelvesz(int kredit)
        {
            this.kreditszam += kredit;
        }
        public bool Vizsgazik()
        {

            if (this.kreditszam > 0)
            {
                Console.WriteLine("sikeres vizsga");
                this.evfolyam += 1;
                this.kreditszam = 0;
                return true;
            }
            else
            {
                Console.WriteLine("a vizsga sikertelen");
            return false;
            }
         
        }

    } 
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Hallgato.egyetem = "szegedi tudományegyetem";
            Hallgato h1 = new Hallgato("7213",2,20,"c# programozás");
               Hallgato h2 = new Hallgato("2131",1,0, "c# programozás");

            h1.Targyfelvesz(20);
            Console.WriteLine($"{Hallgato.egyetem} \n1.diák évfolyama: {h1.evfolyam}\n azonosító: {h1.azonositó} \n kredit: {h1.kreditszam}");
            h1.Vizsgazik();
            Console.WriteLine($"\n\n {Hallgato.egyetem}\n2.diák évfolyama: {h2.evfolyam}\n azonosító: {h2.azonositó} \n kredit: {h2.kreditszam}");
            h2.Vizsgazik();

            Console.ReadKey();
        }
        
        }
    }

