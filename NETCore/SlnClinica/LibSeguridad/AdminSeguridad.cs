using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibSeguridad
{
    public class AdminSeguridad
    {
        public AdminSeguridad(string nombreUsuario, string contrasena)
        {
            NombreUsuario = nombreUsuario;
            Contrasena = contrasena;
        }

        public string NombreUsuario { get; set; }
        public string Contrasena { get; set; }

        public bool LoginUser (string usuario, string contrasena)
        {
            bool resultado = false;

            if(usuario == "PEPE" && contrasena == "123456")
            {
                resultado = true;
            }

            return resultado;
        }
    }
}
