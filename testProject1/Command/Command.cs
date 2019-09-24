using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testProject1.Command
{
    public abstract class Command
    {
        public abstract string Name { get; }
        public abstract void Execute(string message, string client);
        public bool Contains(string command)
        {
            return command.Contains(this.Name);
        }
    }
}
