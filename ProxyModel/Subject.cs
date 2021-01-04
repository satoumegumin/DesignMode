using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyModel
{
    //定义公共接口 使得任何地方都可以使用proxy
    abstract class Subject
    {
        public abstract void Request();
    }

    //定义proxy 代理的真实实体
    class RealSubject : Subject
    {
        public override void Request()
        {
            Console.WriteLine("真是的请求");
        }
    }
    class Proxy : Subject
    {
        RealSubject realSub = null;

        public override void Request()
        {
            if (realSub==null)
            {
                realSub = new RealSubject();
            }
            realSub.Request();
        }
    }
}
