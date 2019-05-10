using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DabbawallasData;

namespace DabbawallasBusiness.Classes
{
    class Usuario
    {
        public int IdUsuario { get; set; }
        public int? IdTipoUsuario { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
        public string Celular { get; set; }

        public Usuario()
        {

        }

        public Usuario(int idUsuario)
        {
            IdUsuario = idUsuario;
            ReadUser();
        }

        public bool ReadUser()
        {
            try
            {
                USUARIO user = Connection.DabbawallaDB.USUARIO.First(usuario => usuario.ID_USUARIO == IdUsuario);
                IdUsuario = user.ID_USUARIO;
                IdTipoUsuario = user.ID_TIPO_USUARIO;
                Username = user.USERNAME;
                Password = user.PASSWORD;
                Nombre = user.NOMBRE;
                Apellido = user.APELLIDO;
                Email = user.EMAIL;
                Celular = user.CELULAR;
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Login (string user, string pass)
        {
            try
            {
                //ToDo
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
