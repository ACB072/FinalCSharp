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

        ABisiesto.AnyoBisiesto anyoBisiesto=new ABisiesto.AnyoBisiesto();
        AN.AdivinarNumero adivinarNumero= new AN.AdivinarNumero();
        ANGR.Anagrama anagrama = new ANGR.Anagrama();
        AVC.AreaVolumenCubo areaVolumenCubo= new AVC.AreaVolumenCubo();
        Cap.Capicua capicua= new Cap.Capicua();
        ElDup.EliminarDuplicados eliminarDuplicados=new ElDup.EliminarDuplicados();
        Fact.Factorial factorial= new Fact.Factorial();
        LOrdenada.ListaOrdenada listaOrdenada= new LOrdenada.ListaOrdenada();
        MLista.MediaLista mediaLista= new MLista.MediaLista();
        MyM.MenorMayor menorMayor = new MyM.MenorMayor();
        NPNC.NumeroPositivoNegativoCero numeroPositivoNegativoCero= new NPNC.NumeroPositivoNegativoCero();
        NPrimo.NumeroPrimo numeroPrimo = new NPrimo.NumeroPrimo();
        Pal.Palindromo palindromo = new Pal.Palindromo();
        ParImp.ParImpar parImpar= new ParImp.ParImpar();
        SNP.SumaNumerosPares sumaNumeros= new SNP.SumaNumerosPares();

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
                    menorMayor.main();
                    break;
                case 2:
                    parImpar.main(); 
                    break;
                case 3:
                    anyoBisiesto.main(); 
                    break;
                case 4:
                    palindromo.main();
                    break;
                case 5:
                    listaOrdenada.main();
                    break;
                case 6:
                    factorial.main();
                    break;
                case 7:
                    numeroPrimo.main();
                    break;
                case 8: 
                    areaVolumenCubo.main();
                    break;
                case 9: 
                    sumaNumeros.main();
                    break;
                case 10:
                    numeroPositivoNegativoCero.main();
                    break;
                case 11: 
                    mediaLista.main();
                    break;
                case 12:
                    adivinarNumero.main();
                    break;
                case 13:
                    anagrama.main();
                    break;
                case 14:
                    eliminarDuplicados.main();
                    break;
                case 15: 
                    capicua.main();
                    break;
                case 0:
                    WriteLine("Adios ;)");
                    salida=true;
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