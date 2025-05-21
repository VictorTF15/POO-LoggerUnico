using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggerUnico
{
    class Logger
    {
        private static Logger instancia;
        private Logger() { }
        public static Logger GetInstancia()
        {
            if (instancia == null)
            {
                instancia = new Logger();
            }
            return instancia;
        }
        public string Log(string mensaje)
        {
            return $"[LOG]: {mensaje}";
        }
    }
}
