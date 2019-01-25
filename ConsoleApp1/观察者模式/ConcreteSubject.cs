using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.观察者模式
{
    class ConcreteSubject:Subject
    {
        public event EventHandler Update;
        public event str_EventHandler str_Update;

        private string subjectState;

        public string SubjectState { get => subjectState; set => subjectState = value; }

        public void Notify(str_EventArgs e)
        {
            if (str_Update != null)
            {
                str_Update(this,e);
            }            
        }

        
    }
}
