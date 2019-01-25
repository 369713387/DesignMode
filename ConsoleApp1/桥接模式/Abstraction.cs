using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.桥接模式
{
    class Abstraction
    {
        protected Implementor implementor;

        public void SetImplementor(Implementor implementor)
        {
            this.implementor = implementor;
        }

        public virtual void Operation()
        {
            Console.WriteLine("Abstraction + Operation");
            implementor.Operation();
        }

    }
}
