using static System.Console;

namespace FCSharp.NPrimo;
public class NumeroPrimo{
    public void main(){
        int num = 0, i;
        bool esPrimo = true;

        Write("Introduce un número entero positivo: ");
        if (!int.TryParse(ReadLine(), out num))
        {
            WriteLine("Número invalido");
            WriteLine("Pulse Cualquier tecla para continuar...");
            ReadKey();
            return;
        }

        for (i = 2; i < num; i++)
        {
            if (num % i == 0)
            {
                esPrimo = false;
                break;
            }
        }

        if (esPrimo)
            WriteLine("{0} es un número primo", num);
        else
            WriteLine("{0} no es un número primo", num);
        WriteLine("Pulse Cualquier tecla para continuar...");
        ReadKey();
    }
        
}