using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class KoiVariety
{
    public string KoiType { get; set; } = null!;

    public string Image { get; set; } = null!;

    public string Element { get; set; } = null!;

    public string Description { get; set; } = null!;

    public virtual ICollection<TypeColor> TypeColors { get; set; } = new List<TypeColor>();
}
