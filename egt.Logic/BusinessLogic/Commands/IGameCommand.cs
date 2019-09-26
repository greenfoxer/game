using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace egt.Logic.BusinessLogic.Commands
{
    public interface IGameCommand
    {
        void Execute();
        Guid Id { get; set; }
        void Revert();
        Status Status { get; set; }
        bool IsMatch(string cmd ,int num);
    }
}
