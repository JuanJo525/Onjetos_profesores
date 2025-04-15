using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Onjetos_profesores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion = 1;
            Cls_Profe P = new Cls_Profe();

            while (opcion != 0) 
            {
                Console.Clear();
                Console.WriteLine("DIGITE LA OPCION DESEADA:");
                Console.WriteLine("OPCION 1: RETGISTRAR");
                Console.WriteLine("OPCION 2: ELIMINAR");
                Console.WriteLine("OPCION 3: MODIFICAR");
                Console.WriteLine("OPCION 4: CONSULTAR");
                opcion = Convert.ToInt32(Console.ReadLine());

                Console.Clear();
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Opcion 1: REGISTRAR");
                        Console.WriteLine("Seleccionte tipo de Profesr:");
                        Console.WriteLine("1: contratado.");
                        Console.WriteLine("2: ordinario");
                        int tipoP = Convert.ToInt32(Console.ReadLine());

                        switch (tipoP)
                        {
                            case 1:
                                Console.WriteLine("Elegiste 1: contratado.");

                                Console.WriteLine("Ingrese el nombre");
                                string Nombre = Console.ReadLine();

                                Console.WriteLine("ingrse Apellido");
                                string Apellido = Console.ReadLine();

                                Console.WriteLine("ingrese Cedula");
                                string Cedula = Console.ReadLine();

                                Console.WriteLine("Ingrese la dedicacion");
                                string Dedicacion = Console.ReadLine();

                                Console.WriteLine("Ingrese la fecha de inio del contrato (dia/mes/año)");
                                string fechaI = Console.ReadLine();

                                Console.WriteLine("Ingresa fecha del fin de contrato");
                                string FechaF = Console.ReadLine();

                                Cls_Contratado PContrado = new Cls_Contratado(Nombre, Apellido, Cedula, Dedicacion, fechaI, FechaF);
                                P.añadir(PContrado);

                                break;

                            case 2:
                                Console.WriteLine("Elegiste 2: Ordinario");

                                Console.WriteLine("Ingrese el nombre");
                                 Nombre = Console.ReadLine();

                                Console.WriteLine("ingrse Apellido");
                                 Apellido = Console.ReadLine();

                                Console.WriteLine("ingrese Cedula");
                                 Cedula = Console.ReadLine();

                                Console.WriteLine("Ingrese la dedicacion");
                                 Dedicacion = Console.ReadLine();

                                Console.WriteLine("Los años de servivcio");
                                int años_S = Convert.ToInt32(Console.ReadLine());

                                Cls_Ordinario POrdinario = new Cls_Ordinario(Nombre, Apellido, Cedula, Dedicacion, años_S);
                                P.añadir(POrdinario);
                                break;

                            default: 
                                Console.WriteLine("Opcion incorrecta");
                                break;
                        }
                        break;

                    case 2:
                        Console.WriteLine("Opcion 2: eliminar");
                        Console.WriteLine("Ingrese la cedula a eliminar");
                        string cedula = Console.ReadLine();

                        P.eliminar(cedula);
                        break;


                    case 3:
                        Console.WriteLine("opcion 3: Modificar");
                        break;


                    case 4:
                        Console.WriteLine("Opcion 4: Cosultar");
                        P.consulta();
                     break;

                }

                Console.WriteLine("Precione enter para continuar");
                Console.ReadKey(); 
            }


        }
    }
}
