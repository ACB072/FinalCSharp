using static System.Console;

namespace FCSharp.ElDup;
public class EliminarDuplicados{
    public void main(){
        List<int> numeros = new List<int>() { 10, 20, 30, 20, 50 };

        List<int> numerosSinDuplicados = new List<int>();

        foreach (int numero in numeros)
        {
            if (!numerosSinDuplicados.Contains(numero))
            {
                numerosSinDuplicados.Add(numero);
            }
        }

        WriteLine("Números originales: " + string.Join(", ", numeros));
        WriteLine("Números originales: " + string.Join(", ", numeros));
        WriteLine("Pulse Cualquier tecla para continuar...");
        ReadKey();
    }
}