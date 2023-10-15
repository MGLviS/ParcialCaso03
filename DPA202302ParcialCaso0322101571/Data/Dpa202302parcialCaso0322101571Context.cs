using System;
using System.Collections.Generic;
using DPA202302ParcialCaso0322101571.Entities;
using Microsoft.EntityFrameworkCore;

namespace DPA202302ParcialCaso0322101571.Data;

public partial class Dpa202302parcialCaso0322101571Context : DbContext
{
    public Dpa202302parcialCaso0322101571Context()
    {
    }

    public Dpa202302parcialCaso0322101571Context(DbContextOptions<Dpa202302parcialCaso0322101571Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Territory> Territory { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=WS2302523;Database=DPA202302ParcialCaso0322101571;Integrated Security=true;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Territory>(entity =>
        {
            entity.Property(e => e.Description).HasMaxLength(50);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
