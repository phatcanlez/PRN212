using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class Advertisement
{
    public string AdId { get; set; } = null!;

    public string Heading { get; set; } = null!;

    public string Image { get; set; } = null!;

    public string Link { get; set; } = null!;

    public string UserId { get; set; } = null!;

    public string? ElementId { get; set; }

    public string Status { get; set; } = null!;

    public virtual ICollection<AdsPackage> AdsPackages { get; set; } = new List<AdsPackage>();

    public virtual Element? Element { get; set; }

    public virtual ICollection<Feedback> Feedbacks { get; set; } = new List<Feedback>();

    public virtual Member User { get; set; } = null!;
}
