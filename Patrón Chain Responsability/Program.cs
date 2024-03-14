using Patrón_Chain_Responsability;

IManejadorDeSolicitud lectura = new ManejadorSolicitudLectura();
IManejadorDeSolicitud escritura = new ManejadorSolicitudEscritura();


lectura.EstablecerSiguiente(escritura);


EjecutarSolicitud("lectura", lectura);
EjecutarSolicitud("escritura", escritura);
EjecutarSolicitud("otro", lectura);

void EjecutarSolicitud(string solicitud, IManejadorDeSolicitud manejador)
{
    Console.WriteLine("Ejecutando solicitud: " + solicitud);
    manejador.ManejarSolicitud(solicitud);
    Console.WriteLine();
}