using static System.Console;

namespace FCSharp.SNP;
public class SumaNumerosPares{
    public void main(){
        List<int> numeros = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        int suma = 0;

        foreach (int num in numeros)
        {
            if (num % 2 == 0)
                suma += num;
        }

        WriteLine("La suma de los números pares es {0}", suma);

        WriteLine("Pulse Cualquier tecla para continuar...");
            ReadKey();
    }
}