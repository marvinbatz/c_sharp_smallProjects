string person1 = "Marvin";
string person2 = "Josue";
string person3 = "Lucky";
string person4 = "Esther";

// Generando un numerado r de numeros random
Random rnd = new Random();
Console.WriteLine("Random numbers: ");
// Imprimimos un numero random entre 1 y 10 y al utilizar el $ lo remplazamos por la concatenacion +
Console.WriteLine($"El numero random es: {rnd.Next(1,10)}");

string classTopic = "Methods of strings";
string name = "Marvin Batz";
Console.WriteLine($"{classTopic} por: {name}");

// Realizamos un clon exacto de la variable de tipo objeto, por tal razón lo convertimos a string con ToString
string nameClone = name.Clone().ToString();
Console.WriteLine(nameClone);

// Compara las variables y devuelve 0 como True y 1 como false
Console.WriteLine(classTopic.CompareTo(name));

// Busca si contiene los siguientes caracteres
Console.WriteLine(person1.Contains("Mar"));


//EndsWith() Similar a Contains(), pero para comparar si los caracteres están al final del string.
Console.WriteLine(person2.EndsWith("ue"));


/*
StartsWith()
Console.WriteLine(School.StartsWith("Pl"));
Funciona de la misma manera que EndsWith(), pero en este caso comprueba si empieza con una serie de caracteres indicados.

Equals()
Console.WriteLine(School.Equals(SchoolClone));
Funciona de forma parecida a CompareTo(), pero para indicar si el contenido de ambos strings retorna True o False.

IndexOf()
Console.WriteLine(School.IndexOf("a"));
Regresa la posición dentro del string del carácter indicado en el argumento.

ToLower() y ToUpper()
Console.WriteLine(ClassTopic.ToLower());
Console.WriteLine(ClassTopic.ToUpper());
Convierten el string en todas letras minúsculas o mayúsculas.

Insert()
Console.WriteLine(School.Insert(6, " es educación online efectiva"));	
Inserta un nuevo string dentro de otro en la posición indicada dentro de los argumentos. En este caso es en 6 que es la posición después de la última letra de “Platzi”.

LastIndexOf()
Console.WriteLine(ClassTopic.LastIndexOf("s"));
Regresa la posición de la última vez que aparece el carácter. En este caso la letra “s” aparece varias veces en el string y así podemos notar cómo devuelve la última posición en la que aparece.

Remove()
Console.WriteLine(ClassTopic.Remove(6));
Elimina los caracteres del string a partir de la posición que le indiquemos hasta el final.

Replace()
Console.WriteLine(ClassTopic.Replace("s", "z"));
Reemplaza all los caracteres por otro indicado. En este caso todas las “s” serán cambiadas por “z”.

Split()
string[] split = ClassTopic.Split(new char[] { 's' });		
		
        Console.WriteLine(split[0]);
        Console.WriteLine(split[1]);
        Console.WriteLine(split[2]);
Este es un caso especial donde creamos un nuevo string donde guardamos el string separado en trozos por la letra indicada en los argumentos del método. Para este caso se separa por la letra “s” en 3 trozos que son los que imprimimos.

Substring()
Console.WriteLine(ClassTopic.Substring(2,10));
Devuelve un substring o trozo de string de acuerdo a las posiciones indicadas en los argumentos.

ToCharArray()
School.ToCharArray();
Convierte el string en un arreglo de caracteres.

Trim()
string TextWithSpaces = "  hola, había espacios al principio y al final ";
Console.WriteLine(TextWithSpaces.Trim());

Elimina espacios al principio y al final de un string.
*/
