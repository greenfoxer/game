using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace egt.Logic.BusinessLogic.Commands
{
    class BaseCommand
    {
        public static string Name { get; set; }
        public readonly string[] Parameters;
        public BaseCommand(string[] param)
        {
            Parameters = param;
            Id = Guid.NewGuid();
            Status = Status.Queued;
        }
        public void Execute()
        {
            Status = ProcessCommand() ? Status.ExecuteSucceded : Status.ExecuteFailed;
        }
        public virtual bool ProcessCommand(bool isRevert = false) { return false; }
        public Guid Id { get; set; }

        public void Revert()
        {
            Status = ProcessCommand(true) ? Status.ExecuteSucceded : Status.ExecuteFailed;
        }
        public bool IsMatch(string cmd, int num)
        {
            return (cmd == Name) && (num == NumOfParam);
        }
        public int NumOfParam { get; set; }
        public Status Status { get; set; }
        public bool IsMatch()
        {
            throw new NotImplementedException();
        }
    }
}
