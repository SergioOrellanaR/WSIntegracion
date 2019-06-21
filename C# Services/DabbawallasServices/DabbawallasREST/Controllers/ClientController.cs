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
    [RoutePrefix("dabbawallas/clientes")]
    public class ClientController : ApiController
    {
        [HttpPost]
        [Route("abrir_ticket")]
        public IHttpActionResult OpenTicket(OpenTicketRequest request)
        {
            if (request == null || string.IsNullOrEmpty(request.UsernameClienteRecibe) || string.IsNullOrEmpty(request.UsernameClienteEnvia))
            {
                return BadRequest();
            }

            Ticket ticket = new Ticket(request.UsernameClienteEnvia, request.UsernameClienteRecibe);

            int inactiveSuscription = 0;
            if (ticket.ClienteRecibe.IdEstadoSuscripcion == inactiveSuscription || ticket.ReceiverUserHaveOpenTickets())
            {
                return Unauthorized();
            }

            if (ticket.Create())
            {
                Models.Responses.TicketResponse response = new Models.Responses.TicketResponse()
                {
                    FechaDeAperturaDeTicket = ticket.FechaInicio.ToString("MM/dd/yyyy HH:mm"),
                    IdTicket = ticket.IdTicket,
                    IdClienteEnvia = ticket.ClienteEnvia.IdCliente,
                    ComunaHogarClienteEnvia = ticket.ClienteEnvia.nombreComuna(ticket.ClienteEnvia.IdComunaHogar),
                    ComunaTrabajoClienteRecibe = ticket.ClienteRecibe.nombreComuna(ticket.ClienteRecibe.IdComunaTrabajo),
                    DireccionHogarClienteEnvia = ticket.ClienteEnvia.DireccionHogar,
                    DireccionTrabajoClienteRecibe = ticket.ClienteRecibe.DireccionTrabajo,
                    IdClienteRecibe = ticket.ClienteRecibe.IdCliente,
                    IdComunaHogarClienteEnvia = ticket.ClienteEnvia.IdComunaHogar,
                    IdComunaTrabajoClienteRecibe = ticket.ClienteRecibe.IdComunaTrabajo,
                    IdDabbawallaEncargado = ticket.ClienteEnvia.DabbawallaAsociado.IdDabbawalla,
                    UsernameClienteEnvia = ticket.ClienteEnvia.Username,
                    UsernameClienteRecibe = ticket.ClienteRecibe.Username,
                    UsernameDabbawallaEncargado = ticket.ClienteEnvia.DabbawallaAsociado.Username
                };
                return Ok(response);
            }
            else
            {
                return InternalServerError();
            }
        }

        [HttpPost]
        [Route("enviar_alerta")]
        public IHttpActionResult SendAlert(GenericClientRequest request)
        {
            if (request == null || string.IsNullOrEmpty(request.Username))
            {
                return BadRequest();
            }

            Alerta alert = new Alerta(request.Username);

            int inactiveSuscription = 0;
            if (alert.ClienteAlerta.IdEstadoSuscripcion == inactiveSuscription)
            {
                return Unauthorized();
            }

            if (alert.Create())
            {
                Models.Responses.AlertResponse response = new Models.Responses.AlertResponse()
                {
                    FechaInicioAlerta = alert.FechaAlerta.ToString("MM/dd/yyyy HH:mm"),
                    IdClienteAlerta = alert.ClienteAlerta.IdCliente,
                    UsernameClienteAlerta = alert.ClienteAlerta.Username,
                    IdDabbawallaAlertado = alert.ClienteAlerta.DabbawallaAsociado.IdDabbawalla,
                    UsernameDabbawallaAlertado = alert.ClienteAlerta.DabbawallaAsociado.Username,
                    IdSupervisorRecibeAlerta = alert.ClienteAlerta.AssociatedSupervisor().IdSupervisor,
                    UsernameSupervisorAlertado = alert.ClienteAlerta.AssociatedSupervisor().Username,
                    CelularSupervisorAlertado = alert.ClienteAlerta.AssociatedSupervisor().Celular
                };
                return Ok(response);
            }
            else
            {
                return InternalServerError();
            }
        }

        [HttpPut]
        [Route("activar_suscripcion")]
        public IHttpActionResult ActivateSuscription(GenericClientRequest request)
        {
            if (request == null || string.IsNullOrEmpty(request.Username))
            {
                return BadRequest();
            }

            Cliente client = new Cliente().SearchClientByUsername(request.Username);
            int idClientError = -1;

            if (client.IdCliente != idClientError)
            {
                int InactiveSuscription = 0;
                if (client.IdEstadoSuscripcion == InactiveSuscription)
                {
                    client.ActivateSuscription();
                    return Ok("Suscripción activada");
                }
                else
                {
                    return BadRequest("El cliente ya tiene una suscripción activa");
                }
            }
            else
            {
                return InternalServerError();
            }
        }
    }
}
