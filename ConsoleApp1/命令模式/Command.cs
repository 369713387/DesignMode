using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.命令模式
{
    abstract class Command
    {
        protected Receiver receiver;

        public Command(Receiver receiver)
        {
            this.receiver = receiver;
        }

        public abstract void ExecutedCommand();
    }
}
