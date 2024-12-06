using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistema_medico
{
    public class Paramedico : Informacion_base, AccionPersonal
    {
        private int numerodeAmbu;
        public int NumerodeAmbu { get { return numerodeAmbu; } set { numerodeAmbu = value; } }

        //constructor
        public Paramedico(string a, int b, string c, int d) : base (a,b,c)
        {
            numerodeAmbu = d;
        }
        
        //metodos propio
        public void realizarPrimerosAuxilios()
        {
            Console.WriteLine("Realizando primeros auxilios al paciente");
        }


        //metodos dela  clase entidad
        public override void mostarDatos()
        {
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Cedula: {Cedula}");
            Console.WriteLine($"Especialidad: {Cargo}");
            Console.WriteLine($"Numero de ambulancia {NumerodeAmbu}");
        }

        public override void RecetarMe()
        {
            Console.WriteLine("No aplica para recetar medicamentos");
        }

        //interfaz
        public void administrarMedicamento()
        {
            Console.WriteLine("Adminstrando medicamento en la ambulancia");
        }

        public void atenderPaciente()
        {
            Console.WriteLine("Atendiendo al peciente en la ambulancia");
        }
    }
}
