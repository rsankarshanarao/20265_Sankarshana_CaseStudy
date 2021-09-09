using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Entities.Models;

namespace JobTrackingSystem_Server.Data
{
    public class JobTrackingSystem_ServerContext : DbContext
    {
        public JobTrackingSystem_ServerContext (DbContextOptions<JobTrackingSystem_ServerContext> options)
            : base(options)
        {
        }

        public DbSet<Entities.Models.User> User { get; set; }

        public DbSet<Entities.Models.Job> Job { get; set; }
    }
}
