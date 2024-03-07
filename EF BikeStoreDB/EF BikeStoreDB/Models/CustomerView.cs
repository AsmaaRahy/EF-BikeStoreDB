using System;
using System.Collections.Generic;

namespace EF_BikeStoreDB.Models;

public partial class CustomerView
{
    public string CategoryName { get; set; } = null!;

    public string? Num { get; set; }
}
