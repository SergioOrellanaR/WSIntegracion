using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DabbawallasData;

namespace DabbawallasBusiness.Classes
{
    class Dabbawalla : Usuario
    {
        public int IdDabbawalla { get; set; }
        public Supervisor SupervisorAsociado { get; set; }

        public Dabbawalla()
        {

        }

        public Dabbawalla(int idDabbawalla)
        {
            IdDabbawalla = IdDabbawalla;
            Read();
        }

        public bool Read()
        {
            try
            {
                DABBAWALLA dab = Connection.DabbawallaDB.DABBAWALLA.First(dabba => dabba.ID_DABBAWALLA == IdDabbawalla);
                IdUsuario = dab.ID_USUARIO.Value;
                ReadUser();
                SupervisorAsociado = new Supervisor(dab.ID_USUARIO.Value);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
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
    }
}
