﻿using System;
using System.Collections.Generic;

namespace CA_NortwindVeriTabanı.Models;

public partial class ProductsAboveAveragePrice
{
    public string ProductName { get; set; } = null!;

    public decimal? UnitPrice { get; set; }
}
