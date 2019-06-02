using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DabbawallasData;

namespace DabbawallasBusiness.Classes
{
    public class Dabbawalla : Usuario
    {
        private const int DabbawallaTypeId = 2;
        public int IdDabbawalla { get; set; }
        public Supervisor SupervisorAsociado { get; set; }

        public Dabbawalla()
        {

        }

        public Dabbawalla(int idDabbawalla)
        {
            IdDabbawalla = idDabbawalla;
            if (Read() == false)
            {
                IdDabbawalla = -1;
            }
        }

        public Dabbawalla(int idSupervisor, string username, string password, string nombre, string apellido, string email, string celular)
            : base(DabbawallaTypeId, username, password, nombre, apellido, email, celular)
        {
            SupervisorAsociado = new Supervisor(idSupervisor);
        }

        //public Supervisor getLessStressedsupervisor ()
        //{
        //    int idLessStressedSupervisor = Connection.DabbawallaDB.SUPERVISOR.Count(x => )
        //    return new Supervisor
        //}

        public bool Read()
        {
            try
            {
                DABBAWALLA dab = Connection.DabbawallaDB.DABBAWALLA.First(dabba => dabba.ID_DABBAWALLA == IdDabbawalla);
                IdUsuario = dab.ID_USUARIO.Value;
                ReadUser();
                SupervisorAsociado = new Supervisor(dab.ID_SUPERVISOR_ASOCIADO.Value);
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
                    DABBAWALLA dab = new DABBAWALLA
                    {
                        ID_USUARIO = IdUsuario,
                        ID_SUPERVISOR_ASOCIADO = SupervisorAsociado.IdSupervisor
                    };
                    Connection.DabbawallaDB.DABBAWALLA.Add(dab);
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
    }
}
