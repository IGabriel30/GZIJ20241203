using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace GZIJ20241203.Models
{
    public partial class GZIJ20241203DbContext : DbContext
    {
        public GZIJ20241203DbContext()
        {
        }

        public GZIJ20241203DbContext(DbContextOptions<GZIJ20241203DbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<DireccionesProveedor> DireccionesProveedors { get; set; } = null!;
        public virtual DbSet<Proveedore> Proveedores { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
//            if (!optionsBuilder.IsConfigured)
//            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
//                optionsBuilder.UseSqlServer("Data Source=PC-IGABRIEL;Initial Catalog=GZIJ20241203Db;Integrated Security=True;Trust Server Certificate=True");
//            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DireccionesProveedor>(entity =>
            {
                entity.HasKey(e => e.IdDireccion)
                    .HasName("PK__Direccio__1F8E0C7614B76F19");

                entity.ToTable("DireccionesProveedor");

                entity.Property(e => e.Ciudad).HasMaxLength(50);

                entity.Property(e => e.Direccion).HasMaxLength(200);

                entity.Property(e => e.Pais).HasMaxLength(50);

                entity.Property(e => e.ProveedorId).HasColumnName("ProveedorID");

                entity.HasOne(d => d.Proveedor)
                    .WithMany(p => p.DireccionesProveedors)
                    .HasForeignKey(d => d.ProveedorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Direccion__Prove__398D8EEE");
            });

            modelBuilder.Entity<Proveedore>(entity =>
            {
                entity.HasKey(e => e.IdProveedor)
                    .HasName("PK__Proveedo__E8B631AF47FA3A70");

                entity.Property(e => e.CorreoElectronico).HasMaxLength(100);

                entity.Property(e => e.FechaRegistro).HasColumnType("date");

                entity.Property(e => e.Nombre).HasMaxLength(100);

                entity.Property(e => e.Producto).HasMaxLength(50);

                entity.Property(e => e.Telefono).HasMaxLength(20);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
