using System;

namespace RevolucaoEscalada.Domain.ValueObjects
{
    public sealed class DiaVencimento
    {
        public int diaVencimento { get; private set; }

        public static implicit operator DiaVencimento(int diaVencimento)
            => new DiaVencimento(diaVencimento);

        private DiaVencimento(int diaVencimento)
            => this.diaVencimento = diaVencimento;

        public DiaVencimento() { }

        public override bool Equals(object obj)
        {
            return obj is DiaVencimento vencimento &&
                   diaVencimento == vencimento.diaVencimento;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(diaVencimento);
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public bool isDayValid()
        {

            if (this.diaVencimento <= 0 || this.diaVencimento > 31)
            {
                return false;
            }

            return true;
        }

    }
}
