using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistema_medico
{
    public abstract class Informacion_base
    {
        protected string nombre;
        protected int cedula;
        protected string cargo;
       
        //constructor
        public string Nombre { get { return nombre; } set { nombre = value; } }
        public string Cargo { get { return cargo; } set { cargo = value; } }
        public int Cedula { get { return cedula; } set { cedula = value; } }



        // constructor 
        public Informacion_base(string _nombre, int _cedula, string _cargo)
        {
            Nombre = _nombre;
            cedula = _cedula;
            Cargo = _cargo;
        }

        //metodos
        public void asitencia()
        {
            Console.WriteLine("{Nombre} presente");
        }
        public virtual void mostarDatos()
        {
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Cedula: {Cedula}");
            Console.WriteLine($"Especialidad: {Cargo}");
        }

        //metodos para sobre escribir
        public virtual void RecetarMe() 
        {
            Console.WriteLine("Recetando");
        }
        
    
    }
}
