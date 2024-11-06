using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class AdsPackage
{
    public string AdId { get; set; } = null!;

    public string Rank { get; set; } = null!;

    public DateOnly StartDate { get; set; }

    public DateOnly ExpiredDate { get; set; }

    public int Quantity { get; set; }

    public double Total { get; set; }

    public DateOnly CreateAt { get; set; }

    public virtual Advertisement Ad { get; set; } = null!;

    public virtual Package RankNavigation { get; set; } = null!;
}
