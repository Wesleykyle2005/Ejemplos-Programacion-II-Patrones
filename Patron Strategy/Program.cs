
using Patron_Strategy;

IlectorArchivo lectortexto = new LectorArchivoTexto();

IlectorArchivo lectorXml = new LectorArchivoXML();

ContextoLectorArchivo contexto = new ContextoLectorArchivo(lectortexto);

string contenidoTexto = contexto.LeerArchivo("C:\\Users\\LABORATORIO 3\\Desktop\\Ejemplos\\Patron Strategy\\archivo.txt");
Console.WriteLine("Lo siguiente es el contenido: " + contenidoTexto);

contexto.EstablecerEstragtegia(lectorXml);
string contenidoXML = contexto.LeerArchivo("C:\\Users\\LABORATORIO 3\\Desktop\\Ejemplos\\Patron Strategy\\archivo.txt");


Console.WriteLine("Lo siguiente es el contenido: " + contenidoXML);