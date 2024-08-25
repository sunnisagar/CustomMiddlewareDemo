using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomMiddlewareDemo.Models
{
    public class ExceptionModel
    {
        public string HttpMethod { get; set; }
        public string QueryStringValue { get; set; }
        public string RequestBody { get; set; }
        public string ExceptionMessage { get; set; }
        public string ExceptionStackSTrace { get; set; }
        public string InnerExceptionMessage { get; set; }
        public string InnerExceptionStackTrace { get; set; }
    }
}
