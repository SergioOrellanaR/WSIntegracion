using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DabbawallasBusiness.Classes
{
    class Alerta
    {
        public int IdAlerta { get; set; }
        public Cliente ClienteAlerta { get; set; }
        public int IdTipoAlerta { get; set; }
        public DateTime FechaAlerta { get; set; }

        public Alerta()
        {
            //ToDo
        }

        public bool Create()
        {
            try
            {
                //TODO
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public Dabbawalla GetDabbawallaAsociado ()
        {
            //ToDo
            return new Dabbawalla();
        }
    }
}
