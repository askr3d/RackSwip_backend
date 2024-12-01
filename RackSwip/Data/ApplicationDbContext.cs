using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RackSwip.Models;

namespace RackSwip.Data
{
    public class ApplicationDbContext: IdentityDbContext<AppUser> //Change to AppUser - No Run yet
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {
            
        }


        //Put the models here to convert into migrations
        public DbSet<Edificio> Edificios { get; set; }
        public DbSet<Side> Sides { get; set; }
        public DbSet<Rack> Racks { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Componente> Componentes { get; set; }
        public DbSet<DireccionIP> DireccionIPs { get; set; }

        //Add a comment to see custom migrations
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);

        //    modelBuilder.Entity<CandidatoPartido>()
        //        .HasKey(sc => new { sc.CandidatoId, sc.PartidoId });

        //    modelBuilder.Entity<CandidatoPartido>()
        //        .HasOne(sc => sc.Candidato)
        //        .WithMany(s => s.Partidos)
        //        .HasForeignKey(sc => sc.CandidatoId);

        //    modelBuilder.Entity<CandidatoPartido>()
        //        .HasOne(sc => sc.Partido)
        //        .WithMany(c => c.Candidatos)
        //        .HasForeignKey(sc => sc.PartidoId);
        //}
    }
}
