using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class Direction
{
    public string DirectionId { get; set; } = null!;

    public virtual ICollection<LifePalaceDirection> LifePalaceDirections { get; set; } = new List<LifePalaceDirection>();
}
