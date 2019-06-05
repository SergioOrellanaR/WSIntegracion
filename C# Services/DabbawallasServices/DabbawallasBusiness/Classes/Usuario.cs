using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DabbawallasData;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DabbawallasBusiness.Classes
{
    public class Usuario
    {
        //[Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdUsuario { get; set; }
        public int? IdTipoUsuario { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
        public string Celular { get; set; }

        public Usuario(int? idTipoUsuario, string username, string password, string nombre, string apellido, string email, string celular)
        {
            IdTipoUsuario = idTipoUsuario;
            Username = username;
            Password = password;
            Nombre = nombre;
            Apellido = apellido;
            Email = email;
            Celular = celular;
        }

        public Usuario()
        {

        }

        public Usuario(int idUsuario)
        {
            IdUsuario = idUsuario;
            ReadUser();
        }

        public bool ReadUserByUsername(string username)
        {
            try
            {
                USUARIO user = Connection.DabbawallaDB.USUARIO.First(usuario => usuario.USERNAME == username);
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
            catch (Exception e)
            {
                string mes = e.Message;
                return false;
            }
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
            catch (Exception e)
            {
                string mes = e.Message;
                return false;
            }
        }

        public bool Login (string user, string pass)
        {
            try
            {
                USUARIO usuar = Connection.DabbawallaDB.USUARIO.First(usuario => usuario.USERNAME == user && usuario.PASSWORD == pass);
                IdUsuario = usuar.ID_USUARIO;
                ReadUser();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool CreateUser()
        {
            try
            {
                if (UsernameAlreadyExists())
                {
                    return false;
                }
                else
                {
                    USUARIO user = new USUARIO
                    {
                        ID_TIPO_USUARIO = IdTipoUsuario,
                        //user.ID_USUARIO = IdUsuario;
                        NOMBRE = Nombre,
                        APELLIDO = Apellido,
                        PASSWORD = Password,
                        USERNAME = Username,
                        CELULAR = Celular,
                        EMAIL = Email
                    };
                    Connection.DabbawallaDB.USUARIO.Add(user);
                    Connection.DabbawallaDB.SaveChanges();
                    IdUsuario = user.ID_USUARIO;
                    return true;
                }
            }
            catch(Exception e)
            {
                return false;
            }
        }

        public bool UsernameAlreadyExists()
        {
            try
            {
                Connection.DabbawallaDB.USUARIO.First(usr => usr.USERNAME.Equals(Username, StringComparison.InvariantCultureIgnoreCase));
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
