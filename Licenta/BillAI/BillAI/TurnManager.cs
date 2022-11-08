using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillAI
{
    public static class TurnManager
    {
        public static int generationCount = 0;
        public static int deadCount = 0;

        public static Generation bestGeneration;
        public static List<Generation> generations;

        public static void Start()
        {
            deadCount = 0;
            bestGeneration = null;
            generations = new List<Generation>();
            for (int i = 0; i < Prefs.countInGeneration; i++)
            {
                Generation generation = new Generation();
                generations.Add(generation);
            }
            generationCount++;
        }

        public static void Update()
        {
            for (int time = 0; time < Prefs.timeScale; time++)
            {
                for (int i = 0; i < generations.Count; i++)
                {
                    if (generations[i].isAlive)
                    {
                        generations[i].Update();
                        if (generations[i].isDone)
                            generations[i].Shoot();
                        if (generations[i].isAlive == false)
                        {
                            deadCount++;
                            Engine.ClearConsole();
                            Engine.CW("Generation #" + generationCount);
                            Engine.CW(generations[0].GetFitness() + "/6");
                            Engine.CW("Loading: " + (deadCount * 100) / generations.Count + "%");
                            //Engine.CW("a murit generatia " + i + " cu fitnessul: " + generations[i].GetFitness());

                            //Optimizare: cand moar unul sa creasca un contor. Iar in loc de functia de IsAllDeath() va fii daca contorul este == cu numarul elemente dintr-o generatie
                            if (deadCount == generations.Count)
                            {
                                //Engine.CW("\n");
                                ProcessOldGeneration();
                                //Engine.CW("S-a terminat generatia " + generationCount);
                                //Engine.CW("\n");
                                NextGeneration();
                            }
                        }
                    }
                }
            }
        }

        private static void ProcessOldGeneration()
        {
            generations.Sort((a, b) => (int)b.GetFitness() - (int)a.GetFitness());

        }

        //Cand ajunge in functia asta se asteapta ca generations este deja in ordine desc dupa fitness, deci se apeleaza ProcessOldGeneration()
        private static void NextGeneration()
        {
            deadCount = 0;
            //if (generationCount%3==0)
            //    Engine.ClearConsole();

            //New Generation
            /*  Distributia:
             *  {X} 1 best of all the time
             *  1/4 din countInGeneration: cele mai bune
             *  1/4 din countInGeneration: cele mai bune Mutated
             *  1/4 din countInGeneration: generate din cele mai bune, cu tata si mama
             *  1/4 din countInGeneration: random
             */
            //Salvez best of all time
            if (bestGeneration == null || bestGeneration.GetFitness() < generations[0].GetFitness())
                bestGeneration = new Generation(generations[0]);

            List<Generation> newGenerations = new List<Generation>();
            newGenerations.Add(new Generation(bestGeneration));

            //Cel mai bune
            for (int i = 1; i < Prefs.countInGeneration / 4; i++)
                newGenerations.Add(new Generation(generations[i]));

            //Cele mai bune Mutated
            for (int i = Prefs.countInGeneration / 4; i < Prefs.countInGeneration / 2; i++)
            {
                Generation generation = new Generation(generations[i]);
                generation.Mutate();
                newGenerations.Add(generation);
            }

            //Random
            for (int i = Prefs.countInGeneration / 2; i < Prefs.countInGeneration; i++)
            {
                Generation generation = new Generation();
                newGenerations.Add(generation);
            }
            /*for (int i = 1; i < Prefs.countInGeneration; i++)
            {
                Generation generation = new Generation();
                Engine.CW("a inceput generatia #" + i+ " cu "+ generation.angles[0]+ " si "+generation.forces[0]);
                newGenerations.Add(generation);
            }*/
            generations = newGenerations;
            generationCount++;
        }


        public static void Draw()
        {
            generations[0].Draw();
        }
    }
}
