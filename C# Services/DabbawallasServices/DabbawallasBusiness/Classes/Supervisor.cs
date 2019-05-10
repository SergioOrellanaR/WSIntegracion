using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DabbawallasData;

namespace DabbawallasBusiness.Classes
{
    class Supervisor : Usuario
    {
        public int IdSupervisor { get; set; }
        public int IdZona { get; set; }

        public Supervisor(int idSupervisor)
        {
            IdSupervisor = IdSupervisor;
            Read();
        }

        public bool Read()
        {
            try
            {
                SUPERVISOR dab = Connection.DabbawallaDB.SUPERVISOR.First(sup => sup.ID_SUPERVISOR == IdSupervisor);
                IdUsuario = dab.ID_USUARIO.Value;
                ReadUser();
                IdZona = dab.ID_ZONA.Value;
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
