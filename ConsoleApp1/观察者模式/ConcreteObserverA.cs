using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.观察者模式
{
    class ConcreteObserverA
    {
        private string name;
        private ConcreteSubject subject;
        public ConcreteSubject Subject { get => subject; set => subject = value; }
        public string Name { get => name; set => name = value; }

        public ConcreteObserverA(ConcreteSubject subject, string name)
        {
            this.subject = subject;
            this.Name = name;
        }             

        public void ConcreteObserverAction_A(Object sender,str_EventArgs e)
        {

            ConcreteSubject concreteSubject = (ConcreteSubject)sender;
            if (concreteSubject.SubjectState.Equals("StateA"))
            {
                Console.WriteLine("在{0}状态下，{1}的行为{2}", subject.SubjectState,e.name,"收拾");
            }
            else if(concreteSubject.SubjectState.Equals("StateB"))
            {
                Console.WriteLine("在{0}状态下，{1}的行为{2}", subject.SubjectState, e.name,"下班");
            }
            else
            {
                Console.WriteLine("状态信息错误");
            }
            
        }

        public void ConcreteObserverAction_A(string name)
        {
            if (subject.SubjectState.Equals("StateA"))
            {
                Console.WriteLine("在{0}状态下，{1}的行为{2}", subject.SubjectState, name ," 收拾");
            }
            else if (subject.SubjectState.Equals("StateB"))
            {
                Console.WriteLine("在{0}状态下，{1}的行为{2}", subject.SubjectState, name, " 下班");
            }
            else
            {
                Console.WriteLine("状态信息错误");
            }

        }
    }
}
