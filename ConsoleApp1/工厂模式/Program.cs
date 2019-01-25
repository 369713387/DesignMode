//using System;
///// <summary>
///// 工厂模式，关注对象的创建
///// </summary>
//namespace ConsoleApp1.工厂模式
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Factory factory = new AddFactory();
//            Operation operation = factory.CreateOperation();

//            double res1 = operation.GetResult(1d,2d);

//            factory = new SubFactory();
//            operation = factory.CreateOperation();

//            double res2 = operation.GetResult(4d, 3d);

//            factory = new MultiplyFactory();
//            operation = factory.CreateOperation();

//            double res3 = operation.GetResult(5d, 5d);

//            factory = new DivideFactory();
//            operation = factory.CreateOperation();

//            double res4 = operation.GetResult(1d, 3d);

//            Console.WriteLine(res1+"    "+res2+"    "+res3+"    "+res4);

//            Console.Read();
//        }
//    }
//}