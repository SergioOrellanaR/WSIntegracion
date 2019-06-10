using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Threading;
using DabbawallasREST.Models;
using DabbawallasBusiness.Classes;
namespace DabbawallasREST.Controllers
{
    /// <summary>
    /// login controller class for authenticate users
    /// </summary>
    [AllowAnonymous]
    [RoutePrefix("dabbawallas/login")]
    public class LoginController : ApiController
    {
        //[HttpGet]
        //[Route("echoping")]
        //public IHttpActionResult EchoPing()
        //{
        //    return Ok(true);
        //}

        //[HttpGet]
        //[Route("echouser")]
        //public IHttpActionResult EchoUser()
        //{
        //    var identity = Thread.CurrentPrincipal.Identity;
        //    return Ok($" IPrincipal-user: {identity.Name} - IsAuthenticated: {identity.IsAuthenticated}");
        //}

        [HttpPost]
        [Route("authenticate")]
        public IHttpActionResult Authenticate(LoginRequest login)
        {
            if (login == null || login.PropertiesAreNullOrEmpty())
                return BadRequest();

            Usuario user = new Usuario();
            bool isCredentialValid = user.Login(login.Username, login.Password);

            if (isCredentialValid)
            {
                var token = TokenGenerator.GenerateTokenJwt(login.Username);
                Models.Responses.LoginResponse response = new Models.Responses.LoginResponse()
                {
                    IdTipoUsuario = user.IdTipoUsuario.Value,
                    IdUsuario = user.IdUsuario,
                    Username = user.Username,
                    Nombre = user.Nombre,
                    Apellido = user.Apellido,
                    JWT = token
                };
                return Ok(response);
            }
            else
            {
                return Unauthorized();
            }
        }
    }
}
