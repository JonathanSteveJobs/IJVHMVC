using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace IJVHMVC.Models;

public partial class IjvhdbContext : DbContext
{
    public IjvhdbContext()
    {
    }

    public IjvhdbContext(DbContextOptions<IjvhdbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Veterinarium> Veterinaria { get; set; }

   

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {

        }
    }
    //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
    //        => optionsBuilder.UseSqlServer("server=LAPTOP-7SKAH6B6\\SQLEXPRESS; database=IJVHDB; integrated security=true; TrustServerCertificate = true;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Veterinarium>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Veterina__3213E83F3B5EB5A8");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.MotivoConsulta)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NombreDueño)
                .HasMaxLength(60)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
