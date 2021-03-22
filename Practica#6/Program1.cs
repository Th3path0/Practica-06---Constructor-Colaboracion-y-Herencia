using System;

namespace Practica_6
{
    class Program
    {


        static void Main(string[] args)
        {
             Console.WriteLine("-----------------------------");  
           CProfesor uno = new CProfesor("Juan",18,42132412392, 25500);
           uno.P_responsabilidad();

           Console.WriteLine("-------------------------------");
        }


    }
}
