using System;
using System.Collections.Generic;

namespace DanceStudio.Domain.Model;

public partial class Payment
{
    public int Id { get; set; }

    public int? BookingId { get; set; }

    public int? Amount { get; set; }

    public string? PaymentMethod { get; set; }

    public string? Status { get; set; }

    public DateOnly? PaymentDate { get; set; }
}
