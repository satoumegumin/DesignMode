using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyModel
{
    class Program
    {
        static void Main(string[] args)
        {

            Context context = new Context(new StrategyA());
            context.Invoke();

            Context context1 = new Context(new StrategyB());
            context1.Invoke();

            Console.Read();
        }
    }
}
