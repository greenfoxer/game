using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using egt.Logic.DataTransferObjects;
using egt.Logic.Interfaces;
using AutoMapper;
using egt.Classes.Entities;
using egt.Classes.UnitOfWork;
/////https://github.com/IgorBozhok/DisTelegramBot
/////https://github.com/KyMback/YulBot
/////https://github.com/GABAnich/HotelTelegramBot
/////https://github.com/tarnenok/school-bot
/////https://airbrake.io/blog/design-patterns/behavioral-command-design-pattern
namespace egt.Logic.Services
{
    public class PlayerService : BaseService, IPlayerService, IDisposable
    {
        private MapperConfiguration _mapperConfiguration;
        public IMapper MapperInstance;
        protected virtual Action<IMapperConfigurationExpression> MapperCustomConfiguration { get; set; }
        //internal IUnitOfWork UnitOfWork { get; set; }
        public PlayerService()
            :base()
        {
            //UnitOfWork = new UnitOfWork();
            MapperCustomConfiguration =  MapperCustomConfiguration = cfg =>
             {
                 cfg.CreateMap<Player, PlayerInfo>()
                 .ReverseMap();
             };
            MapperInitialize();
            MapperInstance = _mapperConfiguration.CreateMapper();
        }
        private void MapperInitialize()
        {
            _mapperConfiguration = new MapperConfiguration(MapperCustomConfiguration);
        }

        //protected Action<IMapperConfigurationExpression> MapperCustomConfiguration;
        
        //public PlayerService():
        //    base()
        //{ 
        //     UnitOfWork = new UnitOfWork();
        //    MapperInitialize();
        //    MapperInstance = _mapperConfiguration.CreateMapper();
        //    MapperCustomConfiguration = cfg => { };
        //    MapperCustomConfiguration = cfg =>
        // {
        //     cfg.CreateMap<Player, PlayerInfo>()
        //     .ReverseMap();
        // };
        //}
        public ResultOperationInfo<IEnumerable<PlayerInfo>> GetAll()
        {
            var collection = UnitOfWork.GetRepository<Player>().GetAll();
            var collectionInfo = MapperInstance.Map<IEnumerable<Player>, IEnumerable<PlayerInfo>>(collection);
            return new ResultOperationInfo<IEnumerable<PlayerInfo>>(collectionInfo, true, "OK");
        }

        public ResultOperationInfo<PlayerInfo> GetId(int id)
        {
            var item = UnitOfWork.GetRepository<Player>().Get(id);
            var itemInfo = MapperInstance.Map<Player, PlayerInfo>(item);
            return new ResultOperationInfo<PlayerInfo>(itemInfo, true, "OK");
        }

        public ResultOperationInfo Add(PlayerInfo player)
        {
            var item = MapperInstance.Map<PlayerInfo, Player>(player);
            var addedItem = UnitOfWork.GetRepository<Player>().Add(item);
            return addedItem == null
                ? new ResultOperationInfo(false, "FAIL")
                : new ResultOperationInfo(true, "OK");
        }

        public ResultOperationInfo Delete(int id)
        {
            throw new NotImplementedException();
        }
        public ResultOperationInfo Update(PlayerInfo itemInfo)
        {
            var item = MapperInstance.Map<PlayerInfo, Player>(itemInfo);
            var updatedItem = UnitOfWork.GetRepository<Player>().Update(item, item.Id);
            return updatedItem == null
                ? new ResultOperationInfo(false, "FAIL")
                : new ResultOperationInfo(true, "OK");
        }

        public ResultOperationInfo<IEnumerable<EquipmentInfo>> GetPlayerEquipments(int id)
        {
            throw new NotImplementedException();
        }

        public ResultOperationInfo<IEnumerable<BuffInfo>> GetPlayerBuffs(int id)
        {
            throw new NotImplementedException();
        }
    }
}
