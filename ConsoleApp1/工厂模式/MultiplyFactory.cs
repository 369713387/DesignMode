using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.工厂模式
{
    class MultiplyFactory : Factory
    {
        public Operation CreateOperation()
        {
            return new OperationMultiply();
        }
    }
}
