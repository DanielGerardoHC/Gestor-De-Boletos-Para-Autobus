using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace SistemaDeBuses.Contexto;

public partial class GestorVentaBoletosContext : DbContext
{
    public GestorVentaBoletosContext()
    {
    }

    public GestorVentaBoletosContext(DbContextOptions<GestorVentaBoletosContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Compra> Compras { get; set; }

    public virtual DbSet<Ruta> Rutas { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        // cadena de conexion para motor de base de datos SQL Server
        => optionsBuilder.UseSqlServer("Data Source=DESKTOP-CIBJV34;Initial Catalog=GestorVentaBoletos;Integrated Security=True; Encrypt=False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Compra>(entity =>
        {
            entity.HasKey(e => e.CompraId).HasName("PK__Compras__067DA7252B152CD6");

            entity.Property(e => e.CompraId).HasColumnName("CompraID");
            entity.Property(e => e.FechaCompra).HasColumnType("datetime");
            entity.Property(e => e.RutaId).HasColumnName("RutaID");
            entity.Property(e => e.TotalCompra).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.UsuarioId).HasColumnName("UsuarioID");

            entity.HasOne(d => d.Ruta).WithMany(p => p.Compras)
                .HasForeignKey(d => d.RutaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Compras__RutaID__3C69FB99");

            entity.HasOne(d => d.Usuario).WithMany(p => p.Compras)
                .HasForeignKey(d => d.UsuarioId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Compras__Usuario__3B75D760");
        });

        modelBuilder.Entity<Ruta>(entity =>
        {
            entity.HasKey(e => e.RutaId).HasName("PK__Rutas__7B6199EE3AEFD876");

            entity.Property(e => e.RutaId).HasColumnName("RutaID");
            entity.Property(e => e.Destino).HasMaxLength(255);
            entity.Property(e => e.NombreRuta).HasMaxLength(255);
            entity.Property(e => e.Origen).HasMaxLength(255);
            entity.Property(e => e.Precio).HasColumnType("decimal(10, 2)");
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.UsuarioId).HasName("PK__Usuarios__2B3DE79844A16FE5");

            entity.Property(e => e.UsuarioId).HasColumnName("UsuarioID");
            entity.Property(e => e.Contraseña).HasMaxLength(100);
            entity.Property(e => e.Correo).HasMaxLength(200);
            entity.Property(e => e.NombreCompleto).HasMaxLength(200);
            entity.Property(e => e.NombreUsuario).HasMaxLength(50);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
