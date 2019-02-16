using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static Projeto_Pai.Models.Cliente;

namespace Projeto_Pai.Models
{
    public class Processo
    {
        public int Id { get; set; }
        public Estado Estado { get; set; }
        public DateTime Data { get; set; }
        public Departamento RespondidoPor { get; set; }
        public List<Utilizador> AtribuidoA { get; set; }
        public Cliente Cliente { get; set; }
        public Produto Produto { get; set; }
        public int Intervencoes { get; set; }
        public string Observacoes { get; set; }
        public string Resposta { get; set; }
    }
}
