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
                .HasColumnName("Id")
                .HasColumnType("int(6)");

            builder.Entity<Project>().Property(c => c.Name)
                .HasColumnName("Nome")
                .HasColumnType("varchar(25)")
                .IsRequired();

            builder.Entity<Project>().Property(c => c.Budget)
                .HasColumnName("orcamento")
                .HasColumnType("decimal(10,2)")
                .IsRequired();

            builder.Entity<Project>().Property(c => c.Cost)
                .HasColumnName("orcamento")
                .HasColumnType("decimal(10,2)")
                .IsRequired();

            builder.Entity<Project>().Property(c => c.CategoryId)
                .HasColumnName("categoria")
                .HasColumnType("int(6)")
                .IsRequired();

            // Category

            builder.Entity<Category>()
                .ToTable("categorias");

            builder.Entity<Category>().Property(x => x.Id)
                .HasColumnName("Id")
                .HasColumnType("int(6)");

            builder.Entity<Category>().Property(c => c.Name)
                .HasColumnName("Nome")
                .HasColumnType("varchar(25)")
                .IsRequired();

            //Service

            builder.Entity<Service>()
                .ToTable("servicos");

            builder.Entity<Service>().Property(x => x.Id)
                .HasColumnName("Id")
                .HasColumnType("int(6)");

            builder.Entity<Service>().Property(c => c.Name)
                .HasColumnName("Nome")
                .HasColumnType("varchar(25)")
                .IsRequired();
            
            builder.Entity<Service>().Property(c => c.Descritpion)
                .HasColumnName("Nome")
                .HasColumnType("varchar(25)")
                .IsRequired();

            builder.Entity<Service>().Property(c => c.Cost)
                .HasColumnName("orcamento")
                .HasColumnType("decimal(10,2)")
                .IsRequired();

            builder.Entity<Service>().Property(c => c.ProjectId)
                .HasColumnName("projeto")
                .HasColumnType("int(6)")
                .IsRequired();
        }
    }
}
