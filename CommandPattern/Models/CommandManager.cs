using CommandPattern.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    //Invoker
    public class CommandManager 
    {
        private Stack<ICommand> commandStack = new Stack<ICommand>();

        public void ExecuteCommand(ICommand cmd)
        {
           
            cmd.Execute();
            if (cmd is ICommand)
            {
                commandStack.Push(cmd);
            }
        }

        public void Undo()
        {
            if (commandStack.Count > 0)
            {
                ICommand cmd = (ICommand)commandStack.Pop();
                cmd.Undo();
            }
        }
    }
}
