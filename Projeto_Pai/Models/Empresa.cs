using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_Pai.Models
{
    public class Empresa
    {
        public string Nome { get; set; }
        public string Morada { get; set; }
        public int Telefone { get; set; }
        public int NIF { get; set; }
        public string Email { get; set; }
        public int IBAN { get; set; }
        public string Observacoes { get; set; }
    }
}
