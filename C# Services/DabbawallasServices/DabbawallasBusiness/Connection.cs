using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DabbawallasData;

namespace DabbawallasBusiness
{
    internal class Connection
    {
        private static DABBAWALLASEntities _dabbawallaDB;

        public static DABBAWALLASEntities DabbawallaDB
        {
            get
            {
                if (_dabbawallaDB == null)
                    _dabbawallaDB = new DABBAWALLASEntities();
                return _dabbawallaDB;
            }
            set
            {
                _dabbawallaDB = value;
            }
        }

    }
}
