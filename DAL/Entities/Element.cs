using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class Element
{
    public string ElementId { get; set; } = null!;

    public string Mutualism { get; set; } = null!;

    public virtual ICollection<Advertisement> Advertisements { get; set; } = new List<Advertisement>();

    public virtual ICollection<ElementColor> ElementColors { get; set; } = new List<ElementColor>();

    public virtual ICollection<PointOfShape> PointOfShapes { get; set; } = new List<PointOfShape>();

    public virtual QuantityOfFish? QuantityOfFish { get; set; }
}
