using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tema1.DataAccess.Model
{
    class EventDTO
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Artists { get; set; }
        public int NrOfTickets { get; set; }
    }
}
