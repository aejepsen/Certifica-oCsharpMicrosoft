double usd = 23.73;

int vnd = UsdToVnd1(usd);
Console.WriteLine($"${usd} USD = ${vnd} VND");

//double vnd2 = UsdToVnd2(usd);
//Console.WriteLine($"{usd} USD is {vnd2} VND");

Console.WriteLine($"${vnd} VND = ${VndToUsd(vnd)} USD");


int UsdToVnd1(double usd)
{
    int rate = 23500;
    return (int)(usd * rate);
}

//double UsdToVnd2(double usd)
//{
//   double rate = 23500;
//   return (usd * rate);
//}

double VndToUsd(double vnd)
{
    double rate = 23500;
    return (vnd / rate);
}