using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BuscandoIE.Controllers;
using BuscandoIE.Models;
using BuscandoIE.Models.Enuns;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace BuscandoIE.Data
{

    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<InscricaoEstadual> TB_IE { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<InscricaoEstadual>().HasData
            (
                new InscricaoEstadual() {Id = 1, Nome = "LIBERTY SEGUROS S.A", CNPJ = 61550141000172, NroIE = 123456, UF = "SP", SituacaoIE = SituacaoEnum.Habilitada},
            new InscricaoEstadual() {Id = 2, Nome = "F1RST TECNOLOGIA E INOVACAO LTDA", CNPJ = 02233469000104, NroIE = 789456, UF = "SP", SituacaoIE = SituacaoEnum.Cancelada},
            new InscricaoEstadual() {Id = 3, Nome = "HDI SEGUROS S.A", CNPJ = 29980158000157, NroIE = 159753, UF = "SP", SituacaoIE = SituacaoEnum.Impedida},
            new InscricaoEstadual() {Id = 4, Nome = "ITAU UNIBANCO HOLDING S.A", CNPJ = 60872504000123, NroIE = 951357, UF = "RJ", SituacaoIE = SituacaoEnum.Cancelada},
            new InscricaoEstadual() {Id = 5, Nome = "BANCO SANTANDER (BRASIL) S.A", CNPJ = 	90400888000142, NroIE = 654238, UF = "BA", SituacaoIE = SituacaoEnum.Habilitada},
            new InscricaoEstadual() {Id = 6, Nome = "CLARO NXT TELECOMUNICACOES S.A", CNPJ = 66970229000167, NroIE = 786216, UF = "PA", SituacaoIE = SituacaoEnum.Impedida},
            new InscricaoEstadual() {Id = 7, Nome = "AMIL ASSISTENCIA MEDICA INTERNACIONAL S.A", CNPJ = 29309127000179, NroIE = 658920, UF = "GO", SituacaoIE = SituacaoEnum.Impedida}
            );
        }
    }
}