using static System.Console;

public class ParImpar{
    public static void Main(string[] args){
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
    }
}