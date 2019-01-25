using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.命令模式
{
    class ConcreteCommandD : Command
    {
        public ConcreteCommandD(Receiver receiver) : base(receiver)
        {
        }

        public override void ExecutedCommand()
        {
            receiver.Action4();
        }
    }
}
