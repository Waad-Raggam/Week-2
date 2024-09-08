using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo9
{
    public class BaseEntity
    {
        // the common things from children
        public Guid Id;
        public string Name { get; set; }
        public DateTime CreatedAtThisYear { get; set; }

    }
}