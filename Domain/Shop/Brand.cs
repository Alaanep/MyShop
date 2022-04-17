﻿using Abc.Data.Shop;
using Abc.Domain.Common;

namespace Abc.Domain.Shop {
    public sealed class Brand :NamedEntity<BrandData> {
        public Brand(BrandData d) : base(d) { }
    }
}
