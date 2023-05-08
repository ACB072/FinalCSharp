using static System.Console;

namespace FCSharp.NPNC;
public class NumeroPositivoNegativoCero{
    public void main(){
        int num;

        Write("Introduce un número entero: ");
        if (!int.TryParse(ReadLine(), out num))
        {
            WriteLine("Número invalido");
            return;
        }

        if (num > 0)
            WriteLine("{0} es un número positivo", num);
        else if (num < 0)
            WriteLine("{0} es un número negativo", num);
        else
            WriteLine("{0} es cero", num);

        WriteLine("Pulse Cualquier tecla para continuar...");
        ReadKey();
    }
}