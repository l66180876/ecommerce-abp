﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.Admin.Products
{
    public class ProductListFilterDto : BaseListFilterDto
    {
        public Guid? CategoryId { get; set; }
    }
}
