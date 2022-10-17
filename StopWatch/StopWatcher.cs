using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StopWatch
{
    public class StopWatcher
    {
        
        public static TimeSpan Stop(DateTime start)
        {
            DateTime stopTime = DateTime.Now;
            stopTime.ToLongTimeString();
            TimeSpan timer =  stopTime - start;
            
            return timer;
        }


    }
}
