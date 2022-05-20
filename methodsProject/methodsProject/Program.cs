float[] pricesArray;

pricesArray = new float[10];
pricesArray[0] = 1.5f;
pricesArray[1] = 2.5f;
pricesArray[2] = 3f;
pricesArray[3] = 5f;

// Generando un numerado r de numeros random
Random rnd = new Random();
Console.WriteLine("Random numbers: ");
// Imprimimos un numero random entre 1 y 10 y al utilizar el $ lo remplazamos por la concatenacion +
Console.WriteLine($"El numero random es: {rnd.Next(1,10)}");