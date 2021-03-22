using System;

namespace ejercicio_3
{
   
    public class ClaseA
    {
        public ClaseA()
        {
            Console.WriteLine("Clase A: Programación");
        }
    }

    public class ClaseB : ClaseA 
    {
        public ClaseB()
        {
            Console.WriteLine("Clase B: Ciencias e Historia");
        }
    }

    public class ClaseC : ClaseB
    {
        public ClaseC()
        {
            Console.WriteLine("Clase C: Ética");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ClaseC obj1 = new ClaseC();
            Console.ReadKey();
        }
    }
}

    
