bool value1 = true;
bool value2 = true;
bool value3 = false;

// && , || , !

bool result = value1 && value2 && value3;
Console.WriteLine("The value of logical AND is: " + result);

bool result2 = value1 || value2 || !value3;
Console.WriteLine("The value of logical OR is: " + result2);

bool result3 = !value1;
Console.WriteLine("The value of logical OR is: " + result3);