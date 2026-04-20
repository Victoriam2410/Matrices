Console.WriteLine("Ingrese la cantidad de filas: ");
int filas = int .Parse(Console.ReadLine());
Console.WriteLine("Ingrese la cantidad de columnas: ");
int columnas = int.Parse(Console.ReadLine());
int[,] matriz = new int[filas, columnas];

for (int i =0; i < filas; i++)
{
    for (int j = 0; j < columnas; j++)
    {
        Console.Write("Ingrese los valores:");
        matriz[i,j] = int.Parse(Console.ReadLine());
    }
}
Console.WriteLine("La tabla es: ");
for (int i = 0; i < filas; i++)
{
    for (int j = 0; j < columnas; j++)
    {
        Console.Write(matriz[i,j] + "|");
    }
    Console.WriteLine();
}