﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsEcommerce
{
    public class CPayment
    {
        public int PaymentId { get; set; }

        public string PaymentMethod { get; set; }

        public string PaymentStatus { get; set; }

        public int OrderId { get; set; }
    }
}
