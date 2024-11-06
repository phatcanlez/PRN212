using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class Member
{
    public string Name { get; set; } = null!;

    public DateOnly Birthday { get; set; }

    public string UserId { get; set; } = null!;

    public virtual ICollection<Advertisement> Advertisements { get; set; } = new List<Advertisement>();

    public virtual ICollection<Feedback> Feedbacks { get; set; } = new List<Feedback>();

    public virtual Account User { get; set; } = null!;
}
