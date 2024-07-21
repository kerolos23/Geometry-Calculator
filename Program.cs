
DisplayWelcomeMessage("our geometry calculator");

// Types of calculations
string[] sCalculationTypes = new string[2] { "Area", "Perimete" };
// Shapes available for calculation
string[] sShapes = new string[7] { "Circle", "Triangle", "Rectangle", "Square", "Trapezium", "Parallelgram", "Rhombus" };

StartApplication();

// Start app
void StartApplication()
{
    bool bIsRunning = true;

    while (bIsRunning)
    {
        int nSelectedTypeIndex;
        if (GetSelection(out nSelectedTypeIndex, sCalculationTypes, "Types"))
        {
            Console.Clear();
            PerformCalculation(nSelectedTypeIndex);
            if (!PromptRetry())
                bIsRunning = false;
        }
        else
        {
            if (!PromptRetry())
            {
                Console.WriteLine("Please enter valid number :(");
                bIsRunning = false;
            }
        }
    }
}

// Displays a welcome message to the user
void DisplayWelcomeMessage(string message)
{
    Console.WriteLine($"Welcome to {message} Application :)");
}

// Prompts the user to retry the application
bool PromptRetry()
{
    Console.Write("Do you want try again? (Y/N) ");
    string? sReadAnswer = Console.ReadLine();
    Console.Clear();

    switch (sReadAnswer)
    {
        case "y":
        case "Y":
        case "Yes":
        case "yes":
        case "YES":
        default:
            return true;
        case "n":
        case "N":
        case "No":
        case "no":
        case "NO":
            return false;
    }
}

// Displays options to the user and gets their selection
void DisplayOptions(string message, string[] options)
{
    Console.WriteLine($"Select from {message}: ");

    for (int i = 0; i < options.Length; i++)
    {
        Console.WriteLine($"{i + 1}- {options[i]}");
    }
    Console.Write("=> ");
}

// Reads a number from the user
bool ReadUserInput(out int number)
{
    bool bIsValid = int.TryParse(Console.ReadLine(), out number);
    return bIsValid;
}

// Executes the appropriate calculation based on the user's selection
void PerformCalculation(int number)
{
    switch (number)
    {
        case 1:
            CalculateArea();
            break;
        case 2:
            CalculatePerimeter();
            break;
    }
}

// method to get seloction from the user
bool GetSelection(out int number, string[] array, string message)
{
    DisplayOptions($"{message}", array);
    return ReadUserInput(out number);
}

// Handles the area calculation based on the selected shape
void CalculateArea()
{
    int nSelectedShapeIndex;
    if (GetSelection(out nSelectedShapeIndex, sShapes, "Area Apps"))
    {
        Console.Clear();
        CheckAreaApps(nSelectedShapeIndex, "area");
    }
    else
    {
        if (!PromptRetry())
            return;
    }
}

// Handles the perimeter calculation based on the selected shape
void CalculatePerimeter()
{
    int nSelectedShapeIndex;
    if (GetSelection(out nSelectedShapeIndex, sShapes, "Perimeter Apps"))
    {
        Console.Clear();
        CheckAreaApps(nSelectedShapeIndex, "perimeter");
    }
    else
    {
        if (!PromptRetry())
            return;
    }
}

// Method for check any app will run
void CheckAreaApps(int number, string type)
{
    switch (number)
    {
        case 1:
            switch (type)
            {
                case "area":
                    AreaOfCircle();
                    break;
                case "perimeter":
                    PerimeterOfCircle();
                    break;
            }
            break;
        case 2:
            switch (type)
            {
                case "area":
                    AreaOfTriangle();
                    break;
                case "perimeter":
                    PerimeterOfTriangle();
                    break;
            }
            break;
        case 3:
            switch (type)
            {
                case "area":
                    AreaOfRectangle();
                    break;
                case "perimeter":
                    PerimeterOfRectangle();
                    break;
            }
            break;
        case 4:
            switch (type)
            {
                case "area":
                    AreaOfSquare();
                    break;
                case "perimeter":
                    PerimeterOfSquare();
                    break;
            }
            break;
        case 5:
            switch (type)
            {
                case "area":
                    AreaOfTrapezium();
                    break;
                case "perimeter":
                    PerimeterOfTrapezium();
                    break;
            }
            break;
        case 6:
            switch (type)
            {
                case "area":
                    AreaOfParallelogram();
                    break;
                case "perimeter":
                    PerimeterOfParallelogram();
                    break;
            }
            break;
        case 7:
            switch (type)
            {
                case "area":
                    AreaOfRhombus();
                    break;
                case "perimeter":
                    PerimeterOfRhombus();
                    break;
            }
            break;
    }
}

// ###########################
// Calculation for the area of a circle
void AreaOfCircle()
{
    DisplayWelcomeMessage("Area OF Circle");

    Console.Write("Enter the Radiuce of circle: ");
    int nRadius;
    if (!ReadUserInput(out nRadius))
        return;

    DisplayResult("π(Radius x Radius)", $"3.14({nRadius} x {nRadius})", $"{3.15 * (nRadius * nRadius)}");
}

// Calculation for the area of a triangle
void AreaOfTriangle()
{
    DisplayWelcomeMessage("Area OF Triangle");

    Console.Write("Enter the Base of Triangle: ");
    int nBase;
    if (!ReadUserInput(out nBase))
        return;

    Console.Write("Enter the Height of Triangle: ");
    int nHeight;
    if (!ReadUserInput(out nHeight))
        return;

    DisplayResult("(Base x Height) / 2", $"({nBase} x {nHeight}) / 2", $"{(nBase * nHeight) / 2}");

}

// Calculation for the area of a rectangle
void AreaOfRectangle()
{
    DisplayWelcomeMessage("Area of Rectangle");

    Console.Write("Enter the width of Rectangle: ");
    int nWidth;
    if (!ReadUserInput(out nWidth))
        return;

    Console.Write("Enter the Length of Rectangle: ");
    int nLength;
    if (!ReadUserInput(out nLength))
        return;

    DisplayResult("Width x Length", $"{nWidth} x {nLength}", $"{nWidth * nLength}");
}

// Calculation for the area of a square
void AreaOfSquare()
{
    DisplayWelcomeMessage("Area OF Square");

    Console.Write("Enter the Side of Square: ");
    int nSide;
    if (!ReadUserInput(out nSide))
        return;

    DisplayResult("Side x Side", $"{nSide} x {nSide}", $"{nSide * nSide}");
}

// Calculation for the area of a trapezium
void AreaOfTrapezium()
{
    DisplayWelcomeMessage("Area of Trapezium");

    Console.Write("Enter the Length of Trapezium: ");
    int nLength;
    if (!ReadUserInput(out nLength))
        return;

    Console.Write("Enter the Base of Trapezium: ");
    int nBase;
    if (!ReadUserInput(out nBase))
        return;

    Console.Write("Enter the Height of Trapezium: ");
    int nHeight;
    if (!ReadUserInput(out nHeight))
        return;

    DisplayResult("((Length + Base) / 2) x Height", $"(({nLength} + {nBase}) / 2) x {nHeight}", $"{((nLength + nBase) / 2) * nHeight}");
}

// Calculation for the area of a parallelogram
void AreaOfParallelogram()
{
    DisplayWelcomeMessage("Area OF Parallelogram");

    Console.Write("Enter the Base of Parallelogram: ");
    int nBase;
    if (!ReadUserInput(out nBase))
        return;

    Console.Write("Enter the Height of Parallelogram: ");
    int nHeight;
    if (!ReadUserInput(out nHeight))
        return;

    DisplayResult("Base x Height", $"{nBase} x {nHeight}", $"{nBase * nHeight}");
}

// Calculation for the area of a rhombus
void AreaOfRhombus()
{
    DisplayWelcomeMessage("Area OF Rhombus");

    Console.Write("Enter the First Diagonal of Rhombus: ");
    int nFirstDiagonal;
    if (!ReadUserInput(out nFirstDiagonal))
        return;

    Console.Write("Enter the Second Diagonal of Rhombus: ");
    int nSecondDiagonal;
    if (!ReadUserInput(out nSecondDiagonal))
        return;

    DisplayResult("(First Diagonal x Second Diagonal) / 2", $"({nFirstDiagonal} x {nSecondDiagonal}) / 2", $"{(nFirstDiagonal * nSecondDiagonal) / 2}");
}

// Calculation for the perimeter of a circle
void PerimeterOfCircle()
{
    DisplayWelcomeMessage("Perimeter OF Circle");

    Console.Write("Enter the Radiuce of circle: ");
    int nRadius;
    if (!ReadUserInput(out nRadius))
        return;

    DisplayResult("(2 x Radius) x 3.14", $"(2 x {nRadius}) x 3.14", $"{(2 * nRadius) * 3.14}");
}

// Calculation for the perimeter of a triangle
void PerimeterOfTriangle()
{
    DisplayWelcomeMessage("Perimeter OF Triangle");

    Console.Write("Enter the Base of Triangle: ");
    int nBase;
    if (!ReadUserInput(out nBase))
        return;

    Console.Write("Enter the First Side of Triangle: ");
    int nFirstSide;
    if (!ReadUserInput(out nFirstSide))
        return;

    Console.Write("Enter the Second Side of Triangle: ");
    int nSecondSide;
    if (!ReadUserInput(out nSecondSide))
        return;

    DisplayResult("Side1 + Side2 + Base", $"{nFirstSide} + {nSecondSide} + {nBase}", $"{nFirstSide + nSecondSide + nBase}");
}

// Calculation for the perimeter of a rectangle
void PerimeterOfRectangle()
{
    DisplayWelcomeMessage("Perimenter of Rectangle");

    Console.Write("Enter the Length of Rectangle: ");
    int nLength;
    if (!ReadUserInput(out nLength))
        return;

    Console.Write("Enter the width of Rectangle: ");
    int nWidth;
    if (!ReadUserInput(out nWidth))
        return;

    DisplayResult("2(Width + Length)", $"2({nWidth} + {nLength})", $"{2 * (nWidth + nLength)}");
}

// Calculation for the perimeter of a square
void PerimeterOfSquare()
{
    DisplayWelcomeMessage("Perimeter OF Square");

    Console.Write("Enter the Side of Square: ");
    int nSide;
    if (!ReadUserInput(out nSide))
        return;

    DisplayResult("Side x 4", $"{nSide} x 4", $"{nSide * 4}");
}

// Calculation for the perimeter of a trapezium
void PerimeterOfTrapezium()
{
    DisplayWelcomeMessage("Perimeter of Trapezium");

    Console.Write("Enter the First Side of Trapezium: ");
    int nFristSide;
    if (!ReadUserInput(out nFristSide))
        return;

    Console.Write("Enter the Second Side of Trapezium: ");
    int nSecondSide;
    if (!ReadUserInput(out nSecondSide))
        return;

    Console.Write("Enter the First Base of Trapezium: ");
    int nFirstBase;
    if (!ReadUserInput(out nFirstBase))
        return;

    Console.Write("Enter the Second Base of Trapezium: ");
    int nSecondBase;
    if (!ReadUserInput(out nSecondBase))
        return;

    DisplayResult("Base1 + Side1 + Base2 + Side2", $"{nFirstBase} + {nFristSide} + {nSecondBase} + {nSecondSide}", $"{nFirstBase + nFristSide + nSecondBase + nSecondSide}");
}

// Calculation for the perimeter of a parallelogram
void PerimeterOfParallelogram()
{
    DisplayWelcomeMessage("Perimeter OF Parallelogram");

    Console.Write("Enter the Base of Parallelogram: ");
    int nBase;
    if (!ReadUserInput(out nBase))
        return;

    Console.Write("Enter the Side of Parallelogram: ");
    int nSide;
    if (!ReadUserInput(out nSide))
        return;

    DisplayResult("2(Side + Base)", $"2({nSide} + {nBase})", $"{2 * (nBase + nSide)}");
}

// Calculation for the perimeter of a rhombus
void PerimeterOfRhombus()
{
    DisplayWelcomeMessage("Perimeter OF Rhombus");

    Console.Write("Enter the Side of Rhombus: ");
    int nSide;
    if (!ReadUserInput(out nSide))
        return;

    DisplayResult("Side x 4", $"{nSide} x 4", $"{nSide * 4}");
}
// ###########################

// Displays the result of a calculation
void DisplayResult(string role, string calc, string result)
{
    Console.WriteLine();
    Console.WriteLine("-----------Result-----------");
    Console.WriteLine($"Role: {role} = {calc}");
    Console.WriteLine($"Result: {result}");
    Console.WriteLine("----------------------------");
    Console.WriteLine();
}