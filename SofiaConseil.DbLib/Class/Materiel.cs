using System;
using System.Collections.Generic;

namespace SofiaConseil.DbLib.Class;

public partial class Materiel
{
    public long Id { get; set; }

    public string Nom { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string AdMac { get; set; } = null!;

    public string? RememberToken { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual ICollection<Materielsdemande> Materielsdemandes { get; set; } = new List<Materielsdemande>();
}
