namespace ClimaTempoSimples.Models
{
    using System;
    using System.Collections.Generic;
    
    public class PrevisaoClima
    {
        public int Id { get; set; }
        public int CidadeId { get; set; }
        public System.DateTime DataPrevisao { get; set; }
        public string Clima { get; set; }
        public Nullable<decimal> TemperaturaMinima { get; set; }
        public Nullable<decimal> TemperaturaMaxima { get; set; }
    
        public Cidade Cidade { get; set; }
    }
}
