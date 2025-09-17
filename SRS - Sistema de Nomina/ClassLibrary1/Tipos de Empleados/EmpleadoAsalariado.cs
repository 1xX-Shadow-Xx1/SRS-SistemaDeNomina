using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class EmpleadoAsalariado: Empleado
    {
        public EmpleadoAsalariado(string nombre, string apellido, string nss, decimal salarioSemanal)
            : base(nombre, apellido, nss)
        {
            SalarioSemanal = salarioSemanal; 
        }
        public decimal SalarioSemanal
        {
            get { return salarioSemanal; }
            set
            {
                if (value >= 0)
                    salarioSemanal = value;
                else
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(salarioSemanal)} debe ser mayor o igual que 0");
            }
        }
        public override decimal Ingresos() => SalarioSemanal;
        public override string ToString() =>
            $"Empleado asalariado: {base.ToString()} || " +
            $"Salario semanal: {SalarioSemanal:C}";
        public override string TipoEmpleado
        {
            get { return "Empleado Asalariado"; }
        }

        private decimal salarioSemanal;
    }
}
