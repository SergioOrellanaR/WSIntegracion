using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DabbawallasBusiness
{
    enum Zona
    {
        A = 1,
        B = 2,
        C = 3
    }

    enum EstadoTicket
    {
	    ABIERTO = 1,
	    CERRADO = 5
    }

    enum TipoUsuario
    {
        Cliente = 1,
        Dabbawalla = 2,
        Supervisor = 3
    }

    enum TipoAlerta
    {
        Cerrado = 0,
        Abierto = 1
    }
}
