using System;

namespace RevolucaoEscalada.Domain.ValueObjects
{
    public sealed class Email
    {
        public string email { get; private set; }

        public static implicit operator Email(string email)
            => new Email(email);

        private Email(string email)
            => this.email = email;

        public Email() { }

        public override bool Equals(object obj)
        {
            return obj is Email email &&
                   this.email == email.email;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(email);
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
