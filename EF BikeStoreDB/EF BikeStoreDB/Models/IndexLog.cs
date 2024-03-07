using System;
using System.Collections.Generic;

namespace EF_BikeStoreDB.Models;

public partial class IndexLog
{
    public int LogId { get; set; }

    public string EventData { get; set; } = null!;

    public string ChangedBy { get; set; } = null!;
}
