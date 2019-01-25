using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.观察者模式
{
    //abstract class Subject
    //{
    //    private IList<Observer> observers = new List<Observer>();

    //    /// <summary>
    //    /// 增加观察者
    //    /// </summary>
    //    /// <param name="observer"></param>
    //    public void Attach(Observer observer)
    //    {
    //        observers.Add(observer);
    //    }

    //    /// <summary>
    //    /// 移除观察者
    //    /// </summary>
    //    /// <param name="observer"></param>
    //    public void Detach(Observer observer)
    //    {
    //        observers.Remove(observer);
    //    }

    //    /// <summary>
    //    /// 通知
    //    /// </summary>
    //    public void Notify()
    //    {
    //        foreach (Observer ob in observers)
    //        {                
    //            ob.Update();
    //        }
    //    }

    //}

    

    interface Subject
    {
        void Notify(str_EventArgs e);
    }
}
