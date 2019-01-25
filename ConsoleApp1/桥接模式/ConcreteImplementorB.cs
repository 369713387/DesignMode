using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.桥接模式
{
    class ConcreteImplementorB : Implementor
    {
        public override void Operation()
        {
            Console.WriteLine("ConcreteImplementorB + Operation");
        }
    }
}
