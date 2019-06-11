using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DabbawallasData;

namespace DabbawallasBusiness.Classes
{
    public class Supervisor : Usuario
    {
        private const int SupervisorTypeId = 3;
        public int IdSupervisor { get; set; }
        public int IdZona { get; set; }

        public Supervisor()
        {

        }

        public Supervisor(int idSupervisor)
        {
            IdSupervisor = idSupervisor;
            if (Read() == false)
            {
                IdSupervisor = -1;
            }
        }

        public Supervisor(int idzona, string username, string password, string nombre, string apellido, string email, string celular) 
            : base(SupervisorTypeId, username,password,nombre,apellido,email,celular)
        {
            IdZona = idzona;
        }

        public Supervisor(string nombreZona, string username, string password, string nombre, string apellido, string email, string celular)
            : base(SupervisorTypeId, username, password, nombre, apellido, email, celular)
        {
            IdZona = GetIdZonaByName(nombreZona);
        }

        public int GetIdZonaByName (string zona)
        {
            if (Enum.TryParse(zona, out Zona zonaID) == true)
            {
               return (int)zonaID;
            }
            else
            {
               return -1;
            }
                
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
                if (CreateUser())
                {
                    SUPERVISOR sup = new SUPERVISOR
                    {
                        ID_ZONA = IdZona,
                        ID_USUARIO = IdUsuario
                    };
                    Connection.DabbawallaDB.SUPERVISOR.Add(sup);
                    Connection.DabbawallaDB.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public List<Dabbawalla> AssociatedDabbawallas ()
        {
            List<Dabbawalla> dabbawallasList = new List<Dabbawalla>();
            List<DABBAWALLA> dabList = Connection.DabbawallaDB.DABBAWALLA.Where(x => x.ID_SUPERVISOR_ASOCIADO == IdSupervisor).ToList<DABBAWALLA>();
            foreach (DABBAWALLA dab in dabList)
            {
                Dabbawalla dabbawalla = new Dabbawalla(dab.ID_DABBAWALLA);
                dabbawallasList.Add(dabbawalla);
            }
            return dabbawallasList;
        }

        
    }
}
