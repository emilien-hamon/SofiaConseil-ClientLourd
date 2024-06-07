using System;
using System.Collections.Generic;

namespace SofiaConseil.DbLib.Class;

public partial class Demande
{
    public long Id { get; set; }

    public long IdUsers { get; set; }

    public long IdStatuts { get; set; }

    public long? IdFreelances { get; set; }

    public DateTime DateDemande { get; set; }

    public string Titre { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string? RememberToken { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual ICollection<Competdemande> Competdemandes { get; set; } = new List<Competdemande>();

    public virtual ICollection<Competfree> Competfrees { get; set; } = new List<Competfree>();

    public virtual Freelance? IdFreelancesNavigation { get; set; }

    public virtual Statut IdStatutsNavigation { get; set; } = null!;

    public virtual User IdUsersNavigation { get; set; } = null!;
}
