using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.桥接模式
{
    class RefinedAbstraction:Abstraction
    {
        public override void Operation()
        {
            Console.WriteLine("RefinedAbstraction + Operation");
            implementor.Operation();
        }
    }
}
