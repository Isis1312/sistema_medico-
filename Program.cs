using System;

namespace sistema_medico
{
    class Program
    {
        public static void Main(string[] args)
        {
            Medico Juan = new Medico("Juan", 2025258, "Medico general", "Diurno");
            Juan.darAlta();
            
         






            Console.Write("Pulse una tecla para finalizar...");
            Console.ReadKey(true);
        }
    }
}


