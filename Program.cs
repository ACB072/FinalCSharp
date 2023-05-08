using static System.Console;
namespace FCSharp;
using FCSharp.ABisiesto;
using FCSharp.AN;
using FCSharp.ANGR;
using FCSharp.AVC;
using FCSharp.Cap;
using FCSharp.ElDup;
using FCSharp.Fact;
using FCSharp.LOrdenada;
using FCSharp.MLista;
using FCSharp.MyM;
using FCSharp.NPNC;
using FCSharp.NPrimo;
using FCSharp.Pal;
using FCSharp.ParImp;
using FCSharp.SNP;

public class Program{
    private static void Main(string[] args){


        int opcion=0;
        bool salida=false;
        
        while(!salida){
            WriteLine("============================");
            WriteLine("Menu:");
            WriteLine("============================");
            WriteLine("\t1.Numero mayor y menor");
            WriteLine("\t2.Numero par e impar");
            WriteLine("\t3.Año Bisiesto");
            WriteLine("\t4.Palindromo");
            WriteLine("\t5.Ordenar una lista");
            WriteLine("\t6.Factorial de un numero");
            WriteLine("\t7.Averiguar numero primo");
            WriteLine("\t8.Area y Volumen de un Cubo");
            WriteLine("\t9.Suma de numeros pares");
            WriteLine("\t10.Numero Positivo, Negativo o Cero");
            WriteLine("\t11.Media de una lista");
            WriteLine("\t12.Adivinar el numero");
            WriteLine("\t13.Anagrama");
            WriteLine("\t14.Eliminar Duplicados");
            WriteLine("\t15.Capicua");
            WriteLine("\t0.Salir");
            WriteLine("============================");
            Write("Escriba una opcion: ");
            opcion=Convert.ToInt32(ReadLine());
            WriteLine("============================");
            switch(opcion){
                case 1: 
                    new MenorMayor().main();
                    break;
                case 2:
                    new ParImpar().main(); 
                    break;
                case 3:
                    new AnyoBisiesto().main(); 
                    break;
                case 4:
                    new Palindromo().main();
                    break;
                case 5:
                    new ListaOrdenada().main();
                    break;
                case 6:
                    new Factorial().main();
                    break;
                case 7:
                    new NumeroPrimo().main();
                    break;
                case 8: 
                    new AreaVolumenCubo().main();
                    break;
                case 9: 
                    new SumaNumerosPares().main();
                    break;
                case 10:
                    new NumeroPositivoNegativoCero().main();
                    break;
                case 11: 
                    new MediaLista().main();
                    break;
                case 12:
                    new AdivinarNumero().main();
                    break;
                case 13:
                    new Anagrama().main();
                    break;
                case 14:
                    new EliminarDuplicados().main();
                    break;
                case 15: 
                    new Capicua().main();
                    break;
                case 0:
                    WriteLine("Adios ;)");
                    salida=true;
                    break;
                default:
                    WriteLine("Opcion Erronea");
                    break;
                
            }
        }
    }
}

/*
MenorMayor();

ParImpar();
AnyoBisiesto();
palindromo();
ordenarLista();
factorial();
NumeroPrimo();
AreaVolumenCubo();
SumaNumerosPares();
NumeroPositivoNegativoCero();
MediaLista();
AdivinarNumero();
Anagrama();
EliminarDuplicados();
Capicua();
*/