using static System.Console;

namespace FCSharp.MLista;
public class MediaLista{
    public void main(){
        //Aqui
       
        double media;
       
        Console.WriteLine("Introduce los números separados por comas:");
        string? numerosStr = Console.ReadLine();
        if (numerosStr == null){
            WriteLine("Numero invalido");
            return;
        }
        string?[] numeros ;
        numeros = numerosStr.Split(',');
        if (numeros == null){
            WriteLine("Numero invalido");
            return;
        }
        int[] numerosInt = new int[numeros.Length];
         for (int i = 0; i < numeros.Length; i++)
        {
            int.TryParse(numeros[i], out numerosInt[i]);
        }


        media= numerosInt.Average();

       /* while(true){
            Write("Ingrese un numero entero positivo a la lista, introduzca un numero negativo para terminar: ");
            int num=Convert.ToInt32(ReadLine());
            if(num<0){
                break;
            }else{
                numeros[cont]=num;
                cont++;
            }
        }*/
        WriteLine("La media es: " + media);
        WriteLine("Pulse Cualquier tecla para continuar...");
        ReadKey();
    }
}