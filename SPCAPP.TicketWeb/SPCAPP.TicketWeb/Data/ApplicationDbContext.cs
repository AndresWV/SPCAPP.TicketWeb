using Microsoft.EntityFrameworkCore;
using SPCAPP.TicketWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SPCAPP.TicketWeb.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Tickett> Tickett { get; set; }
    }
}
