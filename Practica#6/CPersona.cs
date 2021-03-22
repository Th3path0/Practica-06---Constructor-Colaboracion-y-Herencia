using System;

namespace Practica_6
{

/* Crear una clase Persona que tenga como atributos el "cedula, nombre, apellido y la edad 
(definir las propiedades para poder acceder a dichos atributos)". Definir como responsabilidad 
un método para mostrar ó imprimir. Crear una segunda clase Profesor que herede de la clase Persona. 
Añadir un atributo sueldo ( y su propiedad) y el método para imprimir su sueldo. Definir un objeto de la clase
Persona y llamar a sus métodos y propiedades. También crear un objeto de la clase Profesor y llamar a sus 
métodos y propiedades. */


    class CPersona
    {

public CPersona(string pNombre, int pEdad, double pCedula){

Nombre=pNombre;
Edad=pEdad;
Cedula=pCedula;

}
public string Nombre;
public int Edad;
public double Cedula;

public string nombre{

get{

    return Nombre;
}
set{

    Nombre=value;
}

}

public int edad{

get{

    return Edad;
}
set{

if(value>=18)
    Edad=value;
else
{
  Console.WriteLine("Edad no permitida");

}

}
}

public double cedula{

get{

    return Cedula;
}
set{

    Cedula=value;
}

}

        public void responsabilidad()
        {
            Console.WriteLine("{0} tiene {1} años, su cedula es de:{2}",nombre, edad,cedula);
        }
    }
}
