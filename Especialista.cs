using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistema_medico
{
    public class Especialista : Informacion_base, ParticiparCirugia
    {
        private string gradoEsp;
        public string GradoEsp { get { return gradoEsp; } set { gradoEsp = value; } }

        //constructor
        public Especialista(string a, int b, string c, string d) : base(a, b, c)
        {
        GradoEsp = d;
        }

        //metodo propio
        public void RealizarSeguimiento()
        {
            Console.WriteLine("Haciendo seguimiento al paciente");
        }

        //metodo de la  clase entidad
        public override void mostarDatos()
        {
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Cedula: {Cedula}");
            Console.WriteLine($"Especialidad: {Cargo}");
            Console.WriteLine($"Gradado de especialidad: {GradoEsp}");
        }

        public override void RecetarMe()
        {
            Console.WriteLine("Recetar medicamento al paciente");
        }
         //Interfaz
        public void ParticiparEnCirugia()
        {
            Console.WriteLine("Titular de la cirugia operando...");
        }
    }

}
