using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistema_medico
{
    public class Medico : Informacion_base , AccionPersonal, ParticiparCirugia
    {
        private string turno;
        public string Turno { get {return turno;}set { turno = value; }}

        // conrtusctor y llamar al constructor clase entidad
        public Medico(string _nombre,string _apellido, int _cedula, string _cargo, string _turno, int _numExpe) : base(_nombre,_apellido, _cedula, _cargo, _numExpe)
        {
            turno = _turno;
        }

        //metodo de la  clase entidad
        public override void RecetarMe()
        {
            Console.WriteLine("Recetando medicamento");
        }
        //interfaz
        public void administrarMedicamento()
        {
            Console.WriteLine("Aplicando medicamento");
        }

        public void atenderPaciente()
        {
            Console.WriteLine("Evaluando paciente");
        }

        public void ParticiparEnCirugia()
        {
            Console.WriteLine("Participando en una cirugía.");
        }

        // METODO PROPIO DE MEDICO
        public void darAlta()
        {
            Console.WriteLine($"Yo el medico {Nombre} {Apellido}, portador de la cedula {Cedula}, en el turno {Turno}, doy de alta al paciente.");
        }
    }
}
