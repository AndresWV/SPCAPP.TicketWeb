using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace SPCAPP.TicketWeb.Models
{
    public partial class SPCTK_WEBContext : DbContext
    {
        public SPCTK_WEBContext()
        {
        }

        public SPCTK_WEBContext(DbContextOptions<SPCTK_WEBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Ticket> Tickets { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=172.16.40.3;database=SPCTK_WEB;User ID=sa;Password=a123456$;Trusted_Connection=false");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ticket>(entity =>
            {
                entity.ToTable("Ticket");

                entity.Property(e => e.AreaEmpresa).IsRequired();

                entity.Property(e => e.AreaTrabajo).IsRequired();

                entity.Property(e => e.Asignado).IsRequired();

                entity.Property(e => e.Cliente).IsRequired();

                entity.Property(e => e.Contacto).IsRequired();

                entity.Property(e => e.Email).IsRequired();

                entity.Property(e => e.EmailEmpresa)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.Estado).IsRequired();

                entity.Property(e => e.ModoContacto).IsRequired();

                entity.Property(e => e.Telefono1).HasColumnName("Telefono_1");

                entity.Property(e => e.Telefono2).HasColumnName("Telefono_2");

                entity.Property(e => e.Telefono3).HasColumnName("Telefono_3");

                entity.Property(e => e.TipoSoporte).IsRequired();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
