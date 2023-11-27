using System;
using System.Collections.Generic;

namespace Reservas.MODEL;

public partial class Reserva
{
    public int Id { get; set; }

    public int IdUsuario { get; set; }

    public int IdSala { get; set; }

    public DateTime Data { get; set; }

    public virtual Sala IdSalaNavigation { get; set; } = null!;

    public virtual Usuario IdUsuarioNavigation { get; set; } = null!;
}
