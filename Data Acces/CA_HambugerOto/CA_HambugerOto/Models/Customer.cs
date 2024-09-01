using System;
using System.Collections.Generic;

namespace CA_HambugerOto.Models;

public partial class Customer
{
    public int Id { get; set; }

    public int OrderId { get; set; }

    public string Name { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string? Adress { get; set; }

    public string? Country { get; set; }

    public virtual Order Order { get; set; } = null!;
}
