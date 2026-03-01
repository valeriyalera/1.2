using System;
using System.Collections.Generic;

namespace DanceStudio.Domain.Model;

public partial class Booking
{
    public int Id { get; set; }

    public int? UserId { get; set; }

    public int? ScheduleId { get; set; }

    public string? Status { get; set; }

    public int? PaymentId { get; set; }
}
