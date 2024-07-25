// See https://aka.ms/new-console-template for more information

using EspacioCalculadora;
using AdministracionEmpresa; 

Calculadora miCalculadora = new Calculadora();

        int control;
        Console.WriteLine("\n=============CALCULADORA===============\n");
        do
        {
            Console.WriteLine("\n1)Suma");
            Console.WriteLine("\n2) Resta");
            Console.WriteLine("\n3) Multiplicacion");
            Console.WriteLine("\n4)Division");
            Console.WriteLine("\n5)Limpiar");
            Console.WriteLine("\nOperacion a realizar: ");
            //string Respuesta = Console.ReadLine();

            double num = 0;
            int valorOperacion;

            if (int.TryParse(Console.ReadLine(), out valorOperacion))
            {
                if (valorOperacion <= 5 && valorOperacion > 0)
                {
                    if (valorOperacion != 5)
                    {
                        //string numero1;
                        do
                        {
                            Console.WriteLine("\nIngrese el primer numero: ");
                           // numero1 = Console.ReadLine();
                        } while (!double.TryParse(Console.ReadLine(), out num));
                    }

                    switch (valorOperacion)
                    {
                        case 1:
                            miCalculadora.Sumar(num);
                            Console.WriteLine("\nLa suma de los numeros es " + miCalculadora.Resultado);
                            break;
                        case 2:
                            miCalculadora.Restar(num);
                            Console.WriteLine("\nLa diferencia de los numeros es " + miCalculadora.Resultado);
                            break;
                        case 3:
                            miCalculadora.Multiplicar(num);
                            Console.WriteLine("\nEl producto de los numeros es " + miCalculadora.Resultado);
                            break;
                        case 4:
                            miCalculadora.Dividir(num);
                            Console.WriteLine("\nEl cociente de los numeros es " + miCalculadora.Resultado);
                            break;
                        case 5:
                            miCalculadora.Limpiar();
                            Console.WriteLine("\nEl dato limpio es: " + miCalculadora.Resultado);
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("\nOperacion invalida. Por favor ingrese un numero entre 1 y 5.");
                }
            }
            else
            {
                Console.WriteLine("\nEntrada invalida. Por favor ingrese un numero.");
            }

            Console.WriteLine("\nDesea seguir operando? 1)Si/ 0)No");
            //string seguirOperando = Console.ReadLine();
            if (!int.TryParse(Console.ReadLine(), out control))
            {
                control = 1;
            }

        } while (control != 0);
 

Console.WriteLine("\n=============EJERCICIO 2===============\n");
 

Empleados[] Empleados = new Empleados[3];

char estadoC;
string ingresa;
DateTime fechaNacim;
DateTime fechaIng;
double sueldoBasic;
int cargoDelEmpleado;

for (int i = 0; i < 3; i++)
{
    Empleados[i] = new Empleados();

    Console.WriteLine($"\n======Empleado NRO {i+1}======\n");
    Console.WriteLine("Nombre del empleado:\n");
    Empleados[i].Nombre = Console.ReadLine();

    Console.WriteLine("Apellido del empleado:\n");
    Empleados[i].Apellido = Console.ReadLine();

    Console.WriteLine("Fecha de nacimiento del empleado.\n");
    do
    {
        Console.WriteLine("\nFormato AAAA-MM-DD.");
        ingresa = Console.ReadLine();
    } while (!DateTime.TryParse(ingresa, out fechaNacim));
    Empleados[i].FechaNacimiento = fechaNacim;

    do
    {
        Console.WriteLine("Estado civil del empleado:\n");
        Console.WriteLine("[c]. Casado\n");
        Console.WriteLine("[s]. Soltero\n");
        ingresa = Console.ReadLine();
        
    } while (!char.TryParse(ingresa, out estadoC) || (estadoC != 'c' && estadoC != 's' && estadoC != 'C' && estadoC != 'S'));
    Empleados[i].EstadoCivil = estadoC;

    Console.WriteLine("Fecha de ingreso en la empresa del empleado:\n");
    do
    {
        Console.WriteLine("\nFormato AAAA-MM-DD.");
        ingresa = Console.ReadLine();
    } while (!DateTime.TryParse(ingresa, out fechaIng));
    Empleados[i].FechaIngreso = fechaIng;
    
    do
    {
        Console.WriteLine("Sueldo basico del empleado:\n");
        ingresa = Console.ReadLine();
    } while (!double.TryParse(ingresa, out sueldoBasic) || sueldoBasic < 0);
    Empleados[i].SueldoBasico = sueldoBasic;

    do
    {
        Console.WriteLine("Cargo del empleado.\n");
        Console.WriteLine("[1]. Auxiliar\n");
        Console.WriteLine("[2]. Administrativo\n");
        Console.WriteLine("[3]. Ingeniero\n");
        Console.WriteLine("[4]. Especialista\n");
        Console.WriteLine("[5]. Investigador\n");
        ingresa = Console.ReadLine();
    } while (!int.TryParse(ingresa, out cargoDelEmpleado) || cargoDelEmpleado >= 6 || cargoDelEmpleado <= 0);

    switch (cargoDelEmpleado)
    {
        case 1:
        Empleados[i].Cargo = Cargos.Auxiliar;
             break;
        case 2:
        Empleados[i].Cargo = Cargos.Administrativo;
             break;
        case 3:
        Empleados[i].Cargo = Cargos.Ingeniero;
             break;
        case 4:
        Empleados[i].Cargo = Cargos.Especialista;
             break;
        case 5:
        Empleados[i].Cargo = Cargos.Investigador;
             break;
    }
}


double totalSalarios = 0;
for (int i = 0; i < 3; i++)
{
    totalSalarios = totalSalarios + Empleados[i].Salario();
}
Console.WriteLine($"---El total pagado en concepto de salarios es: ${totalSalarios}\n");

int menos = 65;
for (int i = 0; i < 3; i++)
{
    if (Empleados[i].AniosParaJubilacion() <= menos)
    {
        menos = Empleados[i].AniosParaJubilacion();
    }
}

Console.WriteLine($"---EMPLEADOS PROXIMOS A JUBILARSE:\n");

for (int i = 0; i < 3; i++)
{
    int edadEmpleado = Empleados[i].Edad();
    int antiguedadEmpleado = Empleados[i].Antiguedad();
    double salarioEmp = Empleados[i].Salario();
    int aniosFaltantes = Empleados[i].AniosParaJubilacion();
    string fechaIngreso = Empleados[i].FechaIngreso.ToShortDateString();
    string fechaNacEmp = Empleados[i].FechaNacimiento.ToShortDateString();
    if (Empleados[i].AniosParaJubilacion() == menos)
    {
        Console.WriteLine($"\n------EMPLEADO NRO {i+1}------\n");
        Console.WriteLine($"--Apellido: {Empleados[i].Apellido}\n");
        Console.WriteLine($"--Nombre: {Empleados[i].Nombre}\n");
        Console.WriteLine($"--Fecha de nacimiento: {fechaNacEmp}\n");
        Console.WriteLine($"--Edad: {edadEmpleado} anios\n");
        Console.Write("--Estado civil: ");
        if (Empleados[i].EstadoCivil == 'c')
        {
            Console.Write("Casado\n\n");
        } else
        {
            Console.Write("Soltero\n\n");
        }
        Console.WriteLine($"--Fecha de ingreso a la empresa: {fechaIngreso}\n");
        Console.WriteLine($"--Antiguedad: {antiguedadEmpleado} anios\n");
        Console.WriteLine($"--Cargo: {Empleados[i].Cargo}\n");
        Console.WriteLine($"--Sueldo basico: ${Empleados[i].SueldoBasico}\n");
        Console.WriteLine($"--Salario: ${salarioEmp}\n");
        Console.WriteLine($"--Cantidad de anios faltantes para poder jubilarse: {aniosFaltantes}\n");
    }

}