//using System;
///// <summary>
///// �۲���ģʽ����ע������Ϊ
///// </summary>
//namespace ConsoleApp1.�۲���ģʽ
//{    
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            ConcreteSubject boss = new ConcreteSubject();

//            ConcreteObserverA A = new ConcreteObserverA(boss, "ͬ��A");

//            boss.str_Update += A.ConcreteObserverAction_A;

//            boss.SubjectState = "StateA";
//            str_EventArgs e = new str_EventArgs(A.Name);
//            boss.Notify(e);
//            boss.str_Update -= A.ConcreteObserverAction_A;

//            Console.Read();
//        }
//    }
//}