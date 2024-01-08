using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.Public
{
    public class BaseListFilterDto : PagedResultRequestBase
    {
        public string Keyword { get; set; }
    }
}
