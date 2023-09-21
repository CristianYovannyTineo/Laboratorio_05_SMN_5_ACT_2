// See https://aka.ms/new-console-template for more information

//Escribir un programa que permita hallar la potencia de un numero ingresando la base y el exponente 

    int Resultado = 1;
    Console.Write("Ingrese la Base: ");
     int BaseNumero = int.Parse(Console.ReadLine());
    Console.Write("Ingrese el Exponente: ");
     int exponente = int.Parse(Console.ReadLine());

    for (int i = 0; i < Math.Abs(exponente); i++)
    {
        Resultado *= BaseNumero;
    }
    if (exponente < 0)
    {
        Resultado = 1 / Resultado;
    }
    Console.WriteLine("La potencia es: " + Resultado);
