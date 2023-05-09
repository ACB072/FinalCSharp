using static System.Console;

namespace FCSharp.MyM;
public class MenorMayor{
   public void main(){
        //Aqui
        

        int cont=0;
        
        Console.WriteLine("Introduce los números separados por comas:");
        string? numerosStr = Console.ReadLine();
        string?[] numeros = numerosStr.Split(',');
        int[] numerosInt = new int[numeros.Length];
         for (int i = 0; i < numeros.Length; i++)
        {
            numerosInt[i] = int.Parse(numeros[i]);
        }

        int mayor = numerosInt[0];
        int menor = numerosInt[0];
        /*while(true){
            Write("Ingrese un numero entero positivo a la lista, introduzca un numero negativo para terminar: ");
            int num=Convert.ToInt32(ReadLine());
            if(num<0){
                break;
            }else{
                numeros[cont]=num;


                cont++;
            }*/
            
              
        foreach (int numero in numerosInt)
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