﻿// <auto-generated />
using BibliotecaFinal.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BibliotecaFinal.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20231018135846_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BibliotecaFinal.Models.Categoria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("CategoriaId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CategoriaLivro")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("CategoriaLivro");

                    b.HasKey("Id");

                    b.ToTable("Categoria");
                });

            modelBuilder.Entity("BibliotecaFinal.Models.Livros", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("LivrosId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AnoLivros")
                        .HasColumnType("int")
                        .HasColumnName("AnoLivros");

                    b.Property<string>("AutorLivros")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("AutorLivros");

                    b.Property<int>("CategoriaId")
                        .HasColumnType("int");

                    b.Property<string>("NomeLivros")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("NomeLivros");

                    b.Property<int>("PaginasLivros")
                        .HasColumnType("int")
                        .HasColumnName("PaginasLivros");

                    b.Property<string>("SinopseLivros")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("SinopseLivros");

                    b.HasKey("Id");

                    b.HasIndex("CategoriaId");

                    b.ToTable("Livros");
                });

            modelBuilder.Entity("BibliotecaFinal.Models.Pessoa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id_Pessoa");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CPFPessoa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("CPF");

                    b.Property<string>("NomePessoa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Nome");

                    b.Property<string>("TELPessoa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("TEL");

                    b.HasKey("Id");

                    b.ToTable("Pessoa");
                });

            modelBuilder.Entity("BibliotecaFinal.Models.Livros", b =>
                {
                    b.HasOne("BibliotecaFinal.Models.Categoria", "Categoria")
                        .WithMany()
                        .HasForeignKey("CategoriaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Categoria");
                });
#pragma warning restore 612, 618
        }
    }
}
