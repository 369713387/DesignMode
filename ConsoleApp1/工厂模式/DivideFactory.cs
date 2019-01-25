using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.工厂模式
{
    class DivideFactory : Factory
    {
        public Operation CreateOperation()
        {
            return new OperationDivide();
        }
    }
}
