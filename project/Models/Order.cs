using System;
using System.Collections.Generic;

namespace project.Models
{
    public partial class Order
    {
        public Order()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }

        public int OrderId { get; set; }
        public string Username { get; set; } = null!;
        public DateTime OrderDate { get; set; }
        public string Location { get; set; } = null!;
        public int Status { get; set; }
        public decimal? TotalBill { get; set; }

        public virtual Account UsernameNavigation { get; set; } = null!;
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
