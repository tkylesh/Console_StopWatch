using System;
using System.Diagnostics;

namespace StopWatch
{
    public class Timer
    {
        public DateTime startTime { get; private set; }
        public DateTime stopTime { get; private set; }
        public bool isRunning { get; private set; }
        public TimeSpan elapsed { get; private set; }

        public Timer()
        {
            isRunning = false;
        }

        public void start()
        {
            if (isRunning)
                throw new InvalidOperationException();
            else
            startTime = DateTime.Now;
            //Console.WriteLine(startTime);
            isRunning = true;
        }

        public void stop()
        {


            stopTime = DateTime.Now;
            //Console.WriteLine(stopTime);

            //get the elapsed time as a timespan value.
            TimeSpan ts = stopTime-startTime;

            ////Format and display the TimeSpan value.
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
            Console.WriteLine("RunTime: " + elapsedTime);
        }

    }
}
