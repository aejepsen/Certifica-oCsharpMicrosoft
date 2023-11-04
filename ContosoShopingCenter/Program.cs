double total = 0;
double minimumSpend = 30.00;

double[] items = {15.97, 3.50, 12.25, 22.99, 10.98};
double[] discounts = {0.30, 0.00, 0.10, 0.20, 0.50};

for (int i = 0; i < items.Length; i++)
{
    // Calculate the discounted price of the item
    double discountedPrice = GetDiscountedPrice(i);

    // Add the discounted price to the total
    total += Math.Round(discountedPrice, 2);

    // Print the item and the discounted price
    Console.WriteLine($"Item: ${items[i]} Discounted Price: ${discountedPrice}");
    // Console.WriteLine($"Total: ${Math.Round(total, 2)}");
}

if (TotalMeetsMinimum())
{
    total -= 5.00;
}

Console.WriteLine($"Total: ${Math.Round(total, 2)}");

Console.WriteLine($"Total: ${FormatDecimal(total)}");


double GetDiscountedPrice(int itemIndex)
{
    // Calculate the discounted price of the item
    // double result = items[itemIndex] - (items[itemIndex] * discounts[itemIndex]);
    //double result = items[itemIndex] * (1 - discounts[itemIndex]);
    // double roundedResult = Math.Round(result, 2);
    // return roundedResult;

    //return items[itemIndex] * (1 - discounts[itemIndex]);
    return Math.Round(items[itemIndex] * (1 - discounts[itemIndex]), 2);

}

bool TotalMeetsMinimum()
{
    // Check if the total meets the minimum
    return total >= minimumSpend;
}

string FormatDecimal(double input)
{
    // Format the double so only 2 decimal places are displayed
    return input.ToString("0.00");
   // return input.ToString().Substring(0, 5);


}


