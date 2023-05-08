using static System.Console;

namespace FCSharp.MyM;
public class MenorMayor{
   public void main(){
            int[] numeros = { 5, 3, 8, 1, 7, 2 };
        int mayor = numeros[0];
        int menor = numeros[0];

        foreach (int numero in numeros)
        {
            if (numero > mayor)
            {
                mayor = numero;
            }
            if (numero < menor)
            {
                menor = numero;
            }
        }

        WriteLine("El mayor número es: " + mayor);
        WriteLine("El menor número es: " + menor);
        WriteLine("Pulse Cualquier tecla para continuar...");
        ReadLine();

    }
}