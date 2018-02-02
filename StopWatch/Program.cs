using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StopWatch
{

    class Program
    {
        static void Main(string[] args)
        {

            bool readyToExit = false;

            var timer = new Timer();
            Console.WriteLine("WELCOME TO STOPWATCH!!!");
            Console.WriteLine("------------------");
            Console.WriteLine("Type 'start' to begin timer");
            Console.WriteLine("Type 'stop' to stop the timer and get elapsed time");
            Console.WriteLine("Type 'quit' to exit the application");

            while (!readyToExit)
            {
                string currentCommand = Console.ReadLine();

                if (currentCommand.ToLower() == "start")
                    timer.start();
                else if (currentCommand.ToLower() == "stop")
                    timer.stop();
                else if (currentCommand.ToLower() == "quit")
                    readyToExit = true;
                else Console.WriteLine("Invalid Command");
            }
                
        }
    }
}
