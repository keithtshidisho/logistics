﻿using FasTnT.Model.Events.Enums;

namespace FasTnT.Domain.Data.Model.Filters
{
    public class SimpleParameterFilter
    {
        public EpcisField Field { get; set; }
        public object[] Values { get; set; }
    }
}
