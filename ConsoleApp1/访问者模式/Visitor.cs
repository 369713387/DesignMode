using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.访问者模式
{
    abstract class Visitor
    {
        abstract public void VisitConreteElementA(ConcreteElementA concreteElementA);
        abstract public void VisitConreteElementB(ConcreteElementB concreteElementB);
    }
}
