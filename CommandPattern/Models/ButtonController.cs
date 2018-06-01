using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;


namespace CommandPattern.Models
{
    public class ButtonController : ICommand 
    {
        KeyBinding keyBinding;
        public void Execute()
        {
            SetKeyBinding();
        }

        public void Undo()
        {

        }
        public KeyBinding SetKeyBinding()
        {
            keyBinding = new KeyBinding(
                    ApplicationCommands.Open,
                    Key.C,
                    ModifierKeys.Control
                
                );
            return keyBinding;
        }


        
    }
}
