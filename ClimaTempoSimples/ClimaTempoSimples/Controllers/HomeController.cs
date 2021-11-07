using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ClimaTempoSimples.Models;
using ClimaTempoSimples.Repositorio;

namespace ClimaTempoSimples.Controllers
{
    public class HomeController : Controller
    {
        PrevisaoRepositorio repositorioPrevisao = new PrevisaoRepositorio();
        CidadeRepositorio repositorioCidade = new CidadeRepositorio();

        public ActionResult Index()
        {
            try
            {
                Previsao previsao = new Previsao();

                previsao.CidadesMaisQuentes = repositorioPrevisao.ObterPrevisaoCidadesMaisQuentes();
                previsao.CidadesMaisFrias = repositorioPrevisao.ObterPrevisaoCidadesMaisFrias();
                previsao.Cidades = repositorioCidade.ObterCidades();

                return View(previsao);
            }
            catch (Exception ex)
            {
                ViewBag.Exception = ex.Message;
                return View("Error");
            }
        }

        public ActionResult ObterPrevisaoSemanal(Cidade cidade)
        {
            try
            {
                repositorioPrevisao.ObterPrevisaoSemanal(cidade);
                ViewBag.NomeCidade = cidade.Nome;

                return PartialView(cidade.PrevisaoClima);
            }
            catch (Exception ex)
            {
                ViewBag.Exception = ex.Message;
                return View("Error");
            }
        }

        public ActionResult About()
        {
            return View();
        }
    }
}