using CircleObjectsLab;


bool runProgram = true;
int circleCount = 0;


Console.WriteLine("Welcome to the Circle Tester");

while (runProgram)
{
    circleCount += 1;

    Console.WriteLine("Enter radius");
    double input = -1;

    while (input <= 0)
    {
       while(double.TryParse(Console.ReadLine(), out input) == false)
        {
            Console.WriteLine("Invalid input, try again.");
        }
       if(input <= 0)
        {
            Console.WriteLine("Number too low, please try again.");
        }
    }

   

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