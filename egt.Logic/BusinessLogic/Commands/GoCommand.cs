using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using egt.Logic.Services;
using egt.Logic.DataTransferObjects;

namespace egt.Logic.BusinessLogic.Commands
{
    class GoCommand: BaseCommand
    {
        private int Initiator;
        public GoCommand(int uid, string[] param)
            : base(param)
        {
            Name = "/go";
            Initiator = uid;
        }
        public override bool ProcessCommand(bool isRevert = false)
        {
            if (!isRevert)
            {
                try
                {
                    using (PlayerService db = new PlayerService())
                    {
                        PlayerInfo player = db.GetId(Initiator).Value;
                        player.IsBusy = true;
                        
                        db.Update(player);
                    }
                    return true;
                }
                catch (Exception e) { return false; }
            }
            return false;
        }
    }
}
