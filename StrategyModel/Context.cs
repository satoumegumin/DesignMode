using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyModel
{
    public class Context
    {
        AbstarctStrategy strategy = null;

        public Context(AbstarctStrategy abstarctStrategy)
        {
            this.strategy = abstarctStrategy;
        }

        public void Invoke()
        {
            strategy.AlgorithmInterface();
        }
    }
}
