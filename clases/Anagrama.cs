using static System.Console;
namespace FCSharp.ANGR;
public class Anagrama{
    public void main(){
        string palabra1 = "roma";
        string palabra2 = "amor";

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