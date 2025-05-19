using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {/*
        // Declarar un arreglo de 8 números
        int[] numeros = new int[8];
        int suma = 0;
        int promedio = 0;

        Console.WriteLine("Por favor, ingresa 8 números:");

        // Ciclo para que el usuario alimente el arreglo
        for (int i = 0; i < numeros.Length; i++)
        {
            Console.Write($"Número {i + 1}: ");
            // Leer y almacenar el número ingresado por el usuario
            numeros[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("\nLos números ingresados son:");
        
        // Mostrar los números ingresados
        foreach (int numero in numeros)
        {
            Console.WriteLine(numero);
            suma = suma + numero;
        }
        promedio = suma / 8;
        Console.WriteLine($"La suma total de los números ingresados es: {suma}");
        Console.WriteLine($"El promedio total de los números imgresados es: {promedio}");
*/
    int mayor100 = 0;
    int numero40y60 = 0;
    for(int i= 1; i <= 5; i++)
    {
        Console.WriteLine($"Ingrese el numero: {i}");
        int numero = Convert.ToInt32(Console.ReadLine());

        if(numero > 100)
        {
            mayor100++;
        }
        if(numero >=40 && numero <= 60)
        {
            numero40y60++;
        }
    }
    Console.WriteLine($"La camtidad de numeros mayores a 100 son: {mayor100} y los numeros entre 40 y 60 son: {numero40y60}");
    
    }
}