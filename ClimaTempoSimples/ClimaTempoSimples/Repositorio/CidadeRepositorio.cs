using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using ClimaTempoSimples.Models;

namespace ClimaTempoSimples.Repositorio
{
    public class CidadeRepositorio
    {
        private ClimaTempoSimplesEntities db = new ClimaTempoSimplesEntities();

        public List<Cidade> ObterCidades()
        {
            try
            {
                return db.Cidade.ToList();
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }
    }
}