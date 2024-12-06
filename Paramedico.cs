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
        public Paramedico(string _nombre,string _apellido, int _cedula, string _cargo,int _numExpe, int _numeroAmb) : base(_nombre, _apellido, _cedula, _cargo, _numExpe)
        {
            numerodeAmbu = _numeroAmb;
        }
        
        //metodos propio
        public void realizarPrimerosAuxilios()
        {
            Console.WriteLine($"Realizando primeros auxilios al paciente en la ambulacia numero {NumerodeAmbu}");
        }


        //metodos dela  clase entidad
        public override void mostarDatos()
        {
            Console.WriteLine("Dato ingresados");
            Console.WriteLine($"{Nombre} {Apellido}");
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
            Console.WriteLine($"Administrando medicamento en la ambulancia numero {NumerodeAmbu}");
        }

        public void atenderPaciente()
        {
            Console.WriteLine($"Atendiendo al peciente en la ambulancia numero {NumerodeAmbu}");
        }
    }
}
