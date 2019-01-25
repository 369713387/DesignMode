//using System;

//namespace ConsoleApp1.访问者模式
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            ObjectStructure o = new ObjectStructure();            

//            ConcreteVisitor1 state1 = new ConcreteVisitor1();
//            ConcreteVisitor2 state2 = new ConcreteVisitor2();

//            ConcreteElementA man = new ConcreteElementA();
//            ConcreteElementB women = new ConcreteElementB();

//            o.Attach(man);
//            o.Attach(women);

//            o.Accept(state1);
//            o.Accept(state2);

//            ConcreteVisitor3 state3 = new ConcreteVisitor3();
//            o.Accept(state3);

//            o.Detach(man);
//            o.Detach(women);

//            Console.Read();
//        }
//    }
//}