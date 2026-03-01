using System;
using System.Collections.Generic;

namespace DanceStudio.Domain.Model;

public partial class User
{
    public int Id { get; set; }

    public string? FullName { get; set; }

    public DateOnly? BirthDate { get; set; }
}
