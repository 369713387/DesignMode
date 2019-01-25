using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.职责链模式
{
    class ConcreteHandler1 : Handle
    {
        public ConcreteHandler1()
        {

        }
        public ConcreteHandler1(Handle handle) : base(handle)
        {
        }

        public override void ExecutedRequest(Request request)
        {
            if (request.Priority.Equals("Low"))
            {
                //处理该请求
                Console.WriteLine("ConcreteHandler1 + 优先级 ：{0} ，请求者 ：{1}，请求内容 ：{2}。", request.Priority,request.Username,request.Content);
            }
            else
            {
                //将同一个请求传递给下一个处理者处理
                if (handle != null)
                {
                    handle.ExecutedRequest(request);
                }
            }
        }
    }
}
