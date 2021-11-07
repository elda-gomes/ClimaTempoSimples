namespace ClimaTempoSimples.Models
{
    using System;
    using System.Collections.Generic;
    
    public class Estado
    {
        public Estado()
        {
            this.Cidade = new List<Cidade>();
        }
    
        public int Id { get; set; }
        public string Nome { get; set; }
        public string UF { get; set; }

        public List<Cidade> Cidade { get; set; }
    }
}
