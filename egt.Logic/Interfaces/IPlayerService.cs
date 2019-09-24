using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using egt.Logic.DataTransferObjects;

namespace egt.Logic.Interfaces
{
    public interface IPlayerService
    {
        ResultOperationInfo<IEnumerable<PlayerInfo>> GetAll();
        ResultOperationInfo<PlayerInfo> GetId(int id);
        ResultOperationInfo Add(PlayerInfo player);
        ResultOperationInfo Delete(int id);
        ResultOperationInfo<IEnumerable<EquipmentInfo>> GetPlayerEquipments(int id);
        ResultOperationInfo<IEnumerable<BuffInfo>> GetPlayerBuffs(int id);
    }
}
