using System;
using System.Collections.Generic;

namespace D20_Practice;

public partial class TblEmployee
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Gender { get; set; } = null!;

    public decimal Salary { get; set; }

    public int? DepartmentId { get; set; }

    public virtual TblDepartment? Department { get; set; }
}
