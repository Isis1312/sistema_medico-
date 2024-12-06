using System;

namespace sistema_medico
{
    class Program
    {
        public static void Main(string[] args)
        {
            
            Medico Juan = new Medico("Juan", "Gomez", 2025258, "Medico general", "Diurno", 401);
            Juan.mostarDatos();
            Juan.asitencia();
            Juan.atenderPaciente();
            Juan.RecetarMe();
            Juan.administrarMedicamento();
            Juan.ParticiparEnCirugia();
            Juan.darAlta();
            
            
            Enfermera Sofia = new Enfermera("Sofia", "Lopez", 29604083, "Enfermera general", "Pediatria", 012);
            Sofia.mostarDatos();
            Sofia.asitencia();
            Sofia.asignarHabitacion();
            Sofia.atenderPaciente();
            Sofia.RecetarMe();
            Sofia.administrarMedicamento();
            Sofia.ParticiparEnCirugia();
            
            
            Paramedico Jose = new Paramedico("Jose", "Colmenarez", 30447832, "Paramedico de rescate", 0, 12);
            Jose.mostarDatos();
            Jose.asitencia();
            Jose.realizarPrimerosAuxilios();
            Jose.atenderPaciente();
            Jose.RecetarMe();
            Jose.administrarMedicamento();
      

            Especialista Eunice = new Especialista("Eunice", "Bastidas", 5933570, "Neurologia", 203, "12386");
            Eunice.mostarDatos();
            Eunice.asitencia();
            Eunice.RecetarMe();
            Eunice.ParticiparEnCirugia();
            Eunice.RealizarSeguimiento();
     
            
            Console.Write("Pulse una tecla para finalizar...");
            Console.ReadKey(true);
        }
    }
}


