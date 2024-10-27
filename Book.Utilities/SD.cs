﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Utilities
{
    public static class SD
    {
        public static string AdminRole = "Admin"; 
        public static string EditorRole = "Editor"; 
        public static string CustomerRole = "Customer";

        // stripe

        public const string Pending = "Pending";
        public const string Approve = "Approved";
        public const string Proccessing = "Proccessing";
        public const string Cancelled = "Cancelled";
        public const string Shipped = "Shipped";
        public const string Refund = "Refund";
        public const string Rejected = "Rejected";

        public const string SessionKey = "ShoppingCartSession";
    }
}
