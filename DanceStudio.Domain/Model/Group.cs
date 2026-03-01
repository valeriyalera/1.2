using System;
using System.Collections.Generic;

namespace DanceStudio.Domain.Model;

public partial class Group
{
    public int Id { get; set; }

    public int? StyleId { get; set; }

    public int? AgeId { get; set; }

    public string? Level { get; set; }
}
