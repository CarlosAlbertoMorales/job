using System;

namespace Job.common.Models
{
    public class Job
    {
        public DateTime CreateTime { get; set; }

        public string TasDescripcion { get; set; }

        public bool IsCompleted { get; set; }
    }
}
