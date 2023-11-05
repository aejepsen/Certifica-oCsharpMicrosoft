string[] palindromos = new string[] { "racecar", "anna", "civi", "kayak", "level", "mada", "mom", "noon", "radr", "refer", "wow" };

foreach (var item in palindromos)
{
    Console.WriteLine($"{item} = {ReverseArray(item)} is {IsPalindrome(item)}");
}

bool IsPalindrome(string input)
{
    ReverseArray(input);
    return input == Reverse(input);
}

string Reverse(string input)
{
    return new string(input.Reverse().ToArray());
}

string ReverseArray(string input)
{
    char[] reverseArray = input.ToCharArray();
    Array.Reverse(reverseArray);
    return new string(reverseArray);
}
