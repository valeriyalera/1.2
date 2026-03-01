using System;
using System.Collections.Generic;

namespace DanceStudio.Domain.Model;

public partial class Subscription
{
    public int Id { get; set; }

    public int? UserId { get; set; }

    public int? TotalLessons { get; set; }

    public int? RemainingLessons { get; set; }
}
