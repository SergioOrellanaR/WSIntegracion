﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DabbawallasData;

namespace DabbawallasBusiness.Classes
{
    public class Alerta
    {
        public int IdAlerta { get; set; }
        public Cliente ClienteAlerta { get; set; }
        public int IdTipoAlerta { get; set; }
        public DateTime FechaAlerta { get; set; }

        public Alerta(int idCliente)
        {
            int IdEstadoAlertaAbierta = 1;
            ClienteAlerta = new Cliente(idCliente);
            IdTipoAlerta = IdEstadoAlertaAbierta;
            FechaAlerta = DateTime.Now;
        }

        public Alerta(string usernameCliente)
        {
            int IdEstadoAlertaAbierta = 1;
            ClienteAlerta = new Cliente().SearchClientByUsername(usernameCliente);
            IdTipoAlerta = IdEstadoAlertaAbierta;
            FechaAlerta = DateTime.Now;
        }

        public bool Create()
        {
            try
            {
                int searchClientError = -1;
                if (ClienteAlerta.IdCliente != searchClientError)
                {
                    ALERTA alert = new ALERTA
                    {
                        ID_CLIENTE_ALERTA = ClienteAlerta.IdCliente,
                        ID_TIPO_ALERTA = IdTipoAlerta,
                        FECHA_ALERTA = FechaAlerta
                    };
                    Connection.DabbawallaDB.ALERTA.Add(alert);
                    Connection.DabbawallaDB.SaveChanges();
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
    }
}
