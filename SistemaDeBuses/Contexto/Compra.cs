using System;
using System.Collections.Generic;

namespace SistemaDeBuses.Contexto;

public partial class Compra
{
    public int CompraId { get; set; }

    public int UsuarioId { get; set; }

    public int RutaId { get; set; }

    public DateTime FechaCompra { get; set; }

    public int CantidadAsientos { get; set; }

    public decimal TotalCompra { get; set; }

    public string? AsientosComprados { get; set; }

    public virtual Ruta Ruta { get; set; } = null!;

    public virtual Usuario Usuario { get; set; } = null!;
}
