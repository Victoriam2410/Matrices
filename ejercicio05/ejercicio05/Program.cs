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

Console.WriteLine("Ingrese el número a buscar: ");
int buscar = int.Parse(Console.ReadLine());
bool encontrado = false;

for (int i = 0; i < filas; i++)
{
    for (int j = 0; j < columnas; j++)
    {
        if (matriz[i, j] == buscar)
        {
            Console.WriteLine($"El número {buscar} existe y está en la posición: [{i},{j}]");
            encontrado = true;
        }
    }
}

if (!encontrado)
{
    Console.WriteLine("El número no se encuentra en la matriz.");
}
