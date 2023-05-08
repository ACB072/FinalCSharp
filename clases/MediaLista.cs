using static System.Console;

public class MediaLista{
    public static void Main(string[] args){
        int[] numeros = { 10, 20, 30, 40, 50 };
        double media = numeros.Average();
        WriteLine("La media es: " + media);
    }
}