﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tema1.DataAccess.Model
{
    class TicketDTO
    {
        public int Id { get; set; }
        public int ConcertId { get; set; }
        public int Seat { get; set; }
    }
}
