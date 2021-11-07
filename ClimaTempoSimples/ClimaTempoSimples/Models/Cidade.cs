namespace ClimaTempoSimples.Models
{
    using System;
    using System.Collections.Generic;
    
    public class Cidade
    {
        public Cidade()
        {
            this.PrevisaoClima = new List<PrevisaoClima>();
        }
    
        public int Id { get; set; }
        public string Nome { get; set; }
        public int EstadoId { get; set; }
    
        public Estado Estado { get; set; }
        public List<PrevisaoClima> PrevisaoClima { get; set; }
    }
}
