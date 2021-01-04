using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorMode
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractComponent component = new ConcreteComponent();
            DecoratorClass decorator = new DecoratorA();
            decorator.SetComponent(component);

            decorator.Operation();

            Console.Read();
        }
    }
}
