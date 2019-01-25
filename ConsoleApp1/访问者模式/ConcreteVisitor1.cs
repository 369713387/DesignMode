using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.访问者模式
{
    class ConcreteVisitor1 : Visitor
    {
        public ConcreteVisitor1()
        {
        }

        public override void VisitConreteElementA(ConcreteElementA concreteElementA)
        {
            Console.WriteLine("{0}被{1}访问", concreteElementA.GetType().Name, this.GetType().Name);
        }

        public override void VisitConreteElementB(ConcreteElementB concreteElementB)
        {
            Console.WriteLine("{0}被{1}访问", concreteElementB.GetType().Name, this.GetType().Name);
        }
    }
}
