using static System.Console;

namespace FCSharp.ParImp;
public class ParImpar{
    public void main(){
        int numero = 0;
        Write("Ingrese un número entero: ");
        if (int.TryParse(ReadLine(), out numero))
            if (numero % 2 == 0)
            {
                WriteLine("El número es par");
            }
            else
            {
                WriteLine("El número es impar");
            }
        else
        {
            WriteLine("Ha entrado un número erroneo");
        }
        WriteLine("Pulse Cualquier tecla para continuar...");
        ReadKey();
    }
}