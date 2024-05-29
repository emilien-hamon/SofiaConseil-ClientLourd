using System;
using System.Collections.Generic;

namespace SofiaConseil.DbLib.Class;

public partial class Freelance
{
    public long Id { get; set; }

    public string Nom { get; set; } = null!;

    public string Experience { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string? RememberToken { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }
}
