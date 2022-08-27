using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите данные (часы, минуты, секунды)");
            int hour = Convert.ToInt32(Console.ReadLine());
            int minute = Convert.ToInt32(Console.ReadLine());
            int second = Convert.ToInt32(Console.ReadLine());

            Clock clock = new Clock(hour, minute, second);

            int totalSecond = clock.ToSecond();
            Console.WriteLine(totalSecond);
            Console.ReadKey();
        }
    }
}

