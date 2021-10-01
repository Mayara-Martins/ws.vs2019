using System;

namespace ex19.Entities.Exceptions
{
    class DomainException : ApplicationException

    {
        public DomainException(string message) : base(message)
        { 
        }
    }
}
