using Patron_de_observer;

ISujetoObservado lectorArchivo = new LectorArchivo("C:\\Users\\Wesley\\Desktop\\Ejemplos\\PatronDecorador\\archivo.txt");

IObserver observadorMostarDatos = new ObservadorMostrarDatos();
lectorArchivo.AgregarObservador(observadorMostarDatos);

lectorArchivo.NotificarObservadores();