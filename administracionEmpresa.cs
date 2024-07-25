namespace AdministracionEmpresa
 {

    class Empleados
    {
        string nombre;
        string apellido;
        DateTime fechaNacimiento;
        char estadoCivil;
        DateTime fechaIngreso;
        double sueldoBasico;

        Cargos cargo;

        public string Nombre {get => nombre; set => nombre = value; }

        public string Apellido { get => apellido; set => apellido = value; }

        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }

        public char EstadoCivil { get => estadoCivil; set => estadoCivil = value; }

        public DateTime FechaIngreso { get => fechaIngreso; set => fechaIngreso = value; }

        public double SueldoBasico { get => sueldoBasico; set => sueldoBasico = value; }

        public Cargos Cargo { get => cargo; set => cargo = value; }

        public int Antiguedad()
        {
            DateTime fechaActual = DateTime.Now;
            int antiguedad =  fechaActual.Year - fechaIngreso.Year;
            if(fechaActual.Month < fechaIngreso.Month || (fechaActual.Month == fechaIngreso.Month && fechaActual.Day<fechaIngreso.Day)){
                antiguedad--;
            }
            return antiguedad;
        }
        public int Edad()
        {
            DateTime fechaActual = DateTime.Now;
            int antiguedad =  fechaActual.Year - fechaNacimiento.Year;
            if(fechaActual.Month < fechaNacimiento.Month || (fechaActual.Month == fechaNacimiento.Month && fechaActual.Day<fechaNacimiento.Day)){
                antiguedad--;
            }
            return antiguedad;
        }
        public int AniosParaJubilacion()
        {
            int edad = Edad();
            int aniosRestantes = 65 - edad;
            return aniosRestantes; 
        }
        
        public double Salario()
        {
            double Adicional;
            if(Antiguedad()< 20)
            {
                Adicional = SueldoBasico * (Antiguedad()/100);
            }else
            {
                Adicional = SueldoBasico * 0.25;
            }
            if (cargo == Cargos.Ingeniero ||cargo == Cargos.Especialista )
            {
                Adicional = Adicional* 1.50;
            }
            if(estadoCivil == 'c'||estadoCivil == 'C' )
            {
                Adicional = Adicional+ 150000;
            }
            double salario= sueldoBasico+ Adicional;
            return salario;
        }
    }
    
}
    