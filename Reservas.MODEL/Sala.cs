using System;
using System.Collections.Generic;

namespace Reservas.MODEL;

public partial class Sala
{
    public int Id { get; set; }

    public int Numero { get; set; }

    public string? Modalidade { get; set; }

    public int? QtdePessoas { get; set; }

    public virtual ICollection<Reserva> Reservas { get; set; } = new List<Reserva>();
}
