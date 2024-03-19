using Actividad1.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad1.DAL
{
   
    public class ComputadoraDal
    {
        public DataTable ListarComputadoraDal()
        {
            string consulta = "select * from computadora";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "table");
            return lista;
        }
        public void InsertarComputadoraDal(Computadora computadora)
        {
            string consulta = "insert into computadora values('" + computadora.Nombre + "'," +
                                                         "'" + computadora.Descripcion + "'," +
                                                         "" + computadora.Precio + "," +
                                                         "'" + computadora.FechaDeFabricacion + "' )";
            conexion.Ejecutar(consulta);
        }
        Computadora c = new Computadora();
        public Computadora ObtenerComputadoraIdDal(int id)
        {
            string consulta = "select * from computadora where idcomputadora=" + id;
            DataTable tabla = conexion.EjecutarDataTabla(consulta, "table");
            if (tabla.Rows.Count > 0)
            {
                c.IdComputadora = Convert.ToInt32(tabla.Rows[0]["idcomputadora"]);
                c.Nombre = tabla.Rows[0]["nombre"].ToString();
                c.Descripcion = tabla.Rows[0]["descripcion"].ToString();
                c.Precio = Convert.ToDecimal(tabla.Rows[0]["precio"]);
                c.FechaDeFabricacion = Convert.ToDateTime(tabla.Rows[0]["fechadefabricacion"]);

            }
            return c;
        }
        public void EditarComputadoraDal(Computadora c)
        {
            string consulta = "update computadora set nombre='" + c.Nombre + "'," +
                                                        "descripcion='" + c.Descripcion + "'," +
                                                        "precio=" + c.Precio+ "," +
                                                        "fechadefabricacion='" + c.FechaDeFabricacion +"' "+ 
                                                "where idcomputadora=" + c.IdComputadora;
            conexion.Ejecutar(consulta);
        }
        public void EliminarComputadoraDal(int id)
        {
            string consulta = "delete from computadora where idcomputadora=" + id;
            conexion.Ejecutar(consulta);
        }
    }
}
