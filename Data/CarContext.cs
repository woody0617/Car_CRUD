using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Car_CRUD.Models;

namespace Car_CRUD.Data;

public partial class CarContext : DbContext
{
    public CarContext()
    {
    }

    public CarContext(DbContextOptions<CarContext> options)
        : base(options)
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=tcp:127.0.0.1,1433;Database=car;MultipleActiveResultSets=true;User=sa;Password=Passw0rd;Encrypt=false;TrustServerCertificate=True;MultiSubnetFailover=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

    public DbSet<Car_CRUD.Models.Car> Car { get; set; } = default!;
}
