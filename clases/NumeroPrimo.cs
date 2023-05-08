using static System.Console;

public class NumeroPrimo{
    public static void Main(string[] args){
        int num = 0, i;
        bool esPrimo = true;

        Write("Introduce un número entero positivo: ");
        if (!int.TryParse(ReadLine(), out num))
        {
            WriteLine("Número invalido");
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
    }
        
}