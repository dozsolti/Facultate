using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuringMachine
{
    class Program
    {
        enum Directie { STANGA = -1 , DREAPTA = 1};

        struct Action
        {
            public string stareInceput,stareFinala;
            public char simbolInceput,simbolFinal;
            public Directie directie;

            public Action(string stareInceput, string stareFinala, char simbolInceput, char simbolFinal, Directie directie)
            {
                this.stareInceput = stareInceput;
                this.stareFinala = stareFinala;
                this.simbolInceput = simbolInceput;
                this.simbolFinal = simbolFinal;
                this.directie = directie;
            }
        }

        static List<char> banda;
        static List<Action> tabela;
        static int pas, index;
        static string stare;
        static char[] stareFinala = { '1', '0', '0', '1', '1' };

        static void Main(string[] args)
        {
            banda = new List<char>() { '1', '1' };
            tabela = new List<Action>()
            {
                new Action("s1","s2",'1','0',Directie.DREAPTA),
                new Action("s2","s2",'1','1',Directie.DREAPTA),
                new Action("s2","s3",'0','0',Directie.DREAPTA),
                new Action("s3","s4",'0','1',Directie.STANGA),
                new Action("s3","s3",'1','1',Directie.DREAPTA),
                new Action("s4","s4",'1','1',Directie.STANGA),
                new Action("s4","s5",'0','0',Directie.STANGA),
                new Action("s5","s5",'1','1',Directie.STANGA),
                new Action("s5","s1",'0','1',Directie.DREAPTA)

            };
            index = 0;
            pas = 1;
            stare = "s1";

            Print();
            while (eFinal() == false)
            {
                Console.ReadKey();
                Pas();
                Print();

            }
            Console.WriteLine("  -- Stop --  ");
            Console.ReadLine();
        }

        private static bool eFinal()
        {
            if (stareFinala.Length != banda.Count)
                return false;
            for (int i = 0; i < stareFinala.Length; i++)
                if (stareFinala[i] != banda[i])
                    return false;

            return true;
        }

        private static void Pas()
        {
            pas++;
            Action actiune = tabela.Find(delegate (Action action) {
                return action.stareInceput == stare && action.simbolInceput == banda[index];
            });
            banda[index] = actiune.simbolFinal;

            stare = actiune.stareFinala;
            index += (int)actiune.directie;

            if (index >= banda.Count)
                banda.Add('0');
            else if (index < 0)
                banda.Insert(0,'0');
        }

        private static void Print()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendFormat("{0}\t {1}\t", pas, stare);
            foreach (char item in banda)
                stringBuilder.Append(item.ToString()+' ');
            Console.WriteLine(stringBuilder.ToString());
        }
    }
}
