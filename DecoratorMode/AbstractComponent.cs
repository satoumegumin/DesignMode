using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorMode
{
    abstract class AbstractComponent
    {
       public abstract void Operation();
    }

    class ConcreteComponent : AbstractComponent
    {
        public override void Operation()
        {
            Console.WriteLine("对象的操作");
        }
    }
}
