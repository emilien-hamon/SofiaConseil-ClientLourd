using System;
using System.Collections.Generic;

namespace SofiaConseil.DbLib.Class;

public partial class Competence
{
    public long Id { get; set; }

    public string Nom { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string? RememberToken { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual ICollection<Competdemande> Competdemandes { get; set; } = new List<Competdemande>();

    public virtual ICollection<Competfree> Competfrees { get; set; } = new List<Competfree>();
}
