using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mvc5IdentityExample.Web.Models
{
    public class BootGridResponse<TEntity> where TEntity : class
    {
        public int current { get; set; }

        public int rowCount { get; set; }

        public List<TEntity> rows { get; set; }

        public int total { get; set; }

        public string msg { get; set; }

        public BootGridResponse()
        {
            rows = new List<TEntity>();
        }
    }
}