using System;
using System.Collections.Generic;

namespace HamburgerOto.Models;

public partial class Product
{
    public int Id { get; set; }

    public int SauceId { get; set; }

    public int DrinkId { get; set; }

    public string? MenuName { get; set; }

    public virtual Drink Drink { get; set; } = null!;

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();

    public virtual Sauce Sauce { get; set; } = null!;
}
