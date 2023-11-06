string[] palindromos = new string[] { "racecar", "anna", "civi", "kayak", "level", "mada", "mom", "noon", "radr", "refer", "wow" };

foreach (var item in palindromos)
{
    Console.WriteLine($"{item} = {ReverseArray(item)} is {IsPalindrome(item)} is {IsPalindrome2(item)}");
}

bool IsPalindrome2(string input)
{
    int start = 0;
    int end = input.Length - 1;

    while(start < end)
    {
        if(input[start] != input[end])
        {
            return false;
        }
        start++;
        end--;       
    }
    return true;
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
