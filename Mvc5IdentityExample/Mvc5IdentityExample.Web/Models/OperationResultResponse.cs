using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mvc5IdentityExample.Web.Models
{
    public class OperationResultResponse
    {
        public bool IsError { get; set; }
        public List<string> Messages { get; set; }

        public OperationResultResponse()
        {
            IsError = true;
            Messages = new List<string>();
        }
    }
}