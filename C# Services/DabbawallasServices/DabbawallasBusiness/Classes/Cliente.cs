using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DabbawallasData;

namespace DabbawallasBusiness.Classes
{
    class Cliente : Usuario
    {
        public int IdCliente { get; set; }
        public string DireccionHogar { get; set; }
        public string DireccionTrabajo { get; set; }
        public int IdComunaHogar { get; set; }
        public int IdComunaTrabajo { get; set; }
        public int IdEstadoSuscripcion { get; set; }
        public Dabbawalla DabbawallaAsociado { get; set; }

        public Cliente(int idCliente)
        {
            IdCliente = IdCliente;
            Read();
        }

        public bool Read()
        {
            try
            {
                CLIENTE client = Connection.DabbawallaDB.CLIENTE.First(cl => cl.ID_CLIENTE == IdCliente);
                IdUsuario = client.ID_USUARIO.Value;
                ReadUser();
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
