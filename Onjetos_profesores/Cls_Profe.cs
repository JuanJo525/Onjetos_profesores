using System;
using System.Collections.Generic;
using System.Linq;
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
