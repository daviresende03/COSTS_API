using COSTS_API.Models.Categories;
using COSTS_API.Models.Projects;
using COSTS_API.Models.Services;
using Microsoft.EntityFrameworkCore;

namespace COSTS_API.Infra.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Project> Projects { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Category> Categories { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            //Project

            builder.Entity<Project>()
                .ToTable("projetos");

            builder.Entity<Project>().Property(x => x.Id)
                .HasColumnName("id")
                .HasColumnType("int");

            builder.Entity<Project>().Property(c => c.Name)
                .HasColumnName("nome")
                .HasColumnType("varchar(50)")
                .IsRequired();

            builder.Entity<Project>().Property(c => c.Budget)
                .HasColumnName("orcamento")
                .HasColumnType("decimal(10,2)")
                .IsRequired();

            builder.Entity<Project>().Property(c => c.Cost)
                .HasColumnName("custo")
                .HasColumnType("decimal(10,2)")
                .IsRequired();

            builder.Entity<Project>().Property(c => c.CategoryId)
                .HasColumnName("categoria")
                .HasColumnType("int")
                .IsRequired();

            // Category

            builder.Entity<Category>()
                .ToTable("categorias");

            builder.Entity<Category>().Property(x => x.Id)
                .HasColumnName("id")
                .HasColumnType("int");

            builder.Entity<Category>().Property(c => c.Name)
                .HasColumnName("nome")
                .HasColumnType("varchar(40)")
                .IsRequired();

            //Service

            builder.Entity<Service>()
                .ToTable("servicos");

            builder.Entity<Service>().Property(x => x.Id)
                .HasColumnName("id")
                .HasColumnType("int(6)");

            builder.Entity<Service>().Property(c => c.Name)
                .HasColumnName("nome")
                .HasColumnType("varchar(60)")
                .IsRequired();
            
            builder.Entity<Service>().Property(c => c.Descritpion)
                .HasColumnName("descricao")
                .HasColumnType("varchar(120)")
                .IsRequired();

            builder.Entity<Service>().Property(c => c.Cost)
                .HasColumnName("custo")
                .HasColumnType("decimal(10,2)")
                .IsRequired();

            builder.Entity<Service>().Property(c => c.ProjectId)
                .HasColumnName("projeto")
                .HasColumnType("int")
                .IsRequired();
        }
    }
}
