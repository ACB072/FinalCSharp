using static System.Console;

namespace FCSharp.MLista;
public class MediaLista{
    public void main(){
        //Aqui
        int[] numeros = new int[100];
        double media = numeros.Average();
        int cont=0;
        while(true){
            Write("Ingrese un numero entero positivo a la lista, introduzca un numero negativo para terminar: ");
            int num=Convert.ToInt32(ReadLine());
            if(num<0){
                break;
            }else{
                numeros[cont]=num;
                cont++;
            }
        }
        WriteLine("La media es: " + media);
        WriteLine("Pulse Cualquier tecla para continuar...");
        ReadKey();
    }
}