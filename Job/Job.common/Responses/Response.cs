using System;
using System.Collections.Generic;
using System.Text;

namespace Job.common.Responses
{
   public class Response
    {
        public bool IsSuccess { get; set; }

        public string message { get; set; }

        public object Result { get; set; }

    }
}
