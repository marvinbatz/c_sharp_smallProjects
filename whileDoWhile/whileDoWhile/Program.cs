bool continueVerify = false;

do
{
    Console.Write("Do you wish the software running? 1 = YES, 2 = NOT \n");
    int option = int.Parse(Console.ReadLine());
    if (option == 1)
    {
        Console.Write("Program Continue! \n");
        continueVerify = true;
    }
    else if (option == 2)
    {
        Console.Write("Bye Bye");
        continueVerify = false;
    }
    else
    {
        Console.Write("ERROR -- Try again \n");
    }
} while (continueVerify == true);