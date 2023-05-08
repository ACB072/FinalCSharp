using static System.Console;

namespace FCSharp.LOrdenada;
public class ListaOrdenada{
    public void main(){
        //Aqui
        string[] nombres = new string[100];
        int cont=0;
        while(true){
            Write("Ingrese un nombre a la lista,escriba FIN para terminar: ");
            string nombre=ReadLine();
            
            if(nombre.ToLower()=="fin"){
                break;
            }else{
                nombres[cont]=nombre;
                cont++;
            }

        }
        Array.Sort(nombres);

        WriteLine("Lista ordenada alfabéticamente:");

        foreach (string nombre in nombres)
        {
            if(nombre!=null){
                WriteLine(nombre);
            }
        } 
        WriteLine("Pulse Cualquier tecla para continuar...");
        ReadKey();   
    }
    
}
