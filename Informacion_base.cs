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
        protected string apellido;
        protected int cedula;
        protected string cargo;
        protected int numExpe;
       
        //constructor
        public string Nombre { get { return nombre; } set { nombre = value; } }
        public string Apellido { get { return apellido; } set { apellido = value; } }
        public string Cargo { get { return cargo; } set { cargo = value; } }
        public int Cedula { get { return cedula; } set { cedula = value; } }
        public int NumExpe { get { return numExpe; } set { numExpe = value; } }


        // constructor 
        public Informacion_base(string _nombre, string _apellido, int _cedula, string _cargo, int _numExpe)
        {
            Nombre = _nombre;
            Apellido = _apellido;
            cedula = _cedula;
            Cargo = _cargo;
            NumExpe = _numExpe;
        }

        //metodos
        public void asitencia()
        {
            Console.WriteLine($"{Nombre} {Apellido} presente");
        }
        public virtual void mostarDatos()
        {
            Console.WriteLine("Dato ingresados");
            Console.WriteLine($"{Nombre} {Apellido}");
            Console.WriteLine($"Cedula: {Cedula}");
            Console.WriteLine($"Especialidad: {Cargo}");
            Console.WriteLine($"Numero expediente del paciente: {NumExpe}");
        }

        //metodos para sobre escribir
        public virtual void RecetarMe() 
        {
            Console.WriteLine("Recetando");
        }
        
    
    }
}
