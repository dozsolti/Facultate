using System;
using System.Collections.Generic;

namespace Examen
{
    public class Spectacol
    {
        public int inceput, sfarsit;
        public Spectacol(int _i, int _s)
        {
            inceput = _i;
            sfarsit = _s;
        }
    }
    /*
     * Se da o lista de spectacole:
     * timp de inceput (ora)
     * timp de sfarsit (ora)
     */
    public class Program
    {
        static Random rnd;
        static List<Spectacol> spectacole;
        static void Main(string[] args)
        {
            rnd = new Random();
            Init();
            spectacole.Sort((a, b) => { return a.sfarsit - b.sfarsit; });

            for(int i=0;i<spectacole.Count;i++)
                Console.WriteLine("spectacol {0} incepe la  {1} si termina: {2}", i,spectacole[i].inceput, spectacole[i].sfarsit);

            Console.WriteLine("-----------------");
            Spectacol current = spectacole[0];
            Print(current);
            for(int i = 1; i < spectacole.Count; i++)
            {
                if (spectacole[i].inceput >= current.sfarsit)
                {
                    current = spectacole[i];
                    Print(current);
                }
            }
            Console.ReadKey();
        }
        static void Print(Spectacol spectacol)
        {
            Console.WriteLine("spectacol  {0} si termina: {1}", spectacol.inceput, spectacol.sfarsit);
        }
        static void Init()
        {
            spectacole = new List<Spectacol>();
            for (int k = 0; k < 5; k++)
            {
                int i = rnd.Next(20);
                int j = i + rnd.Next(5) + 1;
                spectacole.Add(new Spectacol(i,j));
            }
        }
    }
}
