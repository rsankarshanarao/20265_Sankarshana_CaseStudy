using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using JobTracking.Models;

namespace JobTracking.Data
{
    public class JobTrackingContext : DbContext
    {
        public JobTrackingContext (DbContextOptions<JobTrackingContext> options)
            : base(options)
        {
        }

        public DbSet<JobTracking.Models.Task> Task { get; set; }

        public DbSet<JobTracking.Models.User> User { get; set; }
    }
}
