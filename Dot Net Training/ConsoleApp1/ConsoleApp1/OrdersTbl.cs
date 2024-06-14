using System;
using System.Collections.Generic;

namespace ConsoleApp1;

public partial class OrdersTbl
{
    public int OrderId { get; set; }

    public int? CustomerId { get; set; }

    public DateTime? OrderDate { get; set; }

    public double? TotalAmt { get; set; }

    public virtual CustomerTbl? Customer { get; set; }
}
