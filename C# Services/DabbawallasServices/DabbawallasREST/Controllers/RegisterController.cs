using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DabbawallasREST.Models;
using DabbawallasBusiness.Classes;

namespace DabbawallasREST.Controllers
{
    [AllowAnonymous]
    [RoutePrefix("dabbawallas/register")]
    public class RegisterController : ApiController
    {
        [HttpPost]
        [Route("supervisor")]
        public IHttpActionResult RegisterSupervisor(RegisterSupervisorRequest registerData)
        {
            int invalidZone = -1;
            if (registerData == null)
                return BadRequest();

            Supervisor supervisor = new Supervisor(registerData.Zona, registerData.Username, registerData.Password,
                registerData.Nombre, registerData.Apellido, registerData.Email, registerData.Celular);

            if (supervisor.IdZona != invalidZone && supervisor.Create() == true)
            {
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpPost]
        [Route("dabbawalla")]
        public IHttpActionResult RegisterDabbawalla(RegisterDabbawallaRequest registerData)
        {
            int NotFoundSupervisor = -1;
            if (registerData == null)
                return BadRequest();

            Dabbawalla dab = new Dabbawalla(registerData.IdSupervisorAsociado, registerData.Username, registerData.Password,
                registerData.Nombre, registerData.Apellido, registerData.Email, registerData.Celular);

            if (dab.SupervisorAsociado.IdSupervisor != NotFoundSupervisor && dab.Create() == true)
            {
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpPost]
        [Route("cliente")]
        public IHttpActionResult RegisterDabbawalla(RegisterClientRequest registerData)
        {
            int inactiveSuscription = 0;
            int invalidDabbawalla = -1;
            if (registerData == null)
                return BadRequest();

            Cliente client = new Cliente(registerData.DireccionHogar, registerData.DireccionTrabajo, registerData.IdComunaHogar,
                registerData.IdComunaTrabajo, inactiveSuscription, registerData.IdDabbawalla, registerData.Username,
                registerData.Password, registerData.Nombre, registerData.Apellido, registerData.Email, registerData.Celular);

            if (client.DabbawallaAsociado.IdDabbawalla != invalidDabbawalla && client.Create() == true)
            {
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }
    }
}
