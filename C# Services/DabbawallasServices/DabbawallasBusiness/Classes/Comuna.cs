using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DabbawallasData;

namespace DabbawallasBusiness.Classes
{
    public class Comuna
    {
        public int IdComuna { get; set; }
        public string NombreComuna { get; set; }
        public int IdProvincia { get; set; }

        public Comuna()
        {

        }

        public Comuna(string comunaName)
        {
            if (ReadComunaByName(comunaName) == false)
            {
                IdComuna = -1;
            }
        }

        public List<Comuna> ListAllComunas ()
        {
            List<Comuna> listComuna = new List<Comuna>();
            List<COMUNA> databaseComunaList = Connection.DabbawallaDB.COMUNA.ToList();

            foreach (COMUNA com in databaseComunaList)
            {
                Comuna comuna = new Comuna()
                {
                    IdComuna = com.ID_COMUNA,
                    IdProvincia = com.ID_PROVINCIA.Value,
                    NombreComuna = com.COMUNA1
                };

                listComuna.Add(comuna);
            }

            return listComuna;
        }

        public bool ReadComunaByName (string comunaName)
        {
            try
            {
                COMUNA com = Connection.DabbawallaDB.COMUNA.First(x => x.COMUNA1 == comunaName);
                IdComuna = com.ID_COMUNA;
                IdProvincia = com.ID_PROVINCIA.Value;
                NombreComuna = com.COMUNA1;
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public List<string> ListAllComunasNames ()
        {
            List<Comuna> listComuna = ListAllComunas();
            List<string> comunas = new List<string>();

            foreach (Comuna com in ListAllComunas())
            {
                comunas.Add(com.NombreComuna);
            }

            return comunas;
        }
    }
}
