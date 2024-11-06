using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class QuantityOfFish
{
    public string ElementId { get; set; } = null!;

    public string Description { get; set; } = null!;

    public virtual Element Element { get; set; } = null!;
}
