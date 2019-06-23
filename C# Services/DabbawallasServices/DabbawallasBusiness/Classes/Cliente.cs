using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DabbawallasData;

namespace DabbawallasBusiness.Classes
{
    public class Cliente : Usuario
    {
        private const int ClienteTypeId = 1;
        public int IdCliente { get; set; }
        public string DireccionHogar { get; set; }
        public string DireccionTrabajo { get; set; }
        public int IdComunaHogar { get; set; }
        public int IdComunaTrabajo { get; set; }
        public int IdEstadoSuscripcion { get; set; }
        public Dabbawalla DabbawallaAsociado { get; set; }

        public Cliente()
        {

        }

        public Cliente(int idCliente)
        {
            IdCliente = idCliente;
            if (Read() == false)
            {
                IdCliente = -1;
            }
        }

        public Cliente(string direccionHogar, string direccionTrabajo, int idComunaHogar, int idComunaTrabajo, int idEstadoSuscripcion,
            string username, string password, string nombre, string apellido, string email, string celular) 
            : base(ClienteTypeId, username, password, nombre, apellido, email, celular)
        {
            DireccionHogar = direccionHogar;
            DireccionTrabajo = direccionTrabajo;
            IdComunaHogar = idComunaHogar;
            IdComunaTrabajo = idComunaTrabajo;
            IdEstadoSuscripcion = idEstadoSuscripcion;
            DabbawallaAsociado = getLessAssociatedClientsDabbawallas();
        }

        public bool Read()
        {
            try
            {
                CLIENTE client = Connection.DabbawallaDB.CLIENTE.First(cl => cl.ID_CLIENTE == IdCliente);
                Connection.DabbawallaDB.Entry<CLIENTE>(client).Reload();
                IdUsuario = client.ID_USUARIO.Value;
                ReadUser();
                IdEstadoSuscripcion = client.ID_ESTADO_SUSCRIPCION.Value;
                DireccionHogar = client.DIRECCION_HOGAR;
                DireccionTrabajo = client.DIRECCION_TRABAJO;
                IdComunaHogar = client.ID_COMUNA_HOGAR.Value;
                IdComunaTrabajo = client.ID_COMUNA_TRABAJO.Value;
                DabbawallaAsociado = new Dabbawalla(client.ID_DABBAWALLA_ASOCIADO.Value);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool ActivateSuscription()
        {
            try
            {
                CLIENTE client = Connection.DabbawallaDB.CLIENTE.First(cl => cl.ID_CLIENTE == IdCliente);
                client.ID_ESTADO_SUSCRIPCION = 1;
                Connection.DabbawallaDB.SaveChanges();
                //Connection.DabbawallaDB.Dispose();
                //Context.Entry<T>(entity).Reload();
                return true;
            }
            catch (Exception)
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
                    CLIENTE cli = new CLIENTE
                    {
                        ID_USUARIO = IdUsuario,
                        DIRECCION_HOGAR = DireccionHogar,
                        DIRECCION_TRABAJO = DireccionTrabajo,
                        ID_COMUNA_HOGAR = IdComunaHogar,
                        ID_COMUNA_TRABAJO = IdComunaTrabajo,
                        ID_ESTADO_SUSCRIPCION = IdEstadoSuscripcion,
                        ID_DABBAWALLA_ASOCIADO = DabbawallaAsociado.IdDabbawalla
                    };
                    Connection.DabbawallaDB.CLIENTE.Add(cli);
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

        public Cliente SearchClientByUsername(string username)
        {
            try
            {
                int UserId = Connection.DabbawallaDB.USUARIO.First(usr => usr.USERNAME.Equals(username, StringComparison.InvariantCultureIgnoreCase)).ID_USUARIO;
                int clientId = Connection.DabbawallaDB.CLIENTE.First(cli => cli.ID_USUARIO == UserId).ID_CLIENTE;
                return new Cliente(clientId);
            }
            catch
            {
                int clientError = -1;
                return new Cliente() { IdCliente = clientError};
            }
        }

        public Supervisor AssociatedSupervisor()
        {
            return DabbawallaAsociado.SupervisorAsociado;
        }

        public string nombreComuna (int idComuna)
        {
            return Connection.DabbawallaDB.COMUNA.First(com => com.ID_COMUNA == idComuna).COMUNA1;
        }

        public Dabbawalla getLessAssociatedClientsDabbawallas()
        {
            Dabbawalla dabbawalla;
            try
            {
                int idDabbawalla = Connection.DabbawallaDB.VISTA_CANTIDAD_CLIENTES_POR_DABBAWALLA.OrderBy(x => x.Clientes_Asociados).First().ID_DABBAWALLA;
                dabbawalla = new Dabbawalla(idDabbawalla);
            }
            catch
            {
                int idInvalidDabbawalla = -1;
                dabbawalla = new Dabbawalla()
                {
                    IdDabbawalla = idInvalidDabbawalla
                };
            }
            return dabbawalla;
        }

        public string AddressAndComune (string address, int idComuna)
        {
            return address + ", " + nombreComuna(idComuna);
        }
    }
}
