using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTaskPatterns
{
    class Sender
    {
        Command _command;
        public void SetCommand(Command command)
        {
            _command = command;
        }
        public async Task Start() 
        {
            await _command.Start();
        }
    }
}
