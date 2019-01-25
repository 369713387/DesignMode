//using System;
///// <summary>
///// 观察者模式，关注对象行为
///// </summary>
//namespace ConsoleApp1.观察者模式
//{    
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            ConcreteSubject boss = new ConcreteSubject();

//            ConcreteObserverA A = new ConcreteObserverA(boss, "同事A");

//            boss.str_Update += A.ConcreteObserverAction_A;

//            boss.SubjectState = "StateA";
//            str_EventArgs e = new str_EventArgs(A.Name);
//            boss.Notify(e);
//            boss.str_Update -= A.ConcreteObserverAction_A;

//            Console.Read();
//        }
//    }
//}