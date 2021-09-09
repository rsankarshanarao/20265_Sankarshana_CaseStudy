using Entities.Models;
using System;
using System.Collections.Generic;

namespace Contracts.JobRepository
{
    public interface IJobRepository
    {
        public List<Job> GetAllJob();
        public Job GetJob(int id);
        public List<Job> CreateJob(Job j);
        public Job EditJob(int id, Job j);
        public Job DeleteJob(int id);
    }
}
