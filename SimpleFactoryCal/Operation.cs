using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryCal
{
    public abstract class Operation
    {
        public double NumA { get; set; }
        public double NumB { get; set; }

        public abstract double GetResult();
    }

    public class OperationAdd : Operation
    {
        public override double GetResult()
        {
            return NumA + NumB;
        }
    }

    public class OperationSub : Operation
    {
        public override double GetResult()
        {
            return NumA - NumB;
        }
    }

    public class OperationMul : Operation
    {
        public override double GetResult()
        {
            return NumA * NumB;
        }
    }

    public class OperationDiv : Operation
    {
        public override double GetResult()
        {
            if (NumB == 0)
            {
                Console.WriteLine(" cal error");
                return 0;
            }
            return NumA / NumB;
        }
    }

}
