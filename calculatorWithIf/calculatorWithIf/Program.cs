Console.WriteLine("Ingrese 1 para sumar, 2 para restar, 3 para multiplicar y 4 para dividr.");
int option = int.Parse(Console.ReadLine());
float resultado = 0;

if (option == 1)
{
    Console.WriteLine("Ingrese primer número: ");
    float num1 = float.Parse(Console.ReadLine());
    Console.WriteLine("Ingrese primer número: ");
    float num2 = float.Parse(Console.ReadLine());
    resultado = num1 + num2;
}
else if (option == 2)
{
    Console.WriteLine("Ingrese primer número: ");
    float num1 = float.Parse(Console.ReadLine());
    Console.WriteLine("Ingrese primer número: ");
    float num2 = float.Parse(Console.ReadLine());
    resultado = num1 - num2;
}
else if (option == 3)
{
    Console.WriteLine("Ingrese primer número: ");
    float num1 = float.Parse(Console.ReadLine());
    Console.WriteLine("Ingrese primer número: ");
    float num2 = float.Parse(Console.ReadLine());
    resultado = num1 * num2;
}
else if (option == 4)
{
    Console.WriteLine("Ingrese primer número: ");
    float num1 = float.Parse(Console.ReadLine());
    Console.WriteLine("Ingrese primer número: ");
    float num2 = float.Parse(Console.ReadLine());
    resultado = num1 / num2;
}
else
{
    Console.WriteLine("Esa opcion no se encuentra");
}

Console.WriteLine("El resultado es: " + resultado);
