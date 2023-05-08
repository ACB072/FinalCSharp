using static System.Console;

public class ListaOrdenada{
    public static void Main(string[] args){
        string[] nombres = { "Juan", "Maria", "Ana", "Pedro" };

        Array.Sort(nombres);

        WriteLine("Lista ordenada alfabéticamente:");

        foreach (string nombre in nombres)
        {
            WriteLine(nombre);
        }    
    }
    
}
