using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryCal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("one num");
            double numA = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("operation");
            string opeartion = Console.ReadLine();
            Console.WriteLine("two num");
            double numB = Convert.ToDouble(Console.ReadLine());
            Operation opera = OperationFactory.Createopertion(opeartion);
            opera.NumA = numA;
            opera.NumB = numB;
            Console.WriteLine(opera.NumA + opeartion + opera.NumB +" = " +opera.GetResult() );
            Console.Read();
        }
    }
}
