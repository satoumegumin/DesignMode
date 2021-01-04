using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyModel
{
    //定义所支持算法的公共接口
    public abstract class AbstarctStrategy
    {
        public abstract void AlgorithmInterface();
    }

    public class StrategyA : AbstarctStrategy
    {
        public override void AlgorithmInterface()
        {
            Console.WriteLine("算法A实现");
        }
    }

    public class StrategyB : AbstarctStrategy
    {
        public override void AlgorithmInterface()
        {
            Console.WriteLine("算法B实现");
        }
    }
}
