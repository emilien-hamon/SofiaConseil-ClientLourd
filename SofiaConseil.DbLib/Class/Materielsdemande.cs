using System;
using System.Collections.Generic;

namespace SofiaConseil.DbLib.Class;

public partial class Materielsdemande
{
    public long Id { get; set; }

    public long IdDemandes { get; set; }

    public long IdMateriels { get; set; }

    public string? RememberToken { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual Demande IdDemandesNavigation { get; set; } = null!;

    public virtual Materiel IdMaterielsNavigation { get; set; } = null!;
}
