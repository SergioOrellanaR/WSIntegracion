using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DabbawallasData;

namespace DabbawallasBusiness.Classes
{
    public class Ticket
    {
        public int IdTicket { get; set; }
        public Cliente ClienteEnvia { get; set; }
        public Cliente ClienteRecibe { get; set; }
        public int IdEstado { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime? FechaFinal { get; set; }
        public int Calificacion { get; set; }

        public Ticket(int idClienteEnvia, int idClienteRecibe)
        {
            int IdEstadoTicketAbierto = 1;
            ClienteEnvia = new Cliente(idClienteEnvia);
            ClienteRecibe = new Cliente(idClienteRecibe);
            IdEstado = IdEstadoTicketAbierto;
            FechaInicio = DateTime.Now;
            FechaFinal = null;
            Calificacion = 0;
        }

        public Ticket(string usernameClienteEnvia, string usernameClienteRecibe)
        {
            int IdEstadoTicketAbierto = 1;
            ClienteEnvia = new Cliente().SearchClientByUsername(usernameClienteEnvia);
            ClienteRecibe = new Cliente().SearchClientByUsername(usernameClienteRecibe);
            IdEstado = IdEstadoTicketAbierto;
            FechaInicio = DateTime.Now;
            FechaFinal = null;
            Calificacion = 0;
        }

        public bool Create()
        {
            try
            {
                int searchClientError = -1;
                if (ClienteEnvia.IdCliente != searchClientError && ClienteRecibe.IdCliente != searchClientError && ClienteEnvia.IdCliente != ClienteRecibe.IdCliente)
                {
                    TICKET ticket = new TICKET
                    {
                        ID_CLIENTE_ENVIA = ClienteEnvia.IdCliente,
                        ID_CLIENTE_RECIBE = ClienteRecibe.IdCliente,
                        ID_ESTADO = IdEstado,
                        FECHA_APERTURA = FechaInicio,
                        FECHA_CLAUSURA = FechaFinal,
                        CALIFICACION_SERVICIO = Calificacion
                    };
                    Connection.DabbawallaDB.TICKET.Add(ticket);
                    Connection.DabbawallaDB.SaveChanges();
                    IdTicket = ticket.ID_TICKET;
                    return true;
                }
                else
                {
                    throw new Exception("Error en busqueda de cliente");
                }
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool ReceiverUserHaveOpenTickets()
        {
            try
            {
                Connection.DabbawallaDB.TICKET.First(receiver => ClienteRecibe.IdCliente == receiver.ID_CLIENTE_RECIBE && receiver.ID_ESTADO != 5);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
