﻿using System;

namespace ejercicio_2
{
   
   /* Crear una clase Contacto. Esta clase deberá tener los atributos "nombre, apellidos, telefono y direccion".
    También deberá tener un método "SetContacto", de tipo void y con los parámetros string, que permita cambiar
     el valor de los atributos. También tendrá un método "Saludar", que escribirá en pantalla "Hola, soy " 
     seguido de sus datos. Crear también una clase llamada . Esta clase deberá contener sólo la 
     función Main, que creará dos objetos de tipo Contacto, les asignará los datos del contacto y les pedirá 
     que saluden. */

public class ProbarC
    {

      static void Main(string[] args)
        {
            Console.WriteLine("-------------------------------");
            Contacto uno = new Contacto("Juan","Hichez","8092134563","Herrera#12");
            uno.Saludar();  

Console.WriteLine("-------------------------------");

        }
    }


}
  

  


   


    
