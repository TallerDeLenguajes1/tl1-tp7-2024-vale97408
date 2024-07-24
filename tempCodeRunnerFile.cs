// See https://aka.ms/new-console-template for more information

using EspacioCalculadora;

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
 