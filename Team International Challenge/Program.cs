//Declare arrays to store the coordinates of the triangle points
double[] coordinatesDotA = new double[2];
double[] coordinatesDotB = new double[2];
double[] coordinatesDotC = new double[2];

//Get the coordinates numbers and store on their respetive array
Console.WriteLine("Enter coordinate x of dot A: ");
coordinatesDotA[0] = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter coordinate y of dot A: ");
coordinatesDotA[1] = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter coordinate x of dot B: ");
coordinatesDotB[0] = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter coordinate y of dot B: ");
coordinatesDotB[1] = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter coordinate x of dot C: ");
coordinatesDotC[0] = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter coordinate y of dot C: ");
coordinatesDotC[1] = Convert.ToDouble(Console.ReadLine());

//Calculate the triangles sides
double ans1 = Math.Pow((coordinatesDotB[0] - coordinatesDotA[0]), 2);
double ans2 = Math.Pow((coordinatesDotB[1] - coordinatesDotA[1]), 2);
double lengthAB = Math.Sqrt((ans1 + ans2));

ans1 = Math.Pow((coordinatesDotC[0] - coordinatesDotB[0]), 2);
ans2 = Math.Pow((coordinatesDotC[1] - coordinatesDotB[1]), 2);
double lengthBC = Math.Sqrt((ans1 + ans2));

ans1 = Math.Pow((coordinatesDotC[0] - coordinatesDotA[0]), 2);
ans2 = Math.Pow((coordinatesDotC[1] - coordinatesDotA[1]), 2);
double lengthAC = Math.Sqrt((ans1 + ans2));

Console.WriteLine($"\nLength of AB is: \'{lengthAB}\'");
Console.WriteLine($"Length of BC is: \'{lengthBC}\'");
Console.WriteLine($"Length of AC is: \'{lengthAC}\'\n");

//Determine if a triangle is equilateral, isosceles
if (lengthAB == lengthBC && lengthAB == lengthAC)
{
    Console.WriteLine($"Triangle IS \'Equilateral\'");
}
else
{
    Console.WriteLine($"Triangle IS NOT \'Equilateral\'");
}

if (lengthAB == lengthAC || lengthAB == lengthBC || lengthAC == lengthBC)
{
    Console.WriteLine($"Triangle IS \'Isosceles\'");
}
else
{
    Console.WriteLine($"Triangle IS NOT \'Isosceles\'");
}

//Determine if the triangle is right
double[] sortListAscending = {lengthAB, lengthAC, lengthBC};
Array.Sort( sortListAscending );

bool right = Convert.ToInt64(Math.Pow(sortListAscending[2], 2)) == Convert.ToInt64(Math.Pow(sortListAscending[1], 2) + Math.Pow(sortListAscending[0], 2));
if (right == true) Console.WriteLine($"Triangle IS \'Right\'");
else Console.WriteLine($"Triangle IS NOT \'Right\'");

//Calculate the perimeter of the triangle
double perimeter = lengthAB + lengthAC + lengthBC;
Console.WriteLine($"\nPerimeter: \'{perimeter}\'");

//Shows the parity numbers from 0 to triangle perimeter
Console.WriteLine("\nParity numbers in range from 0 to triangle perimeter:");
for (int i = 0; i <= perimeter; i += 2)
{
    Console.WriteLine(i);
}
