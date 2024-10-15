using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class Shape
{
    public string ShapeId { get; set; } = null!;

    public string Image { get; set; } = null!;

    public virtual ICollection<PointOfShape> PointOfShapes { get; set; } = new List<PointOfShape>();
}
