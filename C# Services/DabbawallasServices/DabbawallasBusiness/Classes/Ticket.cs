using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DabbawallasBusiness.Classes
{
    class Ticket
    {
        public int IdTicket { get; set; }
        public Cliente ClienteEnvia { get; set; }
        public Cliente ClienteRecibe { get; set; }
        public int idEstado { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime? FechaFinal { get; set; }
        public int? Calificacion { get; set; }

        public Ticket()
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
    }
}
