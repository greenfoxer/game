using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using egt.Logic.Services;
using System.Threading;
using egt.Logic.DataTransferObjects;

namespace egt.Logic.BusinessLogic
{
    public class PlayerLogics
    {
        public PlayerLogics()
        { 
            
        }
        public void CureHealth(int id)
        {
            using (PlayerService db = new PlayerService())
            {
                PlayerInfo player = db.GetId(id).Value;
                player.CureHealth();
                db.Update(player);
            }
        }
    }
}
