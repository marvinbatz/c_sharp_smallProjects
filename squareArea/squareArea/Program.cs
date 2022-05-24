// Rectangle area calculation
// Convertimos lo capturado a float
Console.WriteLine("Please enter the side A of the rectangle");
float sideA = float.Parse(Console.ReadLine());

Console.WriteLine("Please enter the side B of the rectangle");
int sideB = int.Parse(Console.ReadLine());


// Rectangel area formule is a * b
float areaRectangle = sideA * sideB;

Console.WriteLine("the rectangle area is: " + areaRectangle);