using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.SpaghettiAntipattern
{
    public class Reportes
    {
        public void generarReporteUsuarios()
        {
            List<string> usuarios = new UsuarioDAL().listaNombresUsuarios();
            foreach (string nombre in usuarios) {
                Debug.WriteLine("Nombre: " + nombre);
            }
        }
    }
}
