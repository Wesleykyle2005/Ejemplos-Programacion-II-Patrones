using Adapter;


internal class Program
{
    private static void Main(string[] args)
    {
        //Instancia al lector original
        IlectorDatos lectorOriginal = new LectorDatos();

        //Utilizar el cliente con el lector original
        Cliente cliente1 = new Cliente(lectorOriginal);
        cliente1.RealizarOperacionLectura();


        //Crear un adaptador para StreamReader
        StreamReader streamReader = new StreamReader("archivo.txt");
        IlectorDatos adaptadorStreamReader = new AdaptadorStreamReader(streamReader);

        // Utilizar el cliente con el adaptador StreamReader
        Cliente cliente2 = new Cliente(adaptadorStreamReader);
        cliente2.RealizarOperacionLectura();
    }
}