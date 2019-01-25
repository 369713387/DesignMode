//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace ConsoleApp1.观察者模式
//{
//    class ConcreteObserverB
//    {
//        private string name;
//        private ConcreteSubject subject;
//        public ConcreteSubject Subject { get => subject; set => subject = value; }

//        public ConcreteObserverB(ConcreteSubject subject, string name)
//        {
//            this.subject = subject;
//            this.name = name;
//        }

//        public void ConcreteObserverAction_B()
//        {
//            if (subject.SubjectState.Equals("StateA"))
//            {
//                Console.WriteLine("在{0}状态下，观察者B的行为{1}", subject.SubjectState, "下班");
//            }
//            else if (subject.SubjectState.Equals("StateB"))
//            {
//                Console.WriteLine("在{0}状态下，观察者B的行为{1}", subject.SubjectState, "收拾");
//            }
//            else
//            {
//                Console.WriteLine("状态信息错误");
//            }
//        }

//        public void ConcreteObserverAction_B(string name)
//        {
//            if (subject.SubjectState.Equals("StateA"))
//            {
//                Console.WriteLine("在{0}状态下，{1}的行为{2}", subject.SubjectState, name, " 下班");
//            }
//            else if (subject.SubjectState.Equals("StateB"))
//            {
//                Console.WriteLine("在{0}状态下，{1}的行为{2}", subject.SubjectState, name, " 收拾");
//            }
//            else
//            {
//                Console.WriteLine("状态信息错误");
//            }

//        }
//    }
//}
