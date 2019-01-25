using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.命令模式
{
    class ConcreteCommandC : Command
    {
        public ConcreteCommandC(Receiver receiver) : base(receiver)
        {
        }

        public override void ExecutedCommand()
        {
            receiver.Action3();
        }
    }
}
