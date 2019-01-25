using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.访问者模式
{
    class ConcreteElementB : Element
    {
        public ConcreteElementB()
        {
        }

        public override void Accept(Visitor visitor)
        {
            visitor.VisitConreteElementB(this);
        }

        public void OperationB()
        {

        }
    }
}
