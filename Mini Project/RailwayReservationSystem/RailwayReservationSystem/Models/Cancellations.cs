﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RailwayReservationSystem.Models
{
    public class Cancellation
    {
        public int CancellationId { get; set; }
        public int BookingId { get; set; }
        public int SeatsCancelled { get; set; }
        public DateTime CancellationDate { get; set; }
    }
}
