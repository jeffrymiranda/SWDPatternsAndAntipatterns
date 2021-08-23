using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.SpaghettiAntipattern
{
    public class UsuarioDAL
    {
        public List<string> listaNombresUsuarios()
        {
            #region lista usuarios code
            List<string> usuarios = new List<string>
            {
                "Kristel","Jarquin","Lanzas"
            };

            return usuarios;

            #endregion
        }
    }
}
