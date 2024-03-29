﻿using System;
using System.Collections.Generic;
using System.Text;

namespace eShop.ViewModels.Common
{
    public class PagingRequestBase
    {
        public int PageIndex { get; set; }
        public int PageSize { get; set; }

        public PagingRequestBase()
        {
            PageIndex = 1;
            PageSize = 10;
        }
    }
}