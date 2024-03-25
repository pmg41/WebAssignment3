using System;
using System.Collections.Generic;

namespace WebAssignment3.Data;

public partial class Order
{
    public int Id { get; set; }

    public int? UserId { get; set; }

    public decimal? TotalAmount { get; set; }

    public DateTime OrderDate { get; set; }

    public virtual User? User { get; set; }
}
