using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistema_medico 
{
     public class Enfermera : Informacion_base, AccionPersonal, ParticiparCirugia
    {
        private string departamento;
        public string Depertamento { get { return departamento; }set { departamento = value; } }
               
        
        public Enfermera(string a, int b, string c, string d) : base(a, b, c)
        {
            departamento = d;
        }
        
        //metodo propio
        public void asignarHabitacion()
        {
            Console.WriteLine("Llevar paciente a la habitacion");
        }

        //metodo de la  clase entidad
        public override void mostarDatos()
        {
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Cedula: {Cedula}");
            Console.WriteLine($"Especialidad: {Cargo}");
            Console.WriteLine($"Departamento al que pertenece: {Depertamento}");
        }
        public override void RecetarMe()
        {
            Console.WriteLine("No aplica para recetar medicamentos");
        }
        //interfaz
        public void administrarMedicamento()
        {
            Console.WriteLine("Inyectando medicamento");
        }

        public void atenderPaciente()
        {
            Console.WriteLine("Atendiendo al paciente");
        }

        public void ParticiparEnCirugia()
        {
            Console.WriteLine("Preparando instrumentos en la cirugía.");
        }
    }
}
