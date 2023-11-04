string HelloWord = "Hello World";

// Path: ReverseString/ReverseString.cs

string Reverse(string input)
{
    return new string(input.Reverse().ToArray());
}

Console.WriteLine(Reverse(HelloWord));

for (int i = HelloWord.Length - 1; i >= 0; i--)
{
    Console.Write(HelloWord[i]);
}

char[] reverseArray = HelloWord.ToCharArray();
Array.Reverse(reverseArray);
Console.WriteLine();
Console.WriteLine(new string(reverseArray));

// utilizar split
string ReverseSentence(string input)
{
    string[] words = input.Split(' ');
    string result = "";
    for (int i = 0; i < words.Length; i++)
    {
        result += Reverse(words[i]) + " ";
    }
    return result.Trim();
}

string[] words = HelloWord.Split(' ');
for (int i = 0; i < words.Length; i++)
{
    Console.Write(Reverse(words[i]) + " ");
}
//Console.WriteLine($"{words[0]} {Reverse(words[0])} {words[1]} {Reverse(words[1])}");

Console.WriteLine();    
Console.WriteLine(ReverseSentence(HelloWord));