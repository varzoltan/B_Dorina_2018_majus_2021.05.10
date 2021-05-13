using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace B_Dorina_2018_majus_2021._05._10
{
    class Program
    {
        struct Adat
        {
            public int ora;
            public int perc;
            public int azonosito;
            public string beki;
            public int bentlevok;
        }
        static void Main(string[] args)
        {
            Adat[] adatok = new Adat[1000];//Példányosítás

            //Beolvasás
            StreamReader olvas = new StreamReader(@"C:\Users\Rendszergazda\Desktop\K_eszter_prog_erettsegi\2018-majus\ajto.txt");
            int n = 0;
            int bentlevok = 0;
            while (!olvas.EndOfStream)
            {
                string sor = olvas.ReadLine();
                string[] db = sor.Split();
                adatok[n].ora = int.Parse(db[0]);
                adatok[n].perc = int.Parse(db[1]);
                adatok[n].azonosito = int.Parse(db[2]);
                adatok[n].beki = db[3];
                if (db[3] == "be")
                {
                    bentlevok++;
                }
                else
                {
                    bentlevok--;
                }
                adatok[n].bentlevok = bentlevok;
                n++;
            }
            olvas.Close();
            Console.WriteLine("1.feladat kész!\nBeolvasás kész!");

            //2.feladat
            Console.WriteLine("2.feladat");
            for (int i = 0;i<n;i++)
            {
                if (adatok[i].beki == "be")
                {
                    Console.WriteLine($"Az első belépő: {adatok[i].azonosito}");
                    break;//Kiugrik a ciklus magjából.
                }
            }
            for (int i = n - 1; i >= 0; i--)
            {
                if (adatok[i].beki == "ki")
                {
                    Console.WriteLine($"Az utolsó kilépő: {adatok[i].azonosito}");
                    break;
                }
            }


            //3.feladat
            StreamWriter ir = new StreamWriter(@"C:\Users\Rendszergazda\Desktop\K_eszter_prog_erettsegi\2018-majus\athaladas.txt");
            int beki = 0;
            for (int i = 1;i<=100;i++)
            {
                for (int j = 0;j<n;j++)
                {
                    if (adatok[j].azonosito == i)
                    {
                        beki++;
                    }
                }
                if (beki != 0)
                {
                    ir.WriteLine($"{i} {beki}");
                }              
                beki = 0;
            }
            ir.Close();

            //4.feladat
            Console.WriteLine("4.feladat");
            Console.Write("A végén a társalgóban voltak: ");
            StreamReader beolvas = new StreamReader(@"C:\Users\Rendszergazda\Desktop\K_eszter_prog_erettsegi\2018-majus\athaladas.txt");
            while (!beolvas.EndOfStream)
            {
                string sor = beolvas.ReadLine();
                string[] db = sor.Split();
                int ossz = int.Parse(db[1]);
                if (ossz % 2 != 0)
                {
                    Console.Write(db[0] + " ");
                }
            }
            beolvas.Close();
            Console.ReadKey();
        }
    }
}
