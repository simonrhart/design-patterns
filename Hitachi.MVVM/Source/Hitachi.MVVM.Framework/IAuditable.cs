using System;

namespace Hitachi.MVVM.Framework
{
    public interface IAuditable
    {
        DateTime ChangedOn { get; set; }

        string ChangedBy { get; set; }

        DateTime CreatedOn { get; set; }

        string CreatedBy { get; set; }
    }
}
