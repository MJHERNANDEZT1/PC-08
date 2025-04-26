using System;

//Clase del estudiante = Ubicación donde se guardan los procedimientos y propiedades del estudiante
public class Estudiante
{
    //Propiedades/variables del estudiante
    public string Nombre = "";
    public string Carnet = "";
    public int NotaAdmision;

    //Método/Procedimiento para mostrar los datos del estudiante
    public void MostrarResumen()
    {
        Console.WriteLine("Resumen del estudiante:");
        Console.WriteLine($"Nombre del estudiante: {Nombre}");
        Console.WriteLine($"Carnet del estudiante: {Carnet}");
        Console.WriteLine($"Nota de Admision: {NotaAdmision}");
    }

    //Método para ver si el estudiante puede cursar
    public bool PuedeMatricular()
    {
        //Condición si el estudiante tiene nota mayor o igual a 75 y carnet termina en 2025 puede matricular
        if(NotaAdmision >= 75 && Carnet.EndsWith("2025"))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}

//Comenzando el Main program con el objeto estudiante
public class Program
{
    public static void Main()
    {
        //Creando el objeto estudiante para trabajar con el
        //De la clase Estudiante, se creará el objeto Estudiante1
        Estudiante Estudiante1 = new Estudiante()
        {
            //Asignando valores a las propiedades
            Nombre = "Jimena Hernández",
            Carnet = "1091125-2025",
            NotaAdmision = 92
        };

        //Mostrar el método del resumen del estudiante
        Estudiante1.MostrarResumen();

        //Ver si el estudiante puede matricular
        if(Estudiante1.PuedeMatricular())
        {
            Console.WriteLine("El estudiante podrá matricular");
        }
        else
        {
            Console.WriteLine("El estudiante no podrá matricular");
        }
    }
}




