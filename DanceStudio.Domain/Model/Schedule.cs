using System;
using System.Collections.Generic;

namespace DanceStudio.Domain.Model;

public partial class Schedule
{
    public int Id { get; set; }

    public int? DayOfWeek { get; set; }

    public DateTimeOffset? StartTime { get; set; }

    public int? RoomNumber { get; set; }
}
