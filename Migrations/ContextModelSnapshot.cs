﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Repository;

namespace habbohotel.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Models.Colaborador", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Matricula")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Nome")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Senha")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.ToTable("Colaboradores");
                });

            modelBuilder.Entity("Models.Despesa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("IdProduto")
                        .HasColumnType("int");

                    b.Property<int>("IdReserva")
                        .HasColumnType("int");

                    b.Property<int?>("ProdutoId")
                        .HasColumnType("int");

                    b.Property<int>("QuantidadeProduto")
                        .HasColumnType("int");

                    b.Property<int?>("ReservaId")
                        .HasColumnType("int");

                    b.Property<float>("ValorTotalDespesa")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("ProdutoId");

                    b.HasIndex("ReservaId");

                    b.ToTable("Despesas");
                });

            modelBuilder.Entity("Models.Hospede", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("CPF")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("CVVcartao")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("DataValidadeCartao")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("FormaPagamento")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Nome")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("NomeMae")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("NumeroCartao")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Senha")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.ToTable("Hospedes");
                });

            modelBuilder.Entity("Models.Limpeza", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("ColaboradorId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataLimpeza")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("IdColaborador")
                        .HasColumnType("int");

                    b.Property<int>("IdReserva")
                        .HasColumnType("int");

                    b.Property<int?>("ReservaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ColaboradorId");

                    b.HasIndex("ReservaId");

                    b.ToTable("Limpezas");
                });

            modelBuilder.Entity("Models.Produto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<float>("ValorProduto")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Produtos");
                });

            modelBuilder.Entity("Models.Quarto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Andar")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Descricao")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("NroQuarto")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<bool>("Reservado")
                        .HasColumnType("tinyint(1)");

                    b.Property<float>("ValorQuarto")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Quartos");
                });

            modelBuilder.Entity("Models.Reserva", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("DataEntrada")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DataSaida")
                        .HasColumnType("datetime(6)");

                    b.Property<int?>("HospedeId")
                        .HasColumnType("int");

                    b.Property<int>("IdHospede")
                        .HasColumnType("int");

                    b.Property<int>("IdQuarto")
                        .HasColumnType("int");

                    b.Property<bool>("Pago")
                        .HasColumnType("tinyint(1)");

                    b.Property<int?>("QuartoId")
                        .HasColumnType("int");

                    b.Property<float>("ValorTotalReserva")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("HospedeId");

                    b.HasIndex("QuartoId");

                    b.ToTable("Reservas");
                });

            modelBuilder.Entity("Models.Despesa", b =>
                {
                    b.HasOne("Models.Produto", "Produto")
                        .WithMany()
                        .HasForeignKey("ProdutoId");

                    b.HasOne("Models.Reserva", "Reserva")
                        .WithMany()
                        .HasForeignKey("ReservaId");
                });

            modelBuilder.Entity("Models.Limpeza", b =>
                {
                    b.HasOne("Models.Colaborador", "Colaborador")
                        .WithMany()
                        .HasForeignKey("ColaboradorId");

                    b.HasOne("Models.Reserva", "Reserva")
                        .WithMany()
                        .HasForeignKey("ReservaId");
                });

            modelBuilder.Entity("Models.Reserva", b =>
                {
                    b.HasOne("Models.Hospede", "Hospede")
                        .WithMany()
                        .HasForeignKey("HospedeId");

                    b.HasOne("Models.Quarto", "Quarto")
                        .WithMany()
                        .HasForeignKey("QuartoId");
                });
#pragma warning restore 612, 618
        }
    }
}
