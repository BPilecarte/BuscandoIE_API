﻿// <auto-generated />
using BuscandoIE.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BuscandoIE.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BuscandoIE.Models.InscricaoEstadual", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<long>("CNPJ")
                        .HasColumnType("bigint");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NroIE")
                        .HasColumnType("int");

                    b.Property<int>("SituacaoIE")
                        .HasColumnType("int");

                    b.Property<string>("UF")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TB_IE");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CNPJ = 61550141000172L,
                            Nome = "LIBERTY SEGUROS S.A",
                            NroIE = 123456,
                            SituacaoIE = 1,
                            UF = "SP"
                        },
                        new
                        {
                            Id = 2,
                            CNPJ = 2233469000104L,
                            Nome = "F1RST TECNOLOGIA E INOVACAO LTDA",
                            NroIE = 789456,
                            SituacaoIE = 3,
                            UF = "SP"
                        },
                        new
                        {
                            Id = 3,
                            CNPJ = 29980158000157L,
                            Nome = "HDI SEGUROS S.A",
                            NroIE = 159753,
                            SituacaoIE = 4,
                            UF = "SP"
                        },
                        new
                        {
                            Id = 4,
                            CNPJ = 60872504000123L,
                            Nome = "ITAU UNIBANCO HOLDING S.A",
                            NroIE = 951357,
                            SituacaoIE = 3,
                            UF = "RJ"
                        },
                        new
                        {
                            Id = 5,
                            CNPJ = 90400888000142L,
                            Nome = "BANCO SANTANDER (BRASIL) S.A",
                            NroIE = 654238,
                            SituacaoIE = 1,
                            UF = "BA"
                        },
                        new
                        {
                            Id = 6,
                            CNPJ = 66970229000167L,
                            Nome = "CLARO NXT TELECOMUNICACOES S.A",
                            NroIE = 786216,
                            SituacaoIE = 4,
                            UF = "PA"
                        },
                        new
                        {
                            Id = 7,
                            CNPJ = 29309127000179L,
                            Nome = "AMIL ASSISTENCIA MEDICA INTERNACIONAL S.A",
                            NroIE = 658920,
                            SituacaoIE = 4,
                            UF = "GO"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}