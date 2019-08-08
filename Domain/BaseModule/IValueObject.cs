using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.BaseModule
{
    public interface IValueObject
    {
         Guid RowId { get; set; }
    }
}
