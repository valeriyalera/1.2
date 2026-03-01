using System;
using System.Collections.Generic;

namespace DanceStudio.Domain.Model;

public partial class Cancellation
{
    public int Id { get; set; }

    public int? UserId { get; set; }

    public int? ScheduleId { get; set; }

    public int? Reason { get; set; }
}
