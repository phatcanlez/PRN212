using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class Color
{
    public string ColorId { get; set; } = null!;

    public virtual ICollection<ElementColor> ElementColors { get; set; } = new List<ElementColor>();

    public virtual ICollection<TypeColor> TypeColors { get; set; } = new List<TypeColor>();
}
