using static System.Console;

namespace FCSharp.ElDup;
public class EliminarDuplicados{
    public void main(){
        //Aqui
        List<int> numeros = new List<int>() {};
        while(true){
            Write("Ingrese un numero entero positivo a la lista, introduzca un numero negativo para terminar: ");
            int num=Convert.ToInt32(ReadLine());
            if(num<0){
                break;
            }else{
                numeros.Add(num);
            }
        }

        List<int> numerosSinDuplicados = new List<int>();

        foreach (int numero in numeros)
        {
            if (!numerosSinDuplicados.Contains(numero))
            {
                numerosSinDuplicados.Add(numero);
            }
        }

        WriteLine("Números originales: " + string.Join(", ", numeros));
        WriteLine("Números sin duplicar: " + string.Join(", ", numerosSinDuplicados));
        WriteLine("Pulse Cualquier tecla para continuar...");
        ReadKey();
    }
}