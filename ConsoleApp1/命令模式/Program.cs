//using System;

//namespace ConsoleApp1.ÃüÁîÄ£Ê½
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Receiver receiver = new Receiver();
//            ConcreteCommandA ccm1 = new ConcreteCommandA(receiver);
//            ConcreteCommandB ccm2 = new ConcreteCommandB(receiver);
//            ConcreteCommandC ccm3 = new ConcreteCommandC(receiver);
//            ConcreteCommandD ccm4 = new ConcreteCommandD(receiver);
//            Invoker invoker = new Invoker();
//            invoker.AddCommand(ccm1);
//            invoker.AddCommand(ccm2);
//            invoker.AddCommand(ccm3);
//            invoker.AddCommand(ccm1);
//            invoker.AddCommand(ccm4);
//            invoker.AddCommand(ccm2);
//            invoker.AddCommand(ccm3);
//            invoker.AddCommand(ccm2);
//            invoker.AddCommand(ccm4);
//            invoker.AddCommand(ccm2);
//            invoker.AddCommand(ccm1);

//            invoker.RemoveCommand(ccm2);

//            invoker.Notify();

//            Console.Read();
//        }
//    }
//}