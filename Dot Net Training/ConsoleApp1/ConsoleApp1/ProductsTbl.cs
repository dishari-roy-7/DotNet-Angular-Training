using System;
using System.Collections.Generic;

namespace ConsoleApp1;

public partial class ProductsTbl
{
    public int? OrderId { get; set; }

    public string? ProductName { get; set; }

    public int? Quantity { get; set; }

    public double? Price { get; set; }

    public virtual OrdersTbl? Order { get; set; }
}
