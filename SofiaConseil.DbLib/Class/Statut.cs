using System;
using System.Collections.Generic;

namespace SofiaConseil.DbLib.Class;

public partial class Statut
{
    public long Id { get; set; }

    public string Statut1 { get; set; } = null!;

    public string? RememberToken { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual ICollection<Demande> Demandes { get; set; } = new List<Demande>();
}
