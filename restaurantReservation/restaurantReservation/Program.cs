// Validacion si el usuario existe o se debe registrar.
// Si existe el usuario debe de darle la bienvenida.
// El programa debe de repetirse hasta que hayan 10 registros.

string[] userNames = new string[10]{"", "", "", "", "", "", "", "", "", ""};
int arrayCurrentIndex = 9;
bool userType;
string userNameSearch;

Console.WriteLine("Wellcome!");
// Con while true generara un ciclo automático
while(arrayCurrentIndex < 10)
{
    Console.WriteLine("Are you a registered user? write true or false");
    // Esta linea convertira la palabra que se ingrese a true o false y lo guardara en la variable.
    userType = Convert.ToBoolean(Console.ReadLine());

    if (userType == true)
    {
        Console.WriteLine("Please enter your user name: ");
        userNameSearch = Console.ReadLine();

        // Lo que hace la siguiente linea es buscar dentro de un array (en cada elemento) el string que pasamos como parametro.
        // Primer parametro, en donde vas a buscar y segundo, que vas a encontrar.
        // Si devulve -1 significa que no encontro elementos en el array
        int index = Array.IndexOf(userNames, userNameSearch);
        if (index == -1)
        {
            Console.WriteLine($"Username {userNameSearch} not found, try again or register");
        }
        else
        {
            Console.WriteLine($"Welcome {userNameSearch} \n \n");
        }
    }
    else if (userType == false)
    {
        Console.WriteLine("Please registred you username");
        // arrayCurrentIndex nos permite guardar lo leido al arreglo
        userNames[arrayCurrentIndex] = Console.ReadLine();
        Console.Write($"Your user has been saved successfully {userNames[arrayCurrentIndex]} \n \n");
        arrayCurrentIndex++;
    }
}
Console.WriteLine("The restaurant is full, sorry \n These are the guest to the dinner");
// el foreach recorre cada elemento de nuestro array.
int auxIndex = 0;
foreach (string element in userNames)
{
    Console.WriteLine($"UserName Registered: {auxIndex+1} - {element}");
    auxIndex++;
}
// con esta linea salimos de la terimnal.
Environment.Exit(0);