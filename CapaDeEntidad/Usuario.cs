using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Usuarios
    {
        public int id { get; set; }
        public int id_Tipouser { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string usuario { get; set; }
        public DateTime fecha_alta { get; set; }
        public DateTime fecha_edit { get; set; }
        public string activo { get; set; }
    }
}
