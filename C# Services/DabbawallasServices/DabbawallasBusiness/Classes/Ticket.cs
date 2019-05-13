using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DabbawallasData;

namespace DabbawallasBusiness.Classes
{
    class Ticket
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

        public bool Create()
        {
            try
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
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
