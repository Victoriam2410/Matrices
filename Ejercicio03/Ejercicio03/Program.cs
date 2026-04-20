Console.WriteLine("Ingrese la cantidad de filas: ");
int filas = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese la cantidad de columnas: ");
int columnas = int.Parse(Console.ReadLine());
int[,] matriz = new int[filas, columnas];
int sumaTotal = 0;

for (int i = 0; i < filas; i++)
{
    for (int j = 0; j < columnas; j++)
    {
        Console.Write($"Ingrese el valor para [{i},{j}]: ");
        matriz[i, j] = int.Parse(Console.ReadLine());
        sumaTotal = sumaTotal + matriz[i, j];
    }
}

Console.WriteLine($"La suma total de todos los elementos es: {sumaTotal}");
