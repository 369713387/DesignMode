//using System;

//namespace ConsoleApp1.ְ����ģʽ
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            ConcreteHandler1 Low = new ConcreteHandler1();
//            ConcreteHandler2 Middle = new ConcreteHandler2();
//            ConcreteHandler3 High = new ConcreteHandler3();
//            //����������
//            Low.SetHandle(Middle);
//            Middle.SetHandle(High);

//            Request request = new Request("Jack","High","���2��");
//            //����ͼ���ʼ����
//            Low.ExecutedRequest(request);

//            request.Username = "Ma";
//            request.Priority = "Middle";
//            request.Content = "��н100";

//            Low.ExecutedRequest(request);

//            request.Username = "Wang";
//            request.Priority = "Low";
//            request.Content = "��ְ";

//            Low.ExecutedRequest(request);

//            Console.Read();
//        }
//    }
//}