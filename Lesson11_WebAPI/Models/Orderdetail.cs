using System;
using System.Collections.Generic;

namespace Lesson11_WebAPI.Models;

public partial class Orderdetail
{
    public int Id { get; set; }

    public int OrderId { get; set; }

    public int ProductId { get; set; }

    public int Quantity { get; set; }

    public float Price { get; set; }
}
