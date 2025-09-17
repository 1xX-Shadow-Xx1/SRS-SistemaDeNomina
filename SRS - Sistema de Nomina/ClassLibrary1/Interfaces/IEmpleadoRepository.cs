using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Interfaces
{
    public interface IEmpleadoRepository
    {
        List<Empleado> ObtenerEmpleados();
        Empleado ObtenerEmpleadoPorNSS(string nss);
        void AgregarEmpleado(Empleado empleado);
        void EliminarEmpleado(string nss);
        void ActualizarEmpleado(Empleado empleado, string nss);
    }
}
