//using System;

//namespace ConsoleApp1.职责链模式
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            ConcreteHandler1 Low = new ConcreteHandler1();
//            ConcreteHandler2 Middle = new ConcreteHandler2();
//            ConcreteHandler3 High = new ConcreteHandler3();
//            //设置责任链
//            Low.SetHandle(Middle);
//            Middle.SetHandle(High);

//            Request request = new Request("Jack","High","请假2天");
//            //从最低级开始访问
//            Low.ExecutedRequest(request);

//            request.Username = "Ma";
//            request.Priority = "Middle";
//            request.Content = "加薪100";

//            Low.ExecutedRequest(request);

//            request.Username = "Wang";
//            request.Priority = "Low";
//            request.Content = "辞职";

//            Low.ExecutedRequest(request);

//            Console.Read();
//        }
//    }
//}