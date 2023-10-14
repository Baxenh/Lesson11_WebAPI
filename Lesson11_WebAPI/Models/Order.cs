using System;
using System.Collections.Generic;

namespace Lesson11_WebAPI.Models;

public partial class Order
{
    public int Id { get; set; }

    public int CustomerId { get; set; }

    public string Name { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Address { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public byte Status { get; set; }
}
