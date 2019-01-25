using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.工厂模式
{
    class OperationSub : Operation
    {
        public override double GetResult(double numA, double numB)
        {
            return numA - numB;
        }
    }
}
