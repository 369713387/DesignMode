using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.职责链模式
{
    class ConcreteHandler3 : Handle
    {
        public ConcreteHandler3()
        {

        }
        public ConcreteHandler3(Handle handle) : base(handle)
        {
        }

        public override void ExecutedRequest(Request request)
        {
            //最高权限，处理所有请求
            Console.WriteLine("ConcreteHandler3 + 优先级 ：{0} ，请求者 ：{1}，请求内容 ：{2}。", request.Priority, request.Username, request.Content);
        }
    }
}
