using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Projeto_Pai.Models
{
    public class Utilizador : IdentityUser
    {
        public string Nome { get; set; }
        public string Morada { get; set; }
        public int Telefone { get; set; }
        public int Telemovel { get; set; }
    }
}
