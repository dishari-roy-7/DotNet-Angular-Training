﻿using System;
using System.Collections.Generic;

namespace D20_Practice;

public partial class CustomerTbl
{
    public int CustomerId { get; set; }

    public string CustomerName { get; set; } = null!;

    public string City { get; set; } = null!;

    public virtual ICollection<OrdersTbl> OrdersTbls { get; set; } = new List<OrdersTbl>();
}