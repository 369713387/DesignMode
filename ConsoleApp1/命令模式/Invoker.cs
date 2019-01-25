using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.命令模式
{
    class Invoker
    {
        private List<Command> commands = new List<Command>();

        public Invoker()
        {

        }

        public void AddCommand(Command command)
        {
            commands.Add(command);
        }

        public void RemoveCommand(Command command)
        {
            commands.Remove(command);
        }

        public void Notify()
        {
            foreach (Command cm in commands)
            {
                cm.ExecutedCommand();
            }
        }

    }
}
