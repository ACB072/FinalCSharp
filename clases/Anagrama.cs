using static System.Console;
namespace FCSharp.ANGR;
public class Anagrama{
    //Aqui
    public void main(){

        string? palabra1;
        string? palabra2;
        Write("Ingrese la primera palabra: ");
            palabra1=ReadLine();
        Write("Ingrese la segunda palabra: ");
            palabra2=ReadLine();
         if(palabra1==null || palabra2==null){
                WriteLine("Nombre invalido");
                return;
        }
        char[] letras1 = palabra1.ToLower().ToCharArray();
        char[] letras2 = palabra2.ToLower().ToCharArray();

        Array.Sort(letras1);
        Array.Sort(letras2);

        bool sonAnagramas = letras1.SequenceEqual(letras2);

        if (sonAnagramas)
        {
            WriteLine(palabra1 + " y " + palabra2 + " son anagramas.");
        }
        else
        {
            WriteLine(palabra1 + " y " + palabra2 + " no son anagramas.");
        }
        WriteLine("Pulse Cualquier tecla para continuar...");
        ReadKey();
    }
}