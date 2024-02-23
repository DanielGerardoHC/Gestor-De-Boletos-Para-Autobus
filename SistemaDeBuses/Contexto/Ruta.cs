using System;
using System.Collections.Generic;

namespace SistemaDeBuses.Contexto;

public partial class Ruta
{
    public int RutaId { get; set; }

    public string NombreRuta { get; set; } = null!;

    public string Origen { get; set; } = null!;

    public string Destino { get; set; } = null!;

    public decimal Precio { get; set; }

    public int? AsientosDisponibles { get; set; }

    public virtual ICollection<Compra> Compras { get; set; } = new List<Compra>();
}
