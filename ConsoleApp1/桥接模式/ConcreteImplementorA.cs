using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.桥接模式
{
    class ConcreteImplementorA : Implementor
    {
        public override void Operation()
        {
            Console.WriteLine("ConcreteImplementorA + Operation");
        }
    }
}
