using System;
using Lib_torte;

namespace Consumer
{
    class Consumer
    {
        static void Main(string[] args)
        {
            Torta t = new Torta("eghasog", 5.3, 532);
            Torta[] torte = new Torta[20];
            for (int i = 0; i < 5; i++)
                torte[i] = new Torta("Tortina", 5.51, 60);
            for (int i = 5; i < 15; i++)
                torte[i] = new Torta_preparata("Tortina", 5.51, 60);
            for (int i = 15; i < 20; i++)
                torte[i] = new Torta_industriale(10.50,"Tortina", 5.51, 60);
            double max = 0;
            string nome = "";
            foreach (var torta in torte)
            {
                Console.WriteLine(torta.Prezzo());
                if (max<torta.Prezzo()){max = torta.Prezzo();nome = torta.GetNome();}
            }
            Console.WriteLine("Piu costosa -> " + nome +" che costa " +$"{max}");
        }
    }
}
