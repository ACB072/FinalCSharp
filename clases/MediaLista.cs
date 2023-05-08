using static System.Console;

namespace FCSharp.MLista;
public class MediaLista{
    public void main(){
        int[] numeros = { 10, 20, 30, 40, 50 };
        double media = numeros.Average();
        WriteLine("La media es: " + media);
        WriteLine("Pulse Cualquier tecla para continuar...");
        ReadKey();
    }
}