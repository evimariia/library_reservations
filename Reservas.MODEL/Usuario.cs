using System;
using System.Collections.Generic;

namespace Reservas.MODEL;

public partial class Usuario
{
    public int Id { get; set; }

    public string Ra { get; set; } = null!;

    public string? Nome { get; set; }

    public string? Curso { get; set; }

    public int? Semestre { get; set; }

    public string Senha { get; set; } = null!;

    public virtual ICollection<Reserva> Reservas { get; set; } = new List<Reserva>();
}
