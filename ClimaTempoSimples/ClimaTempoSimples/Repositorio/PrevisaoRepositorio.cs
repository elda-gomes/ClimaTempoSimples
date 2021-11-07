using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using ClimaTempoSimples.Models;

namespace ClimaTempoSimples.Repositorio
{
    public class PrevisaoRepositorio
    {
        private ClimaTempoSimplesEntities db = new ClimaTempoSimplesEntities();

        public List<PrevisaoClima> ObterPrevisaoCidadesMaisQuentes()
        {
            try
            {
                List<PrevisaoClima> previsaoCidadesMaisQuentes = db.PrevisaoClima
                                                                .Include(p => p.Cidade)
                                                                .Include(p => p.Cidade.Estado)
                                                                .Where(p => p.DataPrevisao == DateTime.Today.Date)
                                                                .OrderByDescending(p => p.TemperaturaMaxima)
                                                                .Take(3)
                                                                .ToList();

                return previsaoCidadesMaisQuentes;
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        public List<PrevisaoClima> ObterPrevisaoCidadesMaisFrias()
        {
            try
            {
                List<PrevisaoClima> previsaoCidadesMaisFrias = db.PrevisaoClima
                                                      .Include(p => p.Cidade)
                                                      .Include(p => p.Cidade.Estado)
                                                      .Where(p => p.DataPrevisao == DateTime.Today.Date)
                                                      .OrderBy(p => p.TemperaturaMinima)
                                                      .Take(3)
                                                      .ToList();

                return previsaoCidadesMaisFrias;
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        public void ObterPrevisaoSemanal(Cidade cidade)
        {
            try
            {
                DateTime dataInicio = DateTime.Today.Date;
                DateTime dataFim = DateTime.Today.AddDays(6).Date;

                cidade.PrevisaoClima = db.PrevisaoClima
                                      .Where(p => p.DataPrevisao >= dataInicio
                                               && p.DataPrevisao <= dataFim
                                               && p.CidadeId == cidade.Id)
                                      .ToList();
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }
    }
}