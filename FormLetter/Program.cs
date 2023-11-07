string customerName = "Ms. Barros";

string currentProduct = "Magic Yield";
int currentShares = 2975000;
decimal currentReturn = 0.1275m;
decimal currentProfit = 55000000.0m;

string newProduct = "Glorious Future";
decimal newReturn = 0.13125m;
decimal newProfit = 63000000.0m;
/*Dear Ms. Barros,
  As a customer of our Magic Yield offering we are excited to tell you about a new financial product that would dramatically increase your return.

  Currently, you own 2,975,000.00 shares at a return of 12.75 %.

  Our new product, Glorious Future offers a return of 13.13 %.  Given your current volume, your potential profit would be ¤63,000,000.00. 

  Here's a quick comparison:

  Magic Yield         12.75 %   $55,000,000.00      
  Glorious Future     13.13 %   $63,000,000.00  */


string comparisonMessage = "";

// Your logic here

Console.WriteLine(comparisonMessage);

comparisonMessage = string.Format(
    "Dear {0}, \n\n" +
    "As a customer of our {1} offering we are excited to tell you about a new financial product that would dramatically increase your return.\n" +
    "Currently, you own {2:N} shares at a return of {3:P}.\n" +
    "Our new product, {4} offers a return of {5:P}.  Given your current volume, your potential profit would be {6:C}.\n", customerName, currentProduct, currentShares, currentReturn, newProduct, newReturn, newProfit);

Console.WriteLine(comparisonMessage);
Console.WriteLine("Here's a quick comparison:\n");

string comparisonMessage1 = "";

comparisonMessage1 = currentProduct.PadRight(20);
comparisonMessage1 += String.Format("{0:P}", currentReturn).PadRight(10);
comparisonMessage1 += String.Format("{0:C}", currentProfit).PadRight(20);

comparisonMessage1 += "\n";
comparisonMessage1 += newProduct.PadRight(20);
comparisonMessage1 += String.Format("{0:P}", newReturn).PadRight(10);
comparisonMessage1 += String.Format("{0:C}", newProfit).PadRight(20);

Console.WriteLine(comparisonMessage1);

string comparisonMessage2 = string.Format(
    "{0}         {1:P}    {2:C}\n" + 
    "{3}     {4:P}    {5:C}", currentProduct, currentReturn, currentProfit, newProduct, newReturn, newProfit);

Console.WriteLine(comparisonMessage2);