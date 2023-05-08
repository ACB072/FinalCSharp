using static System.Console;

namespace FCSharp.Cap;
public class Capicua{
    public void main(){
        Console.Write("Ingresa un número: ");
        int num = 0;
        if (!int.TryParse(ReadLine(), out num))
        {
            WriteLine("Número invalido");
            WriteLine("Pulse Cualquier tecla para continuar...");
            ReadKey();
            return;
        }
        int originalNum = num;
        int reversedNum = 0;

        while (num > 0)
        {
            int digit = num % 10;
            reversedNum = (reversedNum * 10) + digit;
            num /= 10;
        }

        if (originalNum == reversedNum)
        {
            Console.WriteLine("El número es capicúa.");
        }
        else
        {
            Console.WriteLine("El número no es capicúa.");
        }
        WriteLine("Pulse Cualquier tecla para continuar...");
        ReadKey();
    }
}