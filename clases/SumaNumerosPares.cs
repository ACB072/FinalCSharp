using static System.Console;

namespace FCSharp.SNP;
public class SumaNumerosPares{
    public void main(){
        //Aqui
        List<int> numeros = new List<int>() {};
        int suma = 0;
        while(true){
            Write("Ingrese un numero entero positivo a la lista, introduzca un numero negativo para terminar: ");
            int num=Convert.ToInt32(ReadLine());
            if(num<0){
                break;
            }else{
                numeros.Add(num);
            }
        }
        foreach (int num in numeros)
        {
            if (num % 2 == 0)
                suma += num;
        }

        WriteLine("La suma de los números pares es {0}", suma);

        WriteLine("Pulse Cualquier tecla para continuar...");
            ReadKey();
    }
}