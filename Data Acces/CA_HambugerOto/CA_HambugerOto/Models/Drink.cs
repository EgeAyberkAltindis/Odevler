using System;
using System.Collections.Generic;

namespace CA_HambugerOto.Models;

public partial class Drink
{
    public int Id { get; set; }

    public string DrinkName { get; set; } = null!;

    public bool? Sweetie { get; set; }

    public int? Litter { get; set; }

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
