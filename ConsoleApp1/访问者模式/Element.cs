using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.访问者模式
{
    abstract class Element
    {
        abstract public void Accept(Visitor visitor);
    }
}
