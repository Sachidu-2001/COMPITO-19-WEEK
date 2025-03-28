using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameWork;
using WebAppEsame.Models;

namespace WebAppEsame.Data
{
    public class ApplicationDbContext : DbContext
    {
        public class ApplicationDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, string,
    IdentityUserClaim<string>, ApplicationUserRole, IdentityUserLogin<string>,
    IdentityRoleClaim<string>, IdentityUserToken<string>>
        {
            public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
                : base(options)
            {
            }

            public DbSet<Artista> Artisti { get; set; }
            public DbSet<Evento> Eventi { get; set; }
            public DbSet<Biglietto> Biglietti { get; set; }

            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                base.OnModelCreating(modelBuilder);

               
                modelBuilder.Entity<ApplicationUserRole>()
                    .HasOne(ur => ur.User)
                    .WithMany(u => u.ApplicationUserRoles)
                    .HasForeignKey(ur => ur.UserId);

                modelBuilder.Entity<ApplicationUserRole>()
                    .HasOne(ur => ur.Role)
                    .WithMany(r => r.ApplicationUserRoles)
                    .HasForeignKey(ur => ur.RoleId);

                
                modelBuilder.Entity<Evento>()
                    .HasOne(e => e.Artista)
                    .WithMany(a => a.Eventi)
                    .HasForeignKey(e => e.ArtistaId)
                    .OnDelete(DeleteBehavior.Cascade);
                    .HasOne(b => b.Evento)
                    .WithMany(e => e.Biglietti)
                    .HasForeignKey(b => b.EventoId)
                    .OnDelete(DeleteBehavior.Cascade);
                modelBuilder.Entity<Biglietto>()
                    .HasOne(b => b.User)
                    .WithMany(u => u.Biglietti)
                    .HasForeignKey(b => b.UserId)
                    .OnDelete(DeleteBehavior.Cascade);
            }
        }
    }
}
