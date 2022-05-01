using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice
{
    class Program
    {
        static void Main(string[] args)
        {
            //mängus osaleb kaks mängiat - arvuti (cpu) ja kasutaja (user);
            //mõlemad mängijad vikavad täringid;
            //programm kontrollib kumb mängia vikas suurema tulemuse;
            //see mängia kes viskab rohkem on mängu võitja;
            //täringuid visatakse kolm korda;

            Random rnd = new Random();

            int cpuScore = 0;
            int usrScore = 0;
            int tries = 3;

            start:
            int cpuRandom = rnd.Next(1, 7);
            int usrRandom = rnd.Next(1, 7);

            Console.WriteLine($"Arvuti viskas {cpuRandom} ja kasutaja viskas {usrRandom}");

            if (cpuRandom < usrRandom)
            {
                Console.WriteLine("Sina võitsid");
                usrScore += 1;
            }
            else if (cpuRandom > usrRandom)
            {
                Console.WriteLine("Sina kaotasid");
                cpuScore += 1;
            }
            else
            {
                Console.WriteLine("viik");
            }

            if (tries == 1)
            {
                if (cpuScore > usrScore)
                {
                    Console.WriteLine("Sina kaotasid selle mängu.");
                }
                else if (usrScore > cpuScore)
                {
                    Console.WriteLine("Sina võitsid selle mängu!");
                }
                else
                {
                    Console.WriteLine("See mäng jäi viiki");
                }

                Console.ReadLine();
            }
            else
            {
                tries -= 1;
                Console.WriteLine("Alustame järgmist raundi");
                Console.ReadLine();
                goto start;
            }
        }
    }
}
