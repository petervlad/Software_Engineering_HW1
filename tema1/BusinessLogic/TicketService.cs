using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using tema1.DataAccess.Model;
using tema1.DataAccess;
using tema1.BusinessLogic.Model;

namespace tema1.BusinessLogic
{
    class TicketService
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

        public TicketDTO ModelToDTO(TicketModel ticket)
        {
            var converted = setupMapper<TicketModel, TicketDTO>().Map<TicketDTO>(ticket);
            return converted;
        }

        public Boolean updateTicket(int seat, int ticketId)
        {
            Boolean result;

            TicketRepo ticket = new TicketRepo();
            result = ticket.updateTicket(seat, ticketId);

            return result;
        }
        public List<TicketModel> getTicketsForConcert(int concertId)
    {
                        TicketRepo ticketRepo = new TicketRepo();

                        var tickets = ticketRepo.getTicketsForConcert(concertId);
                        var mapper = this.setupMapper<TicketDTO, TicketModel>();
                        var filteredTickets = tickets.Select(x=>mapper.Map<TicketModel>(x)).ToList();
                        return filteredTickets;
    }
        public Boolean sellTicket(int concertId, int seat)
        {
            Boolean result;

            TicketRepo ticket = new TicketRepo();
            result = ticket.sellTicket(concertId, seat);

            return result;
        }
    }
}
