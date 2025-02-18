﻿using System;
using System.Collections.Generic;

namespace Restaurant.Core.Models
{
    public class FullOrder
    {
        public int Id { get; set; }
        public string AppUserId { get; set; }
        public AppUser AppUser { get; set; }
        public double Total { get; set; }
        public string BillingAdress { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Status { get; set; }
        public List<Order> Orders { get; set; }
    }
}
