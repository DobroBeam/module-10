using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._5._1
{
    public class Calculator : IAddition
    {
        ILogger logger { get; }
        public Calculator(ILogger logger)
        {
            this.logger = logger;
        }
        public void Addition(int a, int b)
        {
            logger.Event("Посчитан результат");
            Console.WriteLine("Сумма чисел: {0}", a+b);
        }
    }
}
