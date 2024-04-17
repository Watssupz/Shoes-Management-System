using System;
using System.Collections.Generic;

namespace project.Models
{
    public partial class Cart
    {
        public string Username { get; set; } = null!;
        public int ProductId { get; set; }
        public int Quantity { get; set; }

        public virtual Product Product { get; set; } = null!;
        public virtual Account UsernameNavigation { get; set; } = null!;
    }
}
