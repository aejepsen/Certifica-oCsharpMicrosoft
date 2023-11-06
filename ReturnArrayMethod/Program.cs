int[] TwoCoins(int[] coins, int target)
{
    int[] result = new int[2];
    for (int i = 0; i < coins.Length; i++)
    {
        for (int j = i + 1; j < coins.Length; j++)
        {
            if (coins[i] + coins[j] == target)
            {
                result[0] = i;
                result[1] = j;
                Console.WriteLine($"{coins[i]} + {coins[j]} = {target}");
                //return result;
            } else
            {
                Console.WriteLine($"{coins[i]} + {coins[j]} != {target}");
                // return new int[0];
            }
        }
    }
    return result;
}

int target = 30;
int[] coins = new int[] {5, 5, 50, 25, 25, 10, 5};
int[,] result = TwoCoinsA(coins, target);
//TwoCoins(new int[] { 2, 7, 11, 2 }, 9);


if(result.Length == 0)
    {
        Console.WriteLine("No two coins make change");
    } else
    {
        Console.WriteLine($"Change found at positions:");
        for (int i = 0; i < result.GetLength(0); i++)
        {
            if (result[i, 0] == -1)
            {
                break;
            }
            Console.WriteLine($"{result[i,0]}, {result[i,1]}");
        }
    }
    
int[,] TwoCoinsA(int[] coins, int target)
{
    int[,] result = {{-1,-1},{-1,-1},{-1,-1},{-1,-1},{-1,-1}};
    int count = 0;

    for (int i = 0; i < coins.Length; i++)
    {
        for (int j = i + 1; j < coins.Length; j++)
        {
            if (coins[i] + coins[j] == target)
            {
                result[count, 0] = i;
                result[count, 1] = j;
                Console.WriteLine($"{coins[i]} + {coins[j]} = {target}");
                count++;
                Console.WriteLine($"Count: {count}");   
            }
            if (count == result.GetLength(0))
            {
                return result;
            }
            else if (coins[i] + coins[j] != target)
            {
                //Console.WriteLine($"{coins[i]} + {coins[j]} != {target}");
            }
        }
    }
    return (count == 0) ? new int[0, 0] : result;
}



//TwoCoinsA(coins, target);