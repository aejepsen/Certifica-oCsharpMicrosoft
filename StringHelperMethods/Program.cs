/*
string message = "Find what is (inside the parentheses)";

int openingPosition = message.IndexOf('(');
int closingPosition = message.IndexOf(')');

Console.WriteLine(openingPosition);
Console.WriteLine(closingPosition);

int length = closingPosition - openingPosition;
Console.WriteLine(message.Substring(openingPosition+1, length-1));

string message1 = "What is the value <span>between the tags</span>?";

int openingPosition1 = message1.IndexOf("<span>");
int closingPosition1 = message1.IndexOf("</span>");
Console.WriteLine(openingPosition1);
Console.WriteLine(closingPosition1);    

openingPosition += 1;
int length1 = closingPosition1 - openingPosition1;
Console.WriteLine(message1.Substring(openingPosition1 +6, length1-6));


string message4 = "(What if) I am (only interested) in the last (set of parentheses)?";
int openingPosition4 = message4.LastIndexOf('(');

openingPosition4 += 1;
int closingPosition4 = message4.LastIndexOf(')');
int length4 = closingPosition4 - openingPosition4;
Console.WriteLine(message4.Substring(openingPosition4, length4));

Console.WriteLine();
Console.WriteLine();

string message5 = "(What if) there are (more than) one (set of parentheses)?";
while (true)
{
    int openingPosition5 = message5.IndexOf('(');
    Console.WriteLine(openingPosition5);
    if (openingPosition5 == -1) break;

    openingPosition5 += 1;
    int closingPosition5 = message5.IndexOf(')');
    Console.WriteLine(closingPosition5);
    
    int length5 = closingPosition5 - openingPosition5;
    Console.WriteLine(message5.Substring(openingPosition5, length5));

    // Note the overload of the Substring to return only the remaining 
    // unprocessed message:
    message5 = message5.Substring(closingPosition5 + 1);
}
*/
string message = "Help (find) the {opening symbols}";
Console.WriteLine($"Searching THIS Message: {message}");
char[] openSymbols = { '[', '{', '(' };
int startPosition = 6;
int openingPosition = message.IndexOfAny(openSymbols);
Console.WriteLine(openingPosition);
Console.WriteLine($"Found WITHOUT using startPosition: {message.Substring(openingPosition)}");

openingPosition = message.IndexOfAny(openSymbols, startPosition);
Console.WriteLine(openingPosition); 
Console.WriteLine($"Found WITH using startPosition: {message.Substring(openingPosition)}");