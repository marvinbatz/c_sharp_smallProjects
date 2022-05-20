// Se declara una lista
List<string> tacoShoppingList = new List<string>();

// Se agregan instancias a la lista
tacoShoppingList.Add("Cinco Tacos de Suadero");
tacoShoppingList.Add("Cuatro Tacos de Tripa");
tacoShoppingList.Add("Seis Tacos al Pastor");
tacoShoppingList.Add("Cuatro Bebidas");

for (int i = 0; i < tacoShoppingList.Count; i++)
{
    Console.WriteLine(tacoShoppingList[i]);
}

Console.WriteLine("\n");

// Eliminar una instancia de la lista
tacoShoppingList.Remove("Cinco Tacos de Suadero");

for (int i = 0; i < tacoShoppingList.Count; i++)
{
    Console.WriteLine(tacoShoppingList[i]);
}

// Eliminar una instancia de la lista con su posición.
//tacoShoppingList.RemoveAt(0);

// Ordenar elementos de la lista
//personNames.Sort();