using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorMode
{
    class DecoratorClass : AbstractComponent
    {
        protected AbstractComponent _component;

        public void SetComponent(AbstractComponent component)
        {
            this._component = component;
        }
        public override void Operation()
        {
            _component.Operation();
        }
    }

    class DecoratorA : DecoratorClass
    {
        public override void Operation()
        {
            Console.WriteLine("此装饰器独有功能");
            base.Operation();
        }
    }
}
