using static System.Console;

namespace FCSharp.LOrdenada;
public class ListaOrdenada{
    public void main(){
        string[] nombres = { "Juan", "Maria", "Ana", "Pedro" };

        Array.Sort(nombres);

        WriteLine("Lista ordenada alfabéticamente:");

        foreach (string nombre in nombres)
        {
            WriteLine(nombre);
        } 
        WriteLine("Pulse Cualquier tecla para continuar...");
        ReadKey();   
    }
    
}
