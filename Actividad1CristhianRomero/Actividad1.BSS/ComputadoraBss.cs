using Actividad1.DAL;
using Actividad1.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad1.BSS
{
    public class ComputadoraBss
    {
        ComputadoraDal dal = new ComputadoraDal();
        public DataTable ListarComputadoraBss()
        {
            return dal.ListarComputadoraDal();
        }
        public void InsertarComputadoraBss(Computadora computadora)
        {
            dal.InsertarComputadoraDal(computadora);
        }
        public Computadora ObtenerComputadoraIdBss(int idc)
        {
            return dal.ObtenerComputadoraIdDal(idc);
        }
        public void EditarComputadoraBss(Computadora c)
        {
            dal.EditarComputadoraDal(c);
        }
        public void EliminarComputadoraBss(int idc)
        {
            dal.EliminarComputadoraDal(idc);
        }
    }
}
