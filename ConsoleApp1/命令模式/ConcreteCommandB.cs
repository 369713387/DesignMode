using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.命令模式
{
    class ConcreteCommandB : Command
    {
        public ConcreteCommandB(Receiver receiver) : base(receiver)
        {
        }

        public override void ExecutedCommand()
        {
            receiver.Action2();
        }
    }
}
