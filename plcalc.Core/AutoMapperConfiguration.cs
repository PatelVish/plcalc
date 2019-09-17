using AutoMapper;
using plcalc.Core.Dto;
using plcalc.DataAccess.Model;

namespace plcalc.Core
{
    public static class AutoMapperConfiguration
    {
        public static bool Initialized { get; private set; }

        private static Mapper _mapper;
        private static MapperConfiguration _config;
        public static Mapper Instance
        {
            get
            {
                if(_mapper == null)
                    Configure();

                _mapper = new Mapper(_config);
                return _mapper;
            }
        }

        static AutoMapperConfiguration()
        {
            Initialized = false;
        }

        public static void Configure()
        {
            if (Initialized)
                return;

            _config = new MapperConfiguration(cfg => {
                cfg.CreateMap<Transaction, TransactionDto>().ReverseMap();
            });

        }
    }
}
