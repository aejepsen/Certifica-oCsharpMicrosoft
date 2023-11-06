/*
Console.WriteLine("Gerador de números aleatórios");

DisplayRandomNumbers();

void DisplayRandomNumbers() 
{
    Random random = new Random();

    for( int i=0; i <= 5; i++)
    {
        int randomNumber = random.Next(1, 100);
        Console.WriteLine($"Número aleatório: {randomNumber}");
    }
    Console.WriteLine("Fim do programa");
}
*/

using System;

int[] times = {800, 1200, 1600, 2000};
int diff = 0;

void AdjustTimes()
{
    for (int i = 0; i < times.Length; i++) 
    {
        times[i] = ((times[i] + diff)) % 2400;
    }
}

Console.WriteLine("Enter current GMT");
int currentGMT = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Current Medicine Schedule:");
DisplayTimes();

Console.WriteLine("Enter new GMT");
int newGMT = Convert.ToInt32(Console.ReadLine());
DisplayTimes(); 

if (Math.Abs(newGMT) > 12 || Math.Abs(currentGMT) > 12)
{
    Console.WriteLine("Invalid GMT");
}
else if (newGMT <= 0 && currentGMT <= 0 || newGMT >= 0 && currentGMT >= 0) 
{
    diff = 100 * (Math.Abs(newGMT) - Math.Abs(currentGMT));

    /* Adjust the times by adding the difference, keeping the value within 24 hours */
    AdjustTimes();
} 
else 
{
    diff = 100 * (Math.Abs(newGMT) + Math.Abs(currentGMT));

    /* Adjust the times by adding the difference, keeping the value within 24 hours */
    AdjustTimes();
}


Console.WriteLine("New Medicine Schedule:");
/* Format and display medicine times */
void DisplayTimes()
{
foreach (int val in times)
{
    string time = val.ToString();
    int len = time.Length;

    if (len >= 3)
    {
        time = time.Insert(len - 2, ":");
    }
    else if (len == 2)
    {
        time = time.Insert(0, "0:");
    }
    else
    {
        time = time.Insert(0, "0:0");
    }

    Console.Write($"{time} ");
}


Console.WriteLine();
}