using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace egt.Logic.BusinessLogic.Commands
{
    public enum Status
    { 
        ExecuteFailed,
        ExecuteSucceded,
        Queued,
        RevertFailed,
        RevertSucceded
    }
}
