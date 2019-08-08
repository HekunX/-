using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.BaseModule
{
    public abstract class AggregateRoot : IAggregateRoot
    {
        public abstract Guid Identity { get; set; }
    }
}
