using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using tema1.DataAccess.Model;
using tema1.BusinessLogic.Model;
using tema1.DataAccess;


namespace tema1.BusinessLogic
{
    class EventService
    {
        protected Mapper IMapper;

        public AutoMapper.IMapper setupMapper<T, U>()
        {
            var config = new MapperConfiguration(cfg =>
            {

                cfg.CreateMap<T, U>();

            });
            var mapper = config.CreateMapper();
            return mapper;
        }

        public EventDTO ModelToDTO(EventModel show)
        {
            var converted = setupMapper<EventModel, EventDTO>().Map<EventDTO>(show);
            return converted;
        }

        public Boolean createEvent(DateTime date, string artists, int seats)
        {
            EventRepo show = new EventRepo();
            return show.insertShow(date, artists, seats);
        }

        public Boolean updateEvent(int Id, DateTime date, string artists, int seats)
        {
            EventRepo show = new EventRepo();
            Boolean res = show.updateEvent(Id, date, artists, seats);
            return res;
        }
    }
}
