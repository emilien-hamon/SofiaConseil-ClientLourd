using System;
using System.Collections.Generic;

namespace SofiaConseil.DbLib.Class;

public partial class Competfree
{
    public long Id { get; set; }

    public long IdDemandes { get; set; }

    public long IdCompetences { get; set; }

    public string? RememberToken { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual Competence IdCompetencesNavigation { get; set; } = null!;

    public virtual Demande IdDemandesNavigation { get; set; } = null!;
}
