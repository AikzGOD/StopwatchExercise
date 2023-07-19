using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stopwatch_Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StopWatch();
        }

        public static void StopWatch()
        {
            //Instanciar objeto
            Stopwatch sw = new Stopwatch();


            Console.WriteLine("Press enter to start the timer");
            string userInput = Console.ReadLine();

            if (String.IsNullOrEmpty(userInput))
            {
                //Start the timer
                sw.StartTime = sw.Start();

                Console.WriteLine("Timer Started! Click enter to stop");
                string stopTimerInput = Console.ReadLine();


                if (String.IsNullOrEmpty(stopTimerInput))
                {
                    sw.EndTime = sw.Stop();

                    Console.WriteLine("Inicio : " + sw.StartTime);
                    Console.WriteLine("Fim : " + sw.EndTime);
                    Console.WriteLine("");


                    Console.WriteLine(sw.CalculateDuration());
                    Console.WriteLine("TimeSpan duration :" + sw.TimeSpent);
                    Console.WriteLine("");

                    Console.WriteLine("Press enter to restart the timer");
                    string restartTimerInput = Console.ReadLine();

                    if(String.IsNullOrEmpty(restartTimerInput))
                    {
                        Console.Clear();
                        StopWatch();
                    }


                }

            }
        }

    }
}
