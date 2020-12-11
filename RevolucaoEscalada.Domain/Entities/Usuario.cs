using RevolucaoEscalada.Domain.Enum;
using RevolucaoEscalada.Domain.ValueObjects;
using System.Collections.Generic;

namespace RevolucaoEscalada.Domain.Entities
{
    public class Usuario
    {
        public Nome Nome { get; set; }

        public List<Pagamento> Pagamentos { get; set; }

        public Email Email { get; set; }

        public Plano Plano { get; set; }

        public StatusUsuario Status { get; set; }

        public DiaVencimento DiaVencimento { get; set; }

        public string Telefone { get; set; }

        public string Endereco { get; set; }

        public string Obs { get; set; }


        public Usuario()
        {

        }

    }
}
