﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Flight_n_Bite_API.Model
{
    public interface IOrderLineRepository
    {
        List<OrderLine> GetOrderLines();
        OrderLine GetOrderLineById(int id);
        void Add(OrderLine orderLine);
        void SaveChanges();
    }
}