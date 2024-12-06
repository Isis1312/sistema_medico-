using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistema_medico
{
    public class Especialista : Informacion_base, ParticiparCirugia
    {
        private string numero;
        public string Numero { get { return numero; } set { numero = value; } }

        //constructor
        public Especialista(string _nombre,string _apellido, int _cedula, string _cargo, int _numExpe, string _numero) : base(_nombre, _apellido, _cedula, _cargo, _numExpe)
        {
        Numero = _numero ;
        }

        //metodo propio
        public void RealizarSeguimiento()
        {
            Console.WriteLine("Haciendo seguimiento al paciente");
        }

        //metodo de la  clase entidad
        public override void mostarDatos()
        {
            Console.WriteLine("Dato ingresados");
            Console.WriteLine($"{Nombre} {Apellido}");
            Console.WriteLine($"Cedula: {Cedula}");
            Console.WriteLine($"Especialidad: {Cargo}");
            Console.WriteLine($"Numero de lincecia medica: {Numero}");
        }

        public override void RecetarMe()
        {
            Console.WriteLine($"Recetar medicamento al paciente del expediente {NumExpe}");
        }
         //Interfaz
        public void ParticiparEnCirugia()
        {
            Console.WriteLine($"El {Nombre} {Apellido}, con la especialidad de {Cargo}, con el numero de liencia {Numero} es el titular de la cirugia");
        }
    }

}
