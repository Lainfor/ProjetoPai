using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_Pai.Models
{
    public class Cliente
    {
        public Contacto Contacto { get; set; }
        public Empresa Empresa { get; set; }
        public enum Estado { PossivelCliente, EmNegocio, PropostaEntregue, Analise, Perdido, Concluido, DeOutroAgente}
        public enum DeOutroAg { RecisaoEnviada, EmailEnviado, TelefonemaFeito, AguardaPassagem, ClienteConta}
    }
}
