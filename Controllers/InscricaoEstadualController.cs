using System;
using System.Collections.Generic;
using BuscandoIE.Models;
using BuscandoIE.Models.Enuns;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using BuscandoIE.Data;
using Microsoft.EntityFrameworkCore;

namespace BuscandoIE.Controllers
{
    [ApiController]
    [Route("api/[inscricao]")]

    public class InscricaoEstadualController : ControllerBase
    {
        private readonly DataContext _context;

        public InscricaoEstadualController(DataContext context)
        {
            _context = context;
        }

        private static List<InscricaoEstadual> parceiro = new List<InscricaoEstadual>()
        {
            new InscricaoEstadual() {Id = 1, Nome = "LIBERTY SEGUROS S.A", CNPJ = 61550141000172, NroIE = 123456, UF = "SP", SituacaoIE = SituacaoEnum.Habilitada},
            new InscricaoEstadual() {Id = 2, Nome = "F1RST TECNOLOGIA E INOVACAO LTDA", CNPJ = 02233469000104, NroIE = 789456, UF = "SP", SituacaoIE = SituacaoEnum.Cancelada},
            new InscricaoEstadual() {Id = 3, Nome = "HDI SEGUROS S.A", CNPJ = 29980158000157, NroIE = 159753, UF = "SP", SituacaoIE = SituacaoEnum.Impedida},
            new InscricaoEstadual() {Id = 4, Nome = "ITAU UNIBANCO HOLDING S.A", CNPJ = 60872504000123, NroIE = 951357, UF = "RJ", SituacaoIE = SituacaoEnum.Cancelada},
            new InscricaoEstadual() {Id = 5, Nome = "BANCO SANTANDER (BRASIL) S.A", CNPJ = 	90400888000142, NroIE = 654238, UF = "BA", SituacaoIE = SituacaoEnum.Habilitada},
            new InscricaoEstadual() {Id = 6, Nome = "CLARO NXT TELECOMUNICACOES S.A", CNPJ = 66970229000167, NroIE = 786216, UF = "PA", SituacaoIE = SituacaoEnum.Impedida},
            new InscricaoEstadual() {Id = 7, Nome = "AMIL ASSISTENCIA MEDICA INTERNACIONAL S.A", CNPJ = 29309127000179, NroIE = 658920, UF = "GO", SituacaoIE = SituacaoEnum.Impedida}
        };

        [HttpGet("GetAll")]
        public async Task<IActionResult> Get()
        {
            try
            {
                List<InscricaoEstadual> Lparceiros =  await _context.TB_IE.ToListAsync();
                return Ok(Lparceiros);
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{cnpj}")] //Perquisar situação da IE através do CNPJ, caso a situação da IE seja diferente de Habilitado, irá retornar uma mensagem
        public async Task<IActionResult> GetSingle(long cnpj)
        {
            try
            {
                InscricaoEstadual buscar = await _context.TB_IE 
                    .FirstOrDefaultAsync(p => p.CNPJ == cnpj); //Irá fazer a busca através do CNPJ do Parceiro Comercial

                if (cnpj == null)
                {
                    return NotFound("CNPJ não encontrado"); // Retorna 404 se não encontrar a inscrição com o CNPJ fornecido.
                }

                if (buscar.SituacaoIE != SituacaoEnum.Habilitada)
                {
                    return Ok($"ISENTO! O CNPJ pode estar dispensado ou proibido de possuir a Inscrição Estadual. Outro motivo pode vir em decorrencia da situação da IE \nA situacação da sua Inscrição Estadual é: {buscar.SituacaoIE.ToString().ToUpper()}"); // Retorna mensagem de isenção se a SituacaoIE não for Habilitado.
                }

                return Ok(buscar);
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost] //Inserir Parceiro Comercial informando seus dados
        public async Task<IActionResult> AddParceiro(InscricaoEstadual novoParceiro)
        {
            try
            {
                await _context.TB_IE.AddAsync(novoParceiro);
                await _context.SaveChangesAsync();
                return Ok(parceiro);   
            }
            catch (System.Exception ex)
            {
               return BadRequest(ex.Message);
            }
        }

        [HttpPut("{cnpj}")]
        public IActionResult UpdateParceiro(InscricaoEstadual pc)
        {
            InscricaoEstadual dadosAlterados = parceiro.Find(parc => parc.CNPJ == pc.CNPJ);
            dadosAlterados.Nome = pc.Nome;
            dadosAlterados.UF = pc.UF;
            dadosAlterados.SituacaoIE = pc.SituacaoIE;

            return Ok(parceiro);
        }

        [HttpDelete("{cnpj}")]
        public IActionResult Delete(long cnpj)
        {
            parceiro.RemoveAll(parc => parc.CNPJ == cnpj);

            return Ok(parceiro);
        }
    }
}