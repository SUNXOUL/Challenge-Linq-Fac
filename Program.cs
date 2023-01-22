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
    }
}
