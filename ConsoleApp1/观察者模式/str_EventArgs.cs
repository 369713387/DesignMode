using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.观察者模式
{
    public class str_EventArgs:EventArgs
    {
        public readonly string name;

        public str_EventArgs(string name)
        {
            this.name = name;
        }

    }
}
