using System;

namespace Practica_6
{

/* Crear una clase Persona que tenga como atributos el "cedula, nombre, apellido y la edad 
(definir las propiedades para poder acceder a dichos atributos)". Definir como responsabilidad 
un método para mostrar ó imprimir. Crear una segunda clase Profesor que herede de la clase Persona. 
Añadir un atributo sueldo ( y su propiedad) y el método para imprimir su sueldo. Definir un objeto de la clase
Persona y llamar a sus métodos y propiedades. También crear un objeto de la clase Profesor y llamar a sus 
métodos y propiedades. */


    class CProfesor:CPersona
    {

public CProfesor(string pNombre, int pEdad, double pCedula, double pSueldo)
:base(pNombre,pEdad,pCedula)
{

sueldo=pSueldo;

}
public double Sueldo;

public double sueldo{

get{

    return Sueldo;
}
set{

    Sueldo=value;
}

}

public void responsable(string pNombre, int pEdad, double pCedula, double pSueldo){
Nombre=pNombre;
Edad=pEdad;
Cedula=pCedula;
sueldo=pSueldo;


}


        public void P_responsabilidad()
        {
            responsabilidad();
            Console.WriteLine("Su sueldo es de: {0} ",sueldo);
        }
    }
}
