using System;
using System.Collections.Generic;

namespace Reservas.MODEL;

public class Reserva
{
    public Reserva(int idUsuario, int idSala, DateTime data)
    {
        IdUsuario = idUsuario;
        IdSala = idSala;
        Data = data;
    }

    public Reserva()
    {
    }

    public int Id { get; set; }

    public int IdUsuario { get; set; }

    public int IdSala { get; set; }

    public DateTime Data { get; set; }

    public virtual Sala IdSalaNavigation { get; set; } = null!;

    public virtual Usuario IdUsuarioNavigation { get; set; } = null!;
}
