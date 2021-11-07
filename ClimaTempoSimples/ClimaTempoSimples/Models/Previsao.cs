using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClimaTempoSimples.Models
{
    public class Previsao
    {
        public List<PrevisaoClima> CidadesMaisQuentes { get; set; }

        public List<PrevisaoClima> CidadesMaisFrias { get; set; }

        public List<Cidade> Cidades { get; set; }
    }
}