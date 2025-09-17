namespace ClassLibrary1
{
    public abstract class Empleado
    {
        protected Empleado(string nombre, string apellido, string nss)
        {
            this.primerNombre = nombre;
            this.apellidoPaterno = apellido;
            this.numeroSeguroSocial = nss;
        }

        public string PrimerNombre
        {
            get { return primerNombre; }
            set { primerNombre = value; }
        }
        public string ApellidoPaterno
        {
            get { return apellidoPaterno; }
            set { apellidoPaterno = value; }
        }
        public string NumeroSeguroSocial
        {
            get { return numeroSeguroSocial; }
            set { numeroSeguroSocial = value; }
        }
        public override string ToString()
        {
            return string.Format("{0} {1} || NSS: {2}", PrimerNombre, ApellidoPaterno, NumeroSeguroSocial);
        }
        public virtual string TipoEmpleado
        {
            get { return tipoEmpleado; }
        }
        public abstract decimal Ingresos(); 

        protected string primerNombre;
        protected string apellidoPaterno;
        protected string numeroSeguroSocial;
        protected string tipoEmpleado;
    }
}
