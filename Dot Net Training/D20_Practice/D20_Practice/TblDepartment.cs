using System;
using System.Collections.Generic;

namespace D20_Practice;

public partial class TblDepartment
{
    public int Id { get; set; }

    public string DepartmentName { get; set; } = null!;

    public string Location { get; set; } = null!;

    public string DepartmentHead { get; set; } = null!;

    public virtual ICollection<TblEmployee> TblEmployees { get; set; } = new List<TblEmployee>();
}
