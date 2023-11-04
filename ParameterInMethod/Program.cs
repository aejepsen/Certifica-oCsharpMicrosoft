CountTo(5);

// Path: ParameterInMethod/Program.cs

void CountTo(int maxNumber)
{
    for (int i = 1; i <= maxNumber; i++)
    {
        Console.WriteLine(i);
    }
}

int[] schedule = new int[4] {800, 1200, 1400, 1800};
    DisplayScheduleTimes(schedule, 6, -6);

void DisplayScheduleTimes(int[] times, int currentGMT, int newGMT)
{
    int diff = 0;

    if(Math.Abs(newGMT) > 12 || Math.Abs(currentGMT) > 12)
    {
        Console.WriteLine("Invalid GMT");
    }
    else if (newGMT <= 0 && currentGMT <= 0 && newGMT >= 0 && currentGMT >= 0)
    {
        diff = 100 * (Math.Abs(newGMT) - Math.Abs(currentGMT));
    }
    else
    {
        diff = 100 * (Math.Abs(newGMT) + Math.Abs(currentGMT));
    }

    for (int i = 0; i < times.Length; i++)
    {
        int newTime = (times[i] + diff) % 2400;
        Console.WriteLine($"{times[i]} becomes {newTime}"); 
    }

    string [] students = {"Sally", "Joe", "Bob", "Jane"};

    DisplayStudents(students);
    DisplayStudents(new string[] {"Robert", "Mary"});

    void DisplayStudents(string[] students)
    {
        foreach (string student in students)
        {
            Console.WriteLine(student);
            Console.WriteLine(students.Length);
        }
    }

    double pi = 3.14159;
    PrintCircleInfo(12);
    PrintCircleInfo(24);

    void PrintCircleInfo(int radius)
    {
        PrintCircleArea(radius);
        PrintCircleCircumference(radius);
    }

    void PrintCircleArea(int radius)
    {
        double area = pi * radius * radius;
        Console.WriteLine($"The area of a circle with radius {radius} is {area}");
    }

    void PrintCircleCircumference(int radius)
    {
        double circumference = 2 * pi * radius;
        Console.WriteLine($"The circumference of a circle with radius {radius} is {circumference}");
    }

    int a= 3;
    int b = 4;
    int c = 0;

    Multiply(a, b, c);
    Console.WriteLine($"global statement: {a} x {b} = {c}");

    void Multiply(int a, int b, int c)
    {
        c = a * b;
        Console.WriteLine($"inside Multiply method {a} x {b} = {c}");
    }

    int[] array = {1, 2, 3, 4, 5};

    PrintArray(array);
    Clear(array);
    PrintArray(array);

    void PrintArray(int[] array)
    {
        foreach (int item in array)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine();
    }

    void Clear(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = 0;
        }
    }

    string status = "Healthy";

    Console.WriteLine($"Start: {status}");
    SetHealth(status, false);
    SetHealthA(false);
    Console.WriteLine($"End: {status}");

    void SetHealth(string status, bool isHealthy)
    {
        string statusA = (isHealthy ? "Healthy" : "Not Healthy");
        
        Console.WriteLine($"Middle: {status}");
    }

    void SetHealthA(bool isHealthy)
    {
        status = (isHealthy ? "Healthy" : "Not Healthy");
        Console.WriteLine($"Middle: {status}");
    }




}

