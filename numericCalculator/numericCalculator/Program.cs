// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ingrese el primer numero");

int num1;
int num2;
int resultado;

Console.WriteLine("Input the first number: ");
// Hacemos una conversion a entero, ya que el readline es un string
num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input the second number: ");
num2 = Convert.ToInt32(Console.ReadLine());

resultado = num1 * num2;

Console.WriteLine("El resultado de la multiplicacion es : " + resultado);