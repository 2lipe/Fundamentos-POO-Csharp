using POO.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace POO.SubscriptionContext
{
    public class Subscription : Base
    {
        public static bool Any { get; internal set; }
        public Plan Plan { get; set; }
        public DateTime? EndDate { get; set; }
        public bool IsInactive => EndDate <= DateTime.Now;
    }
}
