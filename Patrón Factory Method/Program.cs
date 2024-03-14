using Patrón_Factory_Method;

IlectorArchivoFactory factory = new LectorArchivoTextoFactory();
IlectorArchivo lectorArchivo = factory.CrearLectorArchivo("Archivo.txt");

string contenido = lectorArchivo.leer();

Console.WriteLine("Contenido: " + contenido);