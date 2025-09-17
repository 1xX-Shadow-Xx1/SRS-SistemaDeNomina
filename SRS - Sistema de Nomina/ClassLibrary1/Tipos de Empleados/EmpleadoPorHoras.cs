using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class EmpleadoPorHoras : Empleado
    {
        public EmpleadoPorHoras(string nombre, string apellido, string nss, decimal sueldoPorHora, int horasTrabajadas) : base(nombre, apellido, nss)
        {
            this.SueldoPorHora = sueldoPorHora;
            this.HorasTrabajadas = horasTrabajadas;
        }

        public decimal SueldoPorHora
        {
            get { return sueldoPorHora; }
            set
            {
                if(value >= 0) 
                    sueldoPorHora = value;
                
                else 
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(sueldoPorHora)} debe ser mayor o igual que 0");
            }
        }
        public int HorasTrabajadas
        {
            get { return horasTrabajadas; }
            set
            {
                if (value >= 0)
                    horasTrabajadas = value;

                else
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(horasTrabajadas)} debe ser mayor o igual que 0");
            }
        }
        public override decimal Ingresos()
        {
            if (horasTrabajadas <= 40)
                return sueldoPorHora * horasTrabajadas;
            else
                return (40 * sueldoPorHora) + ((horasTrabajadas - 40) * sueldoPorHora * 1.5M);
        }
        public override string ToString()
        {
            return string.Format(
                "Empleado por horas:  {0}\n{1}: {2}$; {3}: {4:F2}h",
                base.ToString(), "sueldo por horas", sueldoPorHora, "horas trabajadas", horasTrabajadas);
        }
        public override string TipoEmpleado
        {
            get { return "Empleado por Horas"; }
        }

        private decimal sueldoPorHora;
        private int horasTrabajadas;
        private string nombre;
    }
}
