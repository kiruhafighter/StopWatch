using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StopWatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ch;
            do
            {
                Console.WriteLine("Choose go or stop (1 OR 2)");
                ch = Convert.ToInt32(Console.ReadLine());

                switch (ch)
                {
                    case 1:
                        {
                            DateTime start = new DateTime();
                        C1:
                            Console.WriteLine("Type start :");
                            string startStr = Console.ReadLine();
                            if (startStr == "start" || startStr == "Start")
                            {
                                start = DateTime.Now;
                                start.ToLongTimeString();
                            }
                            else
                            {
                                Console.WriteLine("Invalid command , try again");
                                goto C1;
                            }
                        C2:
                            Console.WriteLine("Type stop : ");
                            string stopStr = Console.ReadLine();
                            if (stopStr == "Stop" || stopStr == "stop")
                            {
                                TimeSpan result = StopWatcher.Stop(start);
                                Console.WriteLine("Time Span is :");
                                Console.WriteLine(result.ToString());
                            }
                            else
                            {
                                Console.WriteLine("Invalid command , try again");
                                goto C2;
                            }
                        }
                        break;
                    default:
                        break;

                }

            } while (ch != 2);
                
            
        }
    }
}
