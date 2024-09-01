using System;
using System.Collections.Generic;

namespace CA_HambugerOto.Models;

public partial class Sauce
{
    public int Id { get; set; }

    public string SauceName { get; set; } = null!;

    public int? Freight { get; set; }

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
