using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Clock
    {
        int hour;
        int minute;
        int second;

        pablic Clock(int hour, int minute, int second)
        {
            this.hour = hour;
            this.minute = minute;
            this.second = second;
        }
        public int ToSecond()
        {
            return second + minute * 60 + hour * 60 * 60;
        }
    }
}
