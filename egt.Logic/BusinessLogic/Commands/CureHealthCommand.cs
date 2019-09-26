using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using egt.Logic.Services;
using egt.Logic.DataTransferObjects;

namespace egt.Logic.BusinessLogic.Commands
{
    class CureHealthCommand: IGameCommand
    {
        public static string Name { get; set; }
        public readonly string[] Parameters;
        private int Initiator;
        public CureHealthCommand(int playerId, string[] param)
        {
            Parameters = param;
            Initiator = playerId;
            Id = Guid.NewGuid();
            Status = Status.Queued;
            Name = "/curehealth";
        }


        public void Execute()
        {
            Status = ProcessCommand() ? Status.ExecuteSucceded : Status.ExecuteFailed;
        }
        private bool ProcessCommand(bool isRevert = false)
        {
            if (!isRevert)
            {
                try
                {
                    using (PlayerService db = new PlayerService())
                    {
                        PlayerInfo player = db.GetId(Initiator).Value;
                        player.CureHealth();
                        db.Update(player);
                    }
                    return true;
                }
                catch (Exception e) { return false; }
            }
            return false;
        }
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
