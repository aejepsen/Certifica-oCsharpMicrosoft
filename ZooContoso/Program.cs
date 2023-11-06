using System;

string[] pettingZoo = 
{
    "alpacas", "capybaras", "chickens", "ducks", "emus", "geese", 
    "goats", "iguanas", "kangaroos", "lemurs", "llamas", "macaws", 
    "ostriches", "pigs", "ponies", "rabbits", "sheep", "tortoises",
};

/* - Serão três escolas visitantes
//    - A escola A possui seis grupos de visitantes (o número padrão)
//     - A escola B possui três grupos visitantes
//     - A Escola C possui dois grupos de visitação

//- Para cada escola visitante, execute as seguintes tarefas
//     - Randomize os animais
//     - Distribua os animais ao número correto de grupos
//     - Imprimir o nome da escola
    - Imprima os grupos de animais */

void PlanSchoolVisit(string schoolName, int groups = 6)
{
    RandomizeAnimals();
    string[,] group = AssignGroup(groups);
    PrintGroup(group, schoolName);
}

PlanSchoolVisit("School A");
PlanSchoolVisit("School B", 3);
PlanSchoolVisit("School C", 2);

void RandomizeAnimals()
{
    Random random = new Random();
    for (int i = 0; i < pettingZoo.Length; i++)
    {
        int r  = random.Next(i, pettingZoo.Length);
        string temp = pettingZoo[i];
        pettingZoo[i] = pettingZoo[r];
        pettingZoo[r
        ] = temp;
    }
}

string[,] AssignGroup(int groups = 6)
{
    int start = 0;
    string[,] result = new string[groups, pettingZoo.Length / groups];
    for (int i = 0; i < groups; i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = pettingZoo[start];
            start++;
        }
    }
    return result;
}

void PrintGroup(string[,] group, string schoolName = "School A")
{
    Console.WriteLine(schoolName);
    for (int i = 0; i < group.GetLength(0); i++)
    {
        Console.Write($"Group {i + 1}: ");
        for (int j = 0; j < group.GetLength(1); j++)
        {
            Console.Write($"{group[i, j]}, ");
        }
        Console.WriteLine();
    }
}

