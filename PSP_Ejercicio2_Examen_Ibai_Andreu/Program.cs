using System;
using System.Diagnostics;
using System.Threading;

namespace PSP_Ejercicio2_Examen_Ibai_Andreu
{
    class Program
    {
        public static void Main()
        {
            for (int i = 0; i < 5; i++)
            {
                var th = new Thread(hilosDeCoser);
                th.Start();
                Thread.Sleep(1000);
            }
        }

        private static void hilosDeCoser()
        { 
            Console.WriteLine("Ahora saco un hilo de color (No se soy daltonico)");
        }
       
    }
}
