using ClassLibrary1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class EmpleadoAsalariadoPorComision : EmpleadoPorComision, IEmpleadoAsalariadoPorComision
    {

        public EmpleadoAsalariadoPorComision(string nombre, string apellido, string nss, decimal tarifaComision, decimal venta, decimal salariobase) 
            : base(nombre, apellido, nss, tarifaComision, venta)
        {
            this.SalarioBase = salariobase;
        }

        public decimal SalarioBase
        {
            get { return salarioBase; }
            set
            {
                if (value >= 0) salarioBase = value;
                else
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(salarioBase)} debe ser mayor o igual que 0");
                }
            }
        }
        public override decimal Ingresos() => salarioBase + base.Ingresos();

        public override string ToString() =>
            $"Empleado asalariado por comisión: {base.ToString()} || " +
            $"Salario base: {salarioBase:C}$";
        public override string TipoEmpleado
        {
            get { return "Empleado Asalariado por Comisión"; }
        }

        private decimal salarioBase;

    }
}
