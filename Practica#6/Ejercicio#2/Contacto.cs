using System;

namespace ejercicio_2
{
   
   /* Crear una clase Contacto. Esta clase deberá tener los atributos "nombre, apellidos, telefono y direccion".
    También deberá tener un método "SetContacto", de tipo void y con los parámetros string, que permita cambiar
     el valor de los atributos. También tendrá un método "Saludar", que escribirá en pantalla "Hola, soy " 
     seguido de sus datos. Crear también una clase llamada ProbarContacto. Esta clase deberá contener sólo la 
     función Main, que creará dos objetos de tipo Contacto, les asignará los datos del contacto y les pedirá 
     que saluden. */
    public class Contacto
    {
     public Contacto(string pNombre, string pApellido, string pTelefono, string pDireccion){
         
Nombre=pNombre;
Apellido=pApellido;
Telefono=pTelefono;
Direccion=pDireccion;

}
public string Nombre;
public string Apellido;
public string Telefono;
public string Direccion;

public string nombre{

get{

    return Nombre;
}
set{

    Nombre=value;
}

}

public string apellido{

get{

    return Apellido;
}
set{

    Apellido=value;
}

}

public string telefono{

get{

    return Telefono;
}
set{

    Telefono=value;
}

}
public string direccion{

get{

    return Direccion;
}
set{

    Direccion=value;
}

}


public void Saludar(){

string strException=string.Format("Hola, Soy {1} {2}; mi telefono es:{3}; mi dirección es:{4}", Nombre, Apellido, Telefono,Direccion);
Console.WriteLine(strException);


}

    }
}