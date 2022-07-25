using System;

namespace ProgramacionIntermedia.src
{
    internal class NulleableException : NullReferenceException
    {
        public NulleableException() : base()
        {
            Console.Write("La variable no puede ser nula, mas informacion: ");
        }
    }
}
