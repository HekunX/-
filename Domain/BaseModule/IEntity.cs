using System;

namespace Domain.BaseModule
{
    public interface IEntity
    {
        Guid Identity { get; set; }
    }
}
