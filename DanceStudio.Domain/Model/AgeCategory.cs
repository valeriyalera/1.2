using System;
using System.Collections.Generic;

namespace DanceStudio.Domain.Model;

public partial class AgeCategory
{
    public int Id { get; set; }

    public string? Title { get; set; }

    public int? MinAge { get; set; }

    public int? MaxAge { get; set; }
}
