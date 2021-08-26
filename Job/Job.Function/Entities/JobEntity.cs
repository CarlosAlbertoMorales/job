using Microsoft.WindowsAzure.Storage.Table;
using System;
using System.Collections.Generic;
using System.Text;

namespace Job.Function.Entities
{
    public class JobEntity : TableEntity
    {
        public DateTime CreatedTime { get; set; }

        public string taskDescription { get; set; }

        public bool IsCompleted { get; set; }



    }
}
