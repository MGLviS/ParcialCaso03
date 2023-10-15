using System;
using System.Collections.Generic;

namespace DPA202302ParcialCaso0322101571.Entities;

public partial class Territory
{
    public int Id { get; set; }

    public string? Description { get; set; }

    public int? Area { get; set; }

    public int? Population { get; set; }
}
