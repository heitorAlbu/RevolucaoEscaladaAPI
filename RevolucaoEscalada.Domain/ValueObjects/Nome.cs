using System;

namespace RevolucaoEscalada.Domain.ValueObjects
{
    public sealed class Nome
    {
        public string nome { get; private set; }

        public static implicit operator Nome(string nome)
            => new Nome(nome);

        private Nome(string nome)
            => this.nome = nome;

        public Nome() { }

        public override bool Equals(object obj)
        {
            return obj is Nome nome &&
                   base.Equals(obj) &&
                   this.nome == nome.nome;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(base.GetHashCode(), nome);
        }

        public override string ToString()
        {
            return base.ToString();
        }

    }
}
