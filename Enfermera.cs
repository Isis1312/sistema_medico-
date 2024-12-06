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
               
        
        public Enfermera(string _nombre,string _apellido, int _cedula, string _cargo, string _departamento, int _numExpe) : base(_nombre, _apellido, _cedula, _cargo, _numExpe)
        {
            departamento = _departamento;
        }
        
        //metodo propio
        public void asignarHabitacion()
        {
            Console.WriteLine("Llevar paciente a la habitacion");
        }

        //metodo de la  clase entidad
        public override void mostarDatos()
        {
            Console.WriteLine("Dato ingresados");
            Console.WriteLine($"{Nombre} {Apellido}");
            Console.WriteLine($"Cedula: {Cedula}");
            Console.WriteLine($"Especialidad: {Cargo}");
            Console.WriteLine($"Numero expediente del paciente: {NumExpe}");
            Console.WriteLine($"Departamento al que pertenece: {Depertamento}");
        }
        public override void RecetarMe()
        {
            Console.WriteLine("No aplica para recetar medicamentos");
        }
        //interfaz
        public void administrarMedicamento()
        {
            Console.WriteLine($"Inyectando medicamento al paciente del expendiete {NumExpe}");
        }

        public void atenderPaciente()
        {
            Console.WriteLine($"Atendiendo al paciente del expendiete {NumExpe}");
        }

        public void ParticiparEnCirugia()
        {
            Console.WriteLine($"{Nombre} {Apellido}, perteneciente al departamento {Depertamento} esta preparando instrumentos en la cirugía.");
        }
    }
}
