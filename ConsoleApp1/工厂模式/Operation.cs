using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.工厂模式
{
    abstract class Operation
    {
        private double NumA;
        private double NumB;

        public double NumA1 { get => NumA; set => NumA = value; }
        public double NumB1 { get => NumB; set => NumB = value; }

        abstract public double GetResult(double numA,double numB);
    }
}
