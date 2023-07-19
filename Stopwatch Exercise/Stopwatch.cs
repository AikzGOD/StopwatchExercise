using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Stopwatch_Exercise
{
    internal class Stopwatch
    {
        private TimeSpan startTime;

        private TimeSpan endTime;

        private TimeSpan timeSpent;

            public TimeSpan StartTime
            {
                get { return startTime; }
                set { startTime = value; }
            }

            public TimeSpan EndTime
            {
                get { return endTime; }
                set { endTime = value; }
            }

            public TimeSpan TimeSpent
            {
                get { return timeSpent; }
                set { timeSpent = value; }
            }


        public TimeSpan Start()
        {
            TimeSpan timeStarted = GiveTime();

            return timeStarted;
        }

        public TimeSpan Stop()
        {
            TimeSpan timeEnded = GiveTime();

            return timeEnded;
        }

        private TimeSpan GiveTime() {

            TimeSpan currentTime = DateTime.Now.TimeOfDay;

            return currentTime;

        }

        public string CalculateDuration()
        {
            timeSpent = EndTime - StartTime;

            string strTimeSpent = "Duration (Showed in a String) : " + timeSpent.Hours + ":" + timeSpent.Minutes + ":" + timeSpent.Seconds;



            return strTimeSpent;


        }

        
            


    }
}
