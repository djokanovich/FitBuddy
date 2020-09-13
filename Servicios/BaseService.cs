using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios
{
    public class BaseService
    {
        protected LogManager LogManager;
        public BaseService()
        {

            LogManager = new LogManager();
        }
    }

 
}
