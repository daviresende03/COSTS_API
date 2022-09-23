﻿// <auto-generated />
using COSTS_API.Infra.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace COSTS_API.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20220923005858_ColumnsName")]
    partial class ColumnsName
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("COSTS_API.Models.Categories.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int(6)")
                        .HasColumnName("id");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(25)")
                        .HasColumnName("nome");

                    b.HasKey("Id");

                    b.ToTable("categorias", (string)null);
                });

            modelBuilder.Entity("COSTS_API.Models.Projects.Project", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int(6)")
                        .HasColumnName("id");

                    b.Property<decimal>("Budget")
                        .ValueGeneratedOnUpdateSometimes()
                        .HasColumnType("decimal(10,2)")
                        .HasColumnName("orcamento");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int(6)")
                        .HasColumnName("categoria");

                    b.Property<decimal>("Cost")
                        .ValueGeneratedOnUpdateSometimes()
                        .HasColumnType("decimal(10,2)")
                        .HasColumnName("orcamento");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(25)")
                        .HasColumnName("nome");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("projetos", (string)null);
                });

            modelBuilder.Entity("COSTS_API.Models.Services.Service", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int(6)")
                        .HasColumnName("id");

                    b.Property<decimal>("Cost")
                        .HasColumnType("decimal(10,2)")
                        .HasColumnName("orcamento");

                    b.Property<string>("Descritpion")
                        .IsRequired()
                        .HasColumnType("varchar(25)")
                        .HasColumnName("descricao");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(25)")
                        .HasColumnName("nome");

                    b.Property<int>("ProjectId")
                        .HasColumnType("int(6)")
                        .HasColumnName("projeto");

                    b.HasKey("Id");

                    b.HasIndex("ProjectId");

                    b.ToTable("servicos", (string)null);
                });

            modelBuilder.Entity("COSTS_API.Models.Projects.Project", b =>
                {
                    b.HasOne("COSTS_API.Models.Categories.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("COSTS_API.Models.Services.Service", b =>
                {
                    b.HasOne("COSTS_API.Models.Projects.Project", "Project")
                        .WithMany("Services")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Project");
                });

            modelBuilder.Entity("COSTS_API.Models.Projects.Project", b =>
                {
                    b.Navigation("Services");
                });
#pragma warning restore 612, 618
        }
    }
}
