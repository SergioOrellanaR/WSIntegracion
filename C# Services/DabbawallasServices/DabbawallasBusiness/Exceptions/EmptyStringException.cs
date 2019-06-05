using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DabbawallasBusiness.Exceptions
{
    public class EmptyStringException : Exception
    {
        public EmptyStringException()
        {

        }

        public EmptyStringException(string property) : base(String.Format("El siguiente campo no puede ser null ni vacio: {0}", property))
        {

        }
    }
}
