﻿using System;
using System.Collections.Generic;

namespace Products.Domain.Model.Product;

public partial class Product
{
    public int TenantId { get; set; }

    public int ProductId { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public decimal? Price { get; set; }

    public int? ProductTypeId { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? DateCreated { get; set; }

    public bool? Active { get; set; }
}
