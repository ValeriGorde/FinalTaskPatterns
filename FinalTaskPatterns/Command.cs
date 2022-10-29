using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTaskPatterns
{
    abstract class Command
    {
        abstract public Task Start();
    }
}
