Console.WriteLine("Ingrese la cantidad de filas: ");
int filas = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese la cantidad de columnas: ");
int columnas = int.Parse(Console.ReadLine());
int[,] matriz = new int[filas, columnas];

for (int i = 0; i < filas; i++)
{
    for (int j = 0; j < columnas; j++)
    {
        Console.Write($"Ingrese el valor para [{i},{j}]: ");
        matriz[i, j] = int.Parse(Console.ReadLine());
    }
}

Console.WriteLine("Ingrese el número de fila que desea mostrar: ");
int filaMostrar = int.Parse(Console.ReadLine());
if (filaMostrar >= 0 && filaMostrar < filas)
{
    Console.WriteLine($"Valores de la fila {filaMostrar}:");
    for (int j = 0; j < columnas; j++)
    {
        Console.Write(matriz[filaMostrar, j] + " ");
    }
}
else
{
    Console.WriteLine("La fila ingresada no existe.");
}