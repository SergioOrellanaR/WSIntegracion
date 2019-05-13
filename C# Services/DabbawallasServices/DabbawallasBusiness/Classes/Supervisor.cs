﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DabbawallasData;

namespace DabbawallasBusiness.Classes
{
    class Supervisor : Usuario
    {
        private const int SupervisorTypeId = 3;
        public int IdSupervisor { get; set; }
        public int IdZona { get; set; }

        public Supervisor(int idSupervisor)
        {
            IdSupervisor = IdSupervisor;
            Read();
        }

        public Supervisor(int idzona, string username, string password, string nombre, string apellido, string email, string celular) 
            : base(SupervisorTypeId, username,password,nombre,apellido,email,celular)
        {
            IdZona = idzona;
        }

        public bool Read()
        {
            try
            {
                SUPERVISOR dab = Connection.DabbawallaDB.SUPERVISOR.First(sup => sup.ID_SUPERVISOR == IdSupervisor);
                IdUsuario = dab.ID_USUARIO.Value;
                ReadUser();
                IdZona = dab.ID_ZONA.Value;
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
                if (CreateUser())
                {
                    SUPERVISOR sup = new SUPERVISOR
                    {
                        ID_ZONA = IdZona,
                        ID_USUARIO = IdUsuario
                    };
                    Connection.DabbawallaDB.SUPERVISOR.Add(sup);
                    Connection.DabbawallaDB.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
