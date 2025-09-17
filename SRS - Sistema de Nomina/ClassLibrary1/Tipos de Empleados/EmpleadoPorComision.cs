using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class EmpleadoPorComision : Empleado
    {
        public EmpleadoPorComision(string nombre, string apellido, string nss, decimal tarifaComision, decimal venta)
            : base(nombre, apellido, nss)
        {
            this.TarifaComision = tarifaComision;
            this.VentasBrutas = venta;
        }
        public decimal VentasBrutas
        {
            get { return ventasBrutas; }
            set
            {
                if (value >= 0)
                    ventasBrutas = value;
                else
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(ventasBrutas)} debe ser mayor o igual que 0");
            }
        }
        public decimal TarifaComision
        {
            get { return tarifaComision; }
            set
            {
                if (value > 0 && value < 1)
                    tarifaComision = value;
                else
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(tarifaComision)} debe ser > 0 y < 1");
            }
        }
        public override decimal Ingresos() => tarifaComision * ventasBrutas;

        public override string ToString() =>
            string.Format("empleado por comisión: {0}\n{1}: {2:C}; {3}: {4:F2}",
            base.ToString(), "ventas brutas", ventasBrutas, "tarifa de comisión", tarifaComision);
        public override string TipoEmpleado
        {
            get { return "Empleado por Comisión"; }
        }

        private decimal ventasBrutas; 
        private decimal tarifaComision; 
    }
}
