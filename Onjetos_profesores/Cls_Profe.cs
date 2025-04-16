using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Onjetos_profesores
{

     

    public  class Cls_Profe
    {
        public List<Cls_Profe> ListaProfes = new List<Cls_Profe>();

        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Cedula { get; set; }
        public string Dedicacion { get; set; }

        public Cls_Profe(string nombre, string apellido, string cedula, string dedicacion)
        {
            Nombre = nombre;
            Apellido = apellido;
            Cedula = cedula;
            Dedicacion = dedicacion;
        }

        public Cls_Profe()
        {
          
        }

        public void añadir(Cls_Profe nuevoP)
        {
            ListaProfes.Add(nuevoP);
        }



        public virtual void info()
        {
            Console.WriteLine("Nombre: " + Nombre);
            Console.WriteLine("Apellido: " + Apellido);
            Console.WriteLine("Cedula: " + Cedula);
            Console.WriteLine("Dedicacion: " + Dedicacion);
        }

        public void consulta()
        {
            if (ListaProfes.Count >= 1)
            {
                foreach (Cls_Profe P in ListaProfes)
                {
                    P.info();
                }
            }
            else
            {
                Console.WriteLine("Sin profes registrados aun");
            }
        }

        public void eliminar(string cedula)
        {
            Cls_Profe P = ListaProfes.Find(x => x.Cedula == cedula);
            if (P != null)
            {
                ListaProfes.Remove(P);
                Console.WriteLine("Eliminado");
            }
            else
            {
                Console.WriteLine("No se encontro el profesor");
            }
        }

        public void modificar(string cedula)
        {
            Cls_Profe P = ListaProfes.Find(x => x.Cedula == cedula);
            if (P != null)
            {
                int modi = 1;

                while (modi != 0)
                {
                    Console.Clear();
                    P.info();
                    Console.WriteLine("Ingrese el numero de la propiedad a modificar");
                    Console.WriteLine("1. Nombre");
                    Console.WriteLine("2. Apellido");
                    Console.WriteLine("3. Cedula");
                    Console.WriteLine("4. Dedicacion");
                    if (P is Cls_Ordinario) {
                        Console.WriteLine("5. Años de servicio");
                    }

                    if (P is Cls_Contratado)
                    {
                        Console.WriteLine("5. Fecha de ingreso");
                        Console.WriteLine("6. Fecha de fin de contrato");
                    }
    
                    Console.WriteLine("0. Salir");

                    modi = Convert.ToInt32(Console.ReadLine());

                    switch (modi)
                    {
                        case 1:
                            Console.WriteLine("Ingrese el nuevo nombre");
                            P.Nombre = Console.ReadLine();
                            break;

                        case 2:
                            Console.WriteLine("Ingrese el nuevo apellido");
                            P.Apellido = Console.ReadLine();
                            break;

                        case 3:
                            Console.WriteLine("Ingrese la nueva cedula");
                            P.Cedula = Console.ReadLine();
                            break;

                        case 4:
                            Console.WriteLine("Ingrese la nueva dedicacion");
                            P.Dedicacion = Console.ReadLine();
                            break;

                        case 5:
                            if (P is Cls_Contratado)
                            {
                                Console.WriteLine("Ingrese la nueva fecha de ingreso");
                                ((Cls_Contratado)P).F_Ingreso = Console.ReadLine();

                            }

                            if (P is Cls_Ordinario)
                            {
                                Console.WriteLine("Ingrese los nuevos años de servicio");
                                ((Cls_Ordinario)P).Años_Servivcio = Convert.ToInt32(Console.ReadLine());
                            }

                            break;

                        case 6:
                            if (P is Cls_Contratado)
                            {
                                Console.WriteLine("Ingrese la nueva fecha de fin de contrato");
                                ((Cls_Contratado)P).Fin_Contrato = Console.ReadLine();
                            }
                            break;

                        case 0:
                            Console.WriteLine("Regresano");
                            break;
                        default:
                            Console.WriteLine("Opcion incorrecta");
                            break;

                    }
                }

            }
            else
            {
                Console.WriteLine("No se encontro el profesor");
            }
        }
    }

    public class Cls_Ordinario : Cls_Profe
    {
        public int Años_Servivcio { get; set; }


        public Cls_Ordinario(string nombre, string apellido, string cedula, string dedicacion, int Años_S) : base(nombre, apellido, cedula, dedicacion)
        {
            Años_Servivcio = Años_S;
        }

        public override void info()
        {
            Console.WriteLine("Ordinario:");
            base.info();
            Console.WriteLine("Años de servicio: " + Años_Servivcio);
            Console.WriteLine("-------------------------------------------------------");
        }

    }



    public class Cls_Contratado : Cls_Profe
    {
       public string F_Ingreso { get; set; }
        public string Fin_Contrato { get; set; }
         

        public Cls_Contratado(string nombre, string apellido, string cedula, string dedicacion, string f_Ingreso, string fin_Contrato  ) : base(nombre, apellido, cedula, dedicacion)
        {
            F_Ingreso = f_Ingreso;
            Fin_Contrato = fin_Contrato;
        }

        public  override void info()
        {
            Console.WriteLine("Contratado:");
            base.info();
            Console.WriteLine("Fecha de ingreso: " + F_Ingreso);
            Console.WriteLine("Fecha de fin de contrato: " + Fin_Contrato);
            Console.WriteLine("-------------------------------------------------------");
        }
    }



}
