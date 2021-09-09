using Contracts.JobRepository;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Services
{
    class JobRepository : IJobRepository
    {
        //public static List<Job> Jobs { get; set; }
        public List<Job> CreateJob(Job j)
        {
            throw new NotImplementedException();
        }

        public Job DeleteJob(int id)
        {
            throw new NotImplementedException();
        }

        public Job EditJob(int id, Job j)
        {
            throw new NotImplementedException();
        }

        public List<Job> GetAllJob()
        {
            throw new NotImplementedException();
        }

        public Job GetJob(int id)
        {
            throw new NotImplementedException();
        }
    }
}
