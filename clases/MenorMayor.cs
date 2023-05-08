using static System.Console;

namespace FCSharp.MyM;
public class MenorMayor{
   public void main(){
        //Aqui
        int[] numeros = new int[100];
        int mayor = numeros[0];
        int menor = numeros[0];
        int cont=0;

        while(true){
            Write("Ingrese un numero entero positivo a la lista, introduzca un numero negativo para terminar: ");
            int num=Convert.ToInt32(ReadLine());
            if(num<0){
                break;
            }else{
                numeros[cont]=num;

                if(cont==0){
                    mayor = numeros[0];
                    menor = numeros[0];
                }
                
                cont++;
            }
        }        
        foreach (int numero in numeros)
        {
           
            if (numero > mayor)
            {
                mayor = numero;
            }
            if (numero < menor)
            {
                menor = numero;
            }
            
            
        }

        WriteLine("El mayor número es: " + mayor);
        WriteLine("El menor número es: " + menor);
        WriteLine("Pulse Cualquier tecla para continuar...");
        ReadLine();

    }
}