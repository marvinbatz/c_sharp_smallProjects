// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string[] coffeTypes;
float[] coffeValues;

// Con new string declaramos que estamos agregando nuevas cadenas a nuestro arreglo.
coffeTypes = new string[] {"Expreso", "Capuccino", "Latte", "Filtrado" };
coffeValues = new float[] { 1.2f, 1.5f, 5.2f, 5.5f };

//  con .length contamos cuantos registros hay
for (var i = 0; i < coffeTypes.Length; i++)
{
    Console.WriteLine("El valor del: " + coffeTypes[i] + " es de: " + coffeValues[i]);
}