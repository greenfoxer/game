using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using egt.Classes.UnitOfWork;

namespace egt.Logic.Services
{
    public class BaseService: IDisposable
    {
        //private MapperConfiguration _mapperConfiguration;
        //public IMapper MapperInstance;
        //protected virtual Action<IMapperConfigurationExpression> MapperCustomConfiguration { get; set; }
        internal IUnitOfWork UnitOfWork { get; set; }
        public BaseService()
        {
            UnitOfWork = new UnitOfWork();
        //    MapperInitialize();
        //    MapperInstance = _mapperConfiguration.CreateMapper();
        //    MapperCustomConfiguration = cfg => { };
        }
        //private void MapperInitialize()
        //{
        //    _mapperConfiguration = new MapperConfiguration(MapperCustomConfiguration);
        //}

        public void Dispose()
        {
            UnitOfWork.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
