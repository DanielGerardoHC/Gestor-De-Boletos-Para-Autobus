using System;
using System.Collections.Generic;

namespace SistemaDeBuses.Contexto;

public partial class Usuario
{
    public int UsuarioId { get; set; }

    public string NombreUsuario { get; set; } = null!;

    public string Contraseña { get; set; } = null!;

    public int NivelUsuario { get; set; }

    public string? NombreCompleto { get; set; }

    public int? Edad { get; set; }

    public string? Correo { get; set; }

    public virtual ICollection<Compra> Compras { get; set; } = new List<Compra>();
}
