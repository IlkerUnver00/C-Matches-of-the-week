using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vektorel.HaftaninMaclari
{
    class Program
    {
        static void Main(string[] args)
        {
            //string mac = "Fenerbahçe : 0 - 0 : Galatasaray ";

            string[] takimlar =
            {
                "Beşiktaş","Fenerbahçe","Galatasaray","Trabzonspor"
            };


            string[] maclar = new string[9];
            Console.WriteLine("Haftanın maçları uygulmasına hoş geldiniz");
            int eklenenTakimSayisi = 0;
            Random rnd = new Random();
            while (true)
            {
                Console.WriteLine("1-Maç Oluştur\n2-Maçları görüntüle");
                char c = Console.ReadKey(true).KeyChar;
                if (c=='1')
                {
                    Console.Write("Ev takımı:");
                    string takima = Console.ReadLine();
                    Console.Write("Deplasman takımı:");
                    string takimb = Console.ReadLine();

                    maclar[eklenenTakimSayisi] = $"{takima} : {rnd.Next(6)} - {rnd.Next(5)} : {takimb}";
                    eklenenTakimSayisi++;
                }
                else if (c == '2')
                {
                    for (int i = 0; i < eklenenTakimSayisi; i++)
                    {
                        Console.WriteLine(maclar[i]);
                    }
                }

            }

        }
    }
}
