using System;
class Control_De_Notas
{
    public class Persona()
    {
        string nombre = "";

    }
    public class Alumno()
    {
        public string[] nombres = new string[10];
        public int[] notas = new int[10];

    }

    static void Main()
    {
        int opcion = 0;
        Alumno alumno = new Alumno();

        ingresar_Notas_Alumno(alumno);

        do
        {
            Console.WriteLine("------------ MENU PARA SISTEMA DE NOTAS - ALUMNOS ---------------");
            Console.WriteLine();
            Console.WriteLine("Seleccione una de las siguientes opciones: ");
            Console.WriteLine();
            Console.WriteLine("1. Si desea conocer las notas aprobadas por cada alumno.");
            Console.WriteLine("2. Si desea conocer las notas NO aprobadas por cada alumno. ");
            Console.WriteLine("3. Si desea consultar el promedio de notas del grupo. ");
            Console.WriteLine("4. Salir del programa ");

            if (!int.TryParse(Console.ReadLine(), out opcion))
            {
                Console.WriteLine("La opcion debe de ser un numero, por favor ingrese de nuevo");
                continue;
            }

            //Tipo de opciones del menú

            switch (opcion)
            {
                case 1:
                    notas_Aprobadas(alumno);
                    break;

                case 2:
                    notas_No_Aprobadas(alumno);
                    break;

                case 3:
                    promedio_Del_Grupo(alumno);
                    break;

                case 4:
                    Console.WriteLine("¡Hasta pronto!");
                    break;
            }
        } while (opcion != 4);
    }

    //------------------------------------------------------------------------------------------------------------------------------
    static void ingresar_Notas_Alumno(Alumno alumno)
    {
        for (int fila = 0; fila < 10; fila++)
        {
            Console.WriteLine("Ingrese el nombre del alumno: ");
            alumno.nombres[fila] = Console.ReadLine();

            int nota = 0;
            bool nota_Valida = false;

            do
            {
                Console.WriteLine($"Ingrese la nota del alumno: {alumno.nombres[i]} (nota de 0 - 100) ");
                string nota_Ingresada = Console.ReadLine();


                //Validando si la nota ingresada es entero, es mayor a 0 y menor o igual a 100
                if (int.TryParse(nota_Ingresada, out nota) && nota >= 0 && nota <= 100)
                {
                    alumno.notas[fila] = nota;
                    nota_Valida = true;
                }
                else
                {
                    Console.WriteLine("Nota inválida, Ingrese un número entre 0 y 100");
                }
            } while (!nota_Valida);
    }
}



    static void notas_Aprobadas(Alumno alumno)
    {
        Console.WriteLine(" ------------ NOTAS APROBADAS ----------------");
        for (int fila = 0; fila < 10; i++)
        {
            if (alumno.notas[fila] >= 65)
            {
                Console.WriteLine($"{alumno.nombres[fila]} - Nota: {alumno.notas[fila]}");
            }
        }
    }

    static void notas_No_Aprobadas(Alumno alumno)
    {
        Console.WriteLine(" ------------ NOTAS NO APROBADAS ----------------");
        for (int fila = 0; fila < 10; i++)
        {
            if (alumno.notas[fila] <= 65)
            {
                Console.WriteLine($"{alumno.nombres[fila]} - Nota: {alumno.notas[fila]}");
            }
        }
    }

    static void promedio_Del_Grupo(Alumno alumno)
    {
        int suma = 0;
        for (int fila = 0; fila <= 10; fila++¨)
        {
            suma = alumno.notas[fila];
            Console.WriteLine($"El promedio del grupo es: {promedio_Del_Grupo:F2}")
        }
        double promedio = (double)suma / 10;
    }   
}

        