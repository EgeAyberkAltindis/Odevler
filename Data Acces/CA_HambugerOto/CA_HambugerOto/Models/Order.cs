using System;
using System.Collections.Generic;

namespace CA_HambugerOto.Models;

public partial class Order
{
    public int Id { get; set; }

    public int ProcutId { get; set; }

    public DateTime? OrderDate { get; set; }

    public decimal? Quantity { get; set; }

    public int? UnitStock { get; set; }

    public virtual ICollection<Customer> Customers { get; set; } = new List<Customer>();

    public virtual Product Procut { get; set; } = null!;
}
