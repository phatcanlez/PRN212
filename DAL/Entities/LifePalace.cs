using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class LifePalace
{
    public string LifePalaceId { get; set; } = null!;

    public virtual ICollection<LifePalaceDirection> LifePalaceDirections { get; set; } = new List<LifePalaceDirection>();
}
