using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

//namespace Reservas.DAL.DBContext;
namespace Reservas.MODEL;

public partial class CTrabalhofinalLpiiiReservasDalDatabaseDatabaseMdfContext : DbContext
{
    public CTrabalhofinalLpiiiReservasDalDatabaseDatabaseMdfContext()
    {
    }

    public CTrabalhofinalLpiiiReservasDalDatabaseDatabaseMdfContext(DbContextOptions<CTrabalhofinalLpiiiReservasDalDatabaseDatabaseMdfContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Reserva> Reservas { get; set; }

    public virtual DbSet<Sala> Salas { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\TrabalhoFinal_LPIII\\Reservas.DAL\\database\\database.mdf;Integrated Security=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Reserva>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__reserva__3214EC076FDC811C");

            entity.ToTable("reserva");

            entity.Property(e => e.Data).HasColumnName("data");
            entity.Property(e => e.IdSala).HasColumnName("id_sala");
            entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");

            entity.HasOne(d => d.IdSalaNavigation).WithMany(p => p.Reservas)
                .HasForeignKey(d => d.IdSala)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Sala_toReserva");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.Reservas)
                .HasForeignKey(d => d.IdUsuario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Usuario_toReserva");
        });

        modelBuilder.Entity<Sala>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__sala__3214EC07D73062CB");

            entity.ToTable("sala");

            entity.Property(e => e.Modalidade)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("modalidade");
            entity.Property(e => e.Numero).HasColumnName("numero");
            entity.Property(e => e.QtdePessoas).HasColumnName("qtde_pessoas");
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__usuario__3214EC07DD1D54A4");

            entity.ToTable("usuario");

            entity.Property(e => e.Curso)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("curso");
            entity.Property(e => e.Nome)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nome");
            entity.Property(e => e.Ra)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("RA");
            entity.Property(e => e.Semestre).HasColumnName("semestre");
            entity.Property(e => e.Senha)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("senha");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
