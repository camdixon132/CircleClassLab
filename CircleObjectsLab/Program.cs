using CircleObjectsLab;

bool runProgram = true;
int circleCount = 0;


Console.WriteLine("Welcome to the Circle Tester");

while (runProgram)
{
    circleCount += 1;

    Console.WriteLine("Enter radius");
    double input = double.Parse(Console.ReadLine());

    Circle userCircle = new Circle(input);

    Console.WriteLine(userCircle.CalculateFormattedCircumference());
    Console.WriteLine(userCircle.CalculateFormattedArea());

    Console.WriteLine("Continue? y/n");
    string again = Console.ReadLine();
    if (again == "y" || again == "yes")
    {
        runProgram = true;
    }
    else
    {
        Console.WriteLine($"Goodbye. You created {circleCount} Circle Object(s).");
        runProgram = false;
    }
}