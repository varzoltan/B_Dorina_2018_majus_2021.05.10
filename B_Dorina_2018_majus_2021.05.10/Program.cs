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
        }
        static void Main(string[] args)
        {
            Adat[] adatok = new Adat[1000];//Példányosítás

            //Beolvasás
            StreamReader olvas = new StreamReader(@"C:\Users\Rendszergazda\Downloads\ajto.txt");
            int n = 0;
            while (!olvas.EndOfStream)
            {
                string sor = olvas.ReadLine();
                string[] db = sor.Split();
                adatok[n].ora = int.Parse(db[0]);
                adatok[n].perc = int.Parse(db[1]);
                adatok[n].azonosito = int.Parse(db[2]);
                adatok[n].beki = db[3];
                n++;
            }
            olvas.Close();
        }
    }
}
