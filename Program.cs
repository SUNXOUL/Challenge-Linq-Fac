using System.Collections;
using System;

public class Factorial_linq{

    public static void Main(string[] args)
    {
        int valor=3;
        int[] Numeros = new int[valor];
        for(int i = 0;i<valor;i++)
        {
            Numeros[i] = i+1;
        }

        IEnumerable<int>  lst =
        from num in Numeros
        select num;
        int resultado = lst.Aggregate((anterior,actual) => anterior*actual);  
        Console.WriteLine(resultado);


        foreach (var item in lst)
        {
            Console.WriteLine(item);
        }

        //////////////////////////
        int Range = 10;   
        int ord1 = 0, ord2 = 0, ord3 = 0;   
        IEnumerable<int> FibSeries = Enumerable.Range(1, Range).Select(a =>   
        {   
        ord1 = a == 1 ? 0 : ord2;   
        ord2 = a == 1 ? 1 : ord3;   
        ord3 = a == 1 ? 0 : ord1 + ord2;   
        return ord3;   
        }); 
        
        foreach (var item in FibSeries)
        {
            Console.WriteLine(item);
        }
    }
}
