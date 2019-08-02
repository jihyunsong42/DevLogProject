using devloggerWebAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace devloggerWebAPI.Data
{
    public class DevLogDbContext:DbContext
    {
        public DevLogDbContext(DbContextOptions<DevLogDbContext> options):base (options)
        {

        }
        public DbSet<DevLog> DevLogs { get; set; }

    }
}
