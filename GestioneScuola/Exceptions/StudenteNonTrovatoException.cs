using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace GestioneScuola.Exceptions
{
    internal class StudenteNonTrovatoException : Exception
    {
     
        public StudenteNonTrovatoException()
        {

        }
        public StudenteNonTrovatoException(string message) : base(message)
        {

        }
        public StudenteNonTrovatoException(SerializationInfo info, StreamingContext context) : base(info, context)
        {

        }
    }

}
