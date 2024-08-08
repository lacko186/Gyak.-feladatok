using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szamok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("==================================================== SzámKitaláló ====================================================");
            Console.WriteLine("\n Találd ki a számot, a számok szöveggel vannak kiírva a te dolgod az lesz, hogy számokkal leírd őket..");
            Console.WriteLine("Kezdjük: ");
            int jo = 0;
            int rossz = 0;
                
                
            Console.WriteLine("Az első szám: sechzehn");
            int egy = Int32.Parse(Console.ReadLine());
            if (egy == 16)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("A válasz helyes");
                jo++;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("A válasz helytelen");
                rossz++;
            }
            Console.ForegroundColor = ConsoleColor.Gray;

            Console.WriteLine("A második szám: achtzig");
            int ketto = Int32.Parse(Console.ReadLine());
            if (ketto == 80)
            {
                jo++;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("A válasz helyes");
            }
            else
            {

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("A válasz helytelen");
                rossz++;
            }
            Console.ForegroundColor = ConsoleColor.Gray;

            Console.WriteLine("Az harmadik szám: fünfundzwanzig");
            int harom = Int32.Parse(Console.ReadLine());
            if (harom == 25)
            {
                jo++;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("A válasz helyes");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("A válasz helytelen");
                rossz++;
            }
            Console.ForegroundColor = ConsoleColor.Gray;

            Console.WriteLine("A negyedik szám: dreiundsiebzig");
            int negy = Int32.Parse(Console.ReadLine());
            if (negy == 73)
            {
                jo++;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("A válasz helyes");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("A válasz helytelen");
                rossz++;
            }
            Console.ForegroundColor = ConsoleColor.Gray;

            Console.WriteLine("Az ötödik szám: eins");
            int öt = Int32.Parse(Console.ReadLine());
            if (öt == 1)
            {
                jo++;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("A válasz helyes");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("A válasz helytelen");
                rossz++;
            }
            Console.ForegroundColor = ConsoleColor.Gray;

            Console.WriteLine("A hatodik szám: neunzig");
            int hat = Int32.Parse(Console.ReadLine());
            if (hat == 90)
            {
                jo++;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("A válasz helyes");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("A válasz helytelen");
                rossz++;

            }
            Console.ForegroundColor = ConsoleColor.Gray;

            Console.WriteLine("A hetedik szám: hundert");
            int hét = Int32.Parse(Console.ReadLine());
            if (hét == 100)
            {
                jo++;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("A válasz helyes");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("A válasz helytelen");
                rossz++;
            }
            Console.ForegroundColor = ConsoleColor.Gray;

            Console.WriteLine("A nyolcadik szám: fünf");
            int nyolc = Int32.Parse(Console.ReadLine());
            if (nyolc == 5)
            {
                jo++;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("A válasz helyes");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("A válasz helytelen");
                rossz++;
            }
            Console.ForegroundColor = ConsoleColor.Gray;

            Console.WriteLine("A kilencedik szám: dreißig ");
            int kilenc = Int32.Parse(Console.ReadLine());
            if (kilenc == 30)
            {
                jo++;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("A válasz helyes");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("A válasz helytelen");
                rossz++;
            }
            Console.ForegroundColor = ConsoleColor.Gray;

            Console.WriteLine("A tizedik szám: sieben");
            int tíz = Int32.Parse(Console.ReadLine());
            if (tíz == 7)
            {
                jo++;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("A válasz helyes");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("A válasz helytelen");
                rossz++;
            }
            Console.ForegroundColor = ConsoleColor.Gray;

            Console.WriteLine("A tizeneggyedik szám: zwölf");
            int tizenegy = Int32.Parse(Console.ReadLine());
            if (tizenegy == 12)
            {
                jo++;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("A válasz helyes");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("A válasz helytelen");
                rossz++;
            }
            Console.ForegroundColor = ConsoleColor.Gray;

            Console.WriteLine("A tizenkettedik szám: drei");
            int tizenkettő = Int32.Parse(Console.ReadLine());
            if (tizenkettő == 3)
            {
                jo++;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("A válasz helyes");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("A válasz helytelen");
                rossz++;
            }
            Console.ForegroundColor = ConsoleColor.Gray;

            Console.WriteLine("A tizenharmadik szám: dreiundsiebzig");
            int tizenharom = Int32.Parse(Console.ReadLine());
            if (tizenharom == 73)
            {
                jo++;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("A válasz helyes");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("A válasz helytelen");
                rossz++;
            }
            Console.ForegroundColor = ConsoleColor.Gray;

            Console.WriteLine("A tizennegyedik szám: elf");
            int tizennégy = Int32.Parse(Console.ReadLine());
            if (tizennégy == 11)
            {
                jo++;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("A válasz helyes");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("A válasz helytelen");
                rossz++;
            }
            Console.ForegroundColor = ConsoleColor.Gray;

            Console.WriteLine("A tizenötödik szám: zweiundvierzig");
            int tizenöt = Int32.Parse(Console.ReadLine());
            if (tizenöt == 42)
            {
                jo++;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("A válasz helyes");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("A válasz helytelen");
                rossz++;
            }
            Console.ForegroundColor = ConsoleColor.Gray;

            Console.WriteLine("A tizenhatodik szám: vier");
            int tizenhat = Int32.Parse(Console.ReadLine());
            if (tizenhat == 4)
            {
                jo++;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("A válasz helyes");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("A válasz helytelen");
                rossz++;
            }
            Console.ForegroundColor = ConsoleColor.Gray;

            Console.WriteLine("A tizenhetedik szám: Siebenundsechzig");
            int tizenhét = Int32.Parse(Console.ReadLine());
            if (tizenhét == 67)
            {
                jo++;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("A válasz helyes");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("A válasz helytelen");
                rossz++;
            }
            Console.ForegroundColor = ConsoleColor.Gray;

            Console.WriteLine("A tizennyolcadik szám: zehn");
            int tizennyolc = Int32.Parse(Console.ReadLine());
            if (tizennyolc == 10)
            {
                jo++;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("A válasz helyes");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("A válasz helytelen");
                rossz++;
            }
            Console.ForegroundColor = ConsoleColor.Gray;

            Console.WriteLine("A tizenkilencedik szám: Sechsundsechzig");
            int tizenkilenc = Int32.Parse(Console.ReadLine());
            if (tizenkilenc == 66)
            {
                jo++;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("A válasz helyes");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("A válasz helytelen");
                rossz++;
            }

            Console.ForegroundColor = ConsoleColor.Gray;

            Console.WriteLine("A huszadik szám: dreizehn");
            int húsz = Int32.Parse(Console.ReadLine());
            if (húsz == 13)
            {
                jo++;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("A válasz helyes");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("A válasz helytelen");
                rossz++;
            }
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine($"\n\nA helyes válaszok száma: {jo}\n\n a rossz válaszok száma: {rossz}");


            Console.WriteLine("2.feladat");
            Console.WriteLine("írd le a számokat 12-ig");
            Console.WriteLine("\n1: ");
            string a = Console.ReadLine();
            int j = 0;
            int r = 0;
            if (a == "eins")
            {
                Console.ForegroundColor = ConsoleColor.Green;

                j++;
                Console.WriteLine("$$$$$$$$$$");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;

                r++;
                Console.WriteLine("x");
                Console.WriteLine($"a helyes megoldás: eins");
            }
            Console.ForegroundColor = ConsoleColor.Gray;

            Console.WriteLine("\n2: ");
            string b = Console.ReadLine();
            if (b == "zwei")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                j++;
                Console.WriteLine("✓");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;

                r++;
                Console.WriteLine("x");

                Console.WriteLine($"a helyes megoldás: zwei");
            }
            Console.ForegroundColor = ConsoleColor.Gray;

            Console.WriteLine("\n3: ");
            string d = Console.ReadLine();
            if (d == "drei")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                j++;
                Console.WriteLine("$$$$$$$$$$");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;

                r++;
                Console.WriteLine("x");

                Console.WriteLine($"a helyes megoldás: drei");
            }
            Console.ForegroundColor = ConsoleColor.Gray;

            Console.WriteLine("\n4: ");
            string e = Console.ReadLine();
            if (e == "vier")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                j++;
                Console.WriteLine("$$$$$$$$$$");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;

                r++;
                Console.WriteLine("x");

                Console.WriteLine($"a helyes megoldás: vier");
            }
            Console.ForegroundColor = ConsoleColor.Gray;

            Console.WriteLine("\n5: ");
            string f = Console.ReadLine();
            if (f == "fünf")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                j++;
                Console.WriteLine("$$$$$$$$$$");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;

                r++;
                Console.WriteLine("x");

                Console.WriteLine($"a helyes megoldás: fünf");
            }
            Console.ForegroundColor = ConsoleColor.Gray;

            Console.WriteLine("\n6: ");
            string g = Console.ReadLine();
            if (g == "sechs")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                j++;
                Console.WriteLine("$$$$$$$$$$");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;

                r++;
                Console.WriteLine("x");

                Console.WriteLine($"a helyes megoldás: sechs");
            }
            Console.ForegroundColor = ConsoleColor.Gray;

            Console.WriteLine("\n7: ");
            string h = Console.ReadLine();
            if (h == "sieben")
            {
                Console.ForegroundColor = ConsoleColor.Green;

                j++;
                Console.WriteLine("$$$$$$$$$$");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;

                r++;
                Console.WriteLine("x");

                Console.WriteLine($"a helyes megoldás: sieben");
            }
            Console.ForegroundColor = ConsoleColor.Gray;

            Console.WriteLine("\n8: ");
            string p = Console.ReadLine();
            if (p == "acht")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                j++;
                Console.WriteLine("$$$$$$$$$$");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;

                r++;
                Console.WriteLine("x");

                Console.WriteLine($"a helyes megoldás: acht");
            }
            Console.ForegroundColor = ConsoleColor.Gray;

            Console.WriteLine("\n9: ");
            string q = Console.ReadLine();
            if (q == "neun")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                j++;
                Console.WriteLine("$$$$$$$$$$");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;

                r++;
                Console.WriteLine("x");

                Console.WriteLine($"a helyes megoldás: neun");
            }
            Console.ForegroundColor = ConsoleColor.Gray;

            Console.WriteLine("\n10: ");
            string t = Console.ReadLine();
            if (t == "zehn")
            {
                Console.ForegroundColor = ConsoleColor.Green;

                j++;
                Console.WriteLine("$$$$$$$$$$");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;

                r++;
                Console.WriteLine("x");

                Console.WriteLine($"a helyes megoldás: zehn");
            }
            Console.ForegroundColor = ConsoleColor.Gray;

            Console.WriteLine("\n11: ");
            string z = Console.ReadLine();
            if (z == "elf")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                j++;
                Console.WriteLine("$$$$$$$$$$");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;

                r++;
                Console.WriteLine("x");

                Console.WriteLine($"a helyes megoldás: elf");
            }
            Console.ForegroundColor = ConsoleColor.Gray;

            Console.WriteLine("\n12: ");
            string w = Console.ReadLine();
            if (w == "zwölf")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                j++;
                Console.WriteLine("$$$$$$$$$$");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;

                r++;
                Console.WriteLine("x");

                Console.WriteLine($"a helyes megoldás: zwölf");
            }

            Console.ForegroundColor = ConsoleColor.Gray;

            Console.WriteLine($"\nJó válaszból: {j} db volt\n");
            Console.WriteLine($"rossz válaszból: {r} db volt");
            Console.ReadKey();
        }
    }
}
