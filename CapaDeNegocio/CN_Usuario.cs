using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//importamos la referencia a la capa datos
using CapaDeDatos;
//importamos la capa de entidad 
using CapaEntidad;
namespace CapaDeNegocio
{
    public class CN_Usuario
    {
        //instancia de la clase usuario de la capa dato 
        private CD_Usuarios objcd_usuario = new CD_Usuarios();

        public List<Usuarios> Listar()
        {
            return objcd_usuario.Listar();
        }
    }
}
