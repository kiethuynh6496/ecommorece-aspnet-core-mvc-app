using TicketBooking.Data.Base;
using TicketBooking.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TicketBooking.Data.Services
{
    public interface IActorsService : IEntityBaseRepository<Actor>
    {
    }
}
