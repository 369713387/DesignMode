using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.访问者模式
{
    class ConcreteElementA : Element
    {
        public ConcreteElementA()
        {
        }

        public override void Accept(Visitor visitor)
        {
            visitor.VisitConreteElementA(this);
        }

        public void OperationA()
        {

        }
    }
}
