//CALCULADORA 
Console.WriteLine(" opciones ");
Console.WriteLine(" escribe 1 para sumar ");
Console.WriteLine(" escribe 2 para multiplicar ");
Console.WriteLine(" opciones ");
Console.WriteLine(" opciones ");

Console.ReadLine();









float Calcular(float n1 , float n2, int opcion)
{
   

    if (opcion == 1)
    {
        return n1 + n2;

    }
    if (opcion == 2)
    {
        return n1 * n2;

    }
    if (opcion == 3)
    {
        return n1 / n2;

    }



    return n1;
}


