namespace ejercicio2
{
    internal class Program
    {
        static int monto;
        static int nena1, nena2, nena3, nena4;
        static int sumaEdades;
        static double porcentajeNena1, porcentajeNena2, porcentajeNena3, porcentajeNena4;

        static void Main(string[] args)
        {
            Console.WriteLine("ingrese una opcion");

            int opcion;
            do
            {
                opcion = solicitarUnaOpcion();
                Console.Clear();
                switch (opcion)
                {
                    case 1:
                        solicitarMontoRepartir();
                        break;
                    case 2:
                        solicitarEdadPorNiña();
                            break; 
                    case 3:
                        calcularYMostrarMontoYPorcentajes();
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Por favor, intente de nuevo.");
                        break;
                }


            } while (opcion != 0);


        }
        static int solicitarUnaOpcion()
        {
            Console.WriteLine("1 - Iniciar Monto a repartir");
            Console.WriteLine("2 - Solicitar Edad Por niña");
            Console.WriteLine("3 - Mostrar monto y porcentajes que corresponde a cada niña.");


            int opcion;
            if (!int.TryParse(Console.ReadLine(), out opcion))
            {
                opcion = -1; 
            }

            return opcion;
        }

        static void solicitarMontoRepartir()
        {
            Console.WriteLine("Ingrese el monto a repartir entre las niñas:");
            monto = int.Parse(Console.ReadLine());
        }

        static void solicitarEdadPorNiña()
        {
            Console.WriteLine("Ingrese la edad de la primera niña:");
            nena1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la edad de la segunda niña:");
            nena2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la edad de la tercera niña:");
            nena3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la edad de la cuarta niña:");
            nena4 = int.Parse(Console.ReadLine());
            sumaEdades = nena1 + nena2 + nena3 + nena4;
        }
        static void calcularYMostrarMontoYPorcentajes()
        {
            #region calcualr monto
            porcentajeNena1 = (nena1 / (double)sumaEdades) * monto;
            porcentajeNena2 = (nena2 / (double)sumaEdades) * monto;
            porcentajeNena3 = (nena3 / (double)sumaEdades) * monto;
            porcentajeNena4 = (nena4 / (double)sumaEdades) * monto;

            Console.WriteLine($"Monto que corresponde a la primera niña: {porcentajeNena1}");
            Console.WriteLine($"Monto que corresponde a la segunda niña: {porcentajeNena2}");
            Console.WriteLine($"Monto que corresponde a la tercera niña: {porcentajeNena3}");
            Console.WriteLine($"Monto que corresponde a la cuarta niña: {porcentajeNena4}");
            #endregion
        }
    }
    }
