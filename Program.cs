using System;
using System.Collections.Generic;

class Estudiante
{
    public string Nombre;
    private int Edad;
    public double Promedio;

    public Estudiante(string nombre, int edad, double promedio) //al parecer hay que inicializar los objetos, crei que eso no se hacia aqui
    {
        Nombre = nombre;
        Edad = edad;
        Promedio = promedio;
    }
    public void MostrarInfo() //un simple metodo que muestra el texto si se cumple con la condicion
    {
        Console.WriteLine($"El estudiante {Nombre} tiene un promedio de {Promedio}");
    }

    public bool EsMayorDeEdad() //retornamos la operacion para luego dejarla como un if
    {
        return Edad >= 18;
    }
}

class Program
{
    public static void Main(String[] args)
    {
        Console.WriteLine("Ingrese la cantidad de estudiantes a registrar");
        int cantEstudiantes = int.Parse(Console.ReadLine());

        string[,] Estudiantes = new string[cantEstudiantes, 3]; //intente hacerla como matriz, pero me volo la cabeza, segun las grandes mentes
                                                                //de internet esto es mas sencillo, y si lo es
        for (int i = 0; i < cantEstudiantes; i++)
        {
            Console.WriteLine("Escriba el nombre del estudiante");
            Estudiantes[i,0] = Console.ReadLine();              

            Console.WriteLine("Escriba la edad del estudiante");
            Estudiantes[i,1] = Console.ReadLine();

            Console.WriteLine("Escriba el promedio del estudiante");
            Estudiantes[i,2] = Console.ReadLine();
        }

        Console.WriteLine("\nEstudiantes con promedio mayor o igual a 70"); 


        for (int i = 0; i < cantEstudiantes; i++)
        {
            double promedio = double.Parse(Estudiantes[i, 2]);  
            int edad = int.Parse(Estudiantes[i,1]);

            Estudiante estudiante = new Estudiante(Estudiantes[i, 0], edad, promedio); //creo el objeto para hacerme la vida mas "facil"

            if (promedio >= 70)
            {
                estudiante.MostrarInfo();
            }

        }
        Console.ReadKey();
        Console.WriteLine(" ");

        for (int i = 0; i < cantEstudiantes; i++)
        {
            double promedio = double.Parse(Estudiantes[i, 2]);
            int edad = int.Parse(Estudiantes[i, 1]);

            Estudiante estudiante = new Estudiante(Estudiantes[i, 0], edad, promedio);

            if (estudiante.EsMayorDeEdad())
            {
                Console.WriteLine($"El estudiante {estudiante.Nombre} es mayor de edad");
            }
            else
            {
                Console.WriteLine($"El estudiante {estudiante.Nombre} no es mayor de edad");
            }
        }
        Console.ReadKey(); //por 15 minutos habia olvidado que si no existe este señor el programa no va a mostrar los resultados, entonces
                           // se agrego y todo mejor
    }
}
