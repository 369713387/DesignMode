using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.命令模式
{
    class Receiver
    {
        public void Action1()
        {
            Console.WriteLine("执行命令1");
        }
        public void Action2()
        {
            Console.WriteLine("执行命令2");
        }
        public void Action3()
        {
            Console.WriteLine("执行命令3");
        }
        public void Action4()
        {
            Console.WriteLine("执行命令4");
        }
    }
}
