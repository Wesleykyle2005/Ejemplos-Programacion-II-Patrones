using PatronDecorador;

ILectorDatos lectorDatos= new LectorArchivo(".\\archivo.txt");

ILectorDatos lectorDecorado = new DecoradorLogger(lectorDatos);

string datos = lectorDecorado.LeerDatos();
Console.WriteLine("Datos leídos: " + datos);