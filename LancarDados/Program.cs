internal class Program
{
    private static void Main(string[] args)
    {
       /*  Random random = new Random();
        int dado1 = random.Next(1, 7);
        int dado2 = random.Next(1, 7);
        int dado3 = random.Next(1, 7);

        int soma = dado1 + dado2 + dado3;
        
        //Console.WriteLine($"Random roll: {dado1} + {dado2} + {dado3} = {soma}");

        if (soma >= 15)
        {
            //Console.WriteLine("You win!");
        }
        else
        {
            //Console.WriteLine("You lose!");
        }

        string message = "The quick brown fox jumps over the lazy dog.";
        bool result2 = message.Contains("dog");
        //Console.WriteLine(result2);

        if (message.Contains("fox"))
        {
            //Console.WriteLine("What does the fox say?");
        }

        if ((dado1 == dado2) && (dado1 == dado3))
        {
            //Console.WriteLine("You rolled triples! +6 bonus to your roll!");
            soma += 6;
        }
        else if ((dado1 == dado2) || (dado1 == dado3) || (dado2 == dado3))
        {
            //Console.WriteLine("You rolled doubles! +2 bonus to total!");
            soma += 2;
        }

        Random random2 = new Random();
        int daysUntilExpiration = random2.Next(12);
        //Console.WriteLine(daysUntilExpiration);
        //int discountPercentage = 0;

        if (daysUntilExpiration == 0)
        {
            //Console.WriteLine("Your subscription has expired.");
        }
        else if (daysUntilExpiration == 1)
        {
            //discountPercentage = 20;
            //Console.WriteLine("Your subscription expires within a day!");
            //Console.WriteLine($"Renew now and save {discountPercentage}%!");
        }
        else if (daysUntilExpiration <= 5)
        {
            //discountPercentage = 10;
           // Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.");
           // Console.WriteLine($"Renew now and save {discountPercentage}%!");
        }
        else if (daysUntilExpiration <= 10)
        {
            //Console.WriteLine("Your subscription will expire soon.  Renew now!");
        }

        string[] fraudulentOrderIDs = new string[3];

        fraudulentOrderIDs[0] = "A123";
        fraudulentOrderIDs[1] = "B456";
        fraudulentOrderIDs[2] = "C789";

        //Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
        //Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
        //Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");    
        //Console.WriteLine($"There are: {fraudulentOrderIDs.Length} fraudulent orders to process.");       

        string[] names = new string[] { "Bob", "Conrad", "Grant" };             
        foreach (string name in names)
        {

            //Console.WriteLine(name);
        }

        int[] inventory = new int[5] {100, 2000, 300, 400, 500};
        int[] inventory1 = new int[] {100, 2000, 300, 400, 500};
        int[] inventory2 = {100, 2000, 300, 400, 500};

        int sum = 0;
        foreach (var item in inventory)
        {
            sum += item;
            //Console.WriteLine(item);
        }
        //Console.WriteLine($"We have {sum} items in inventory.");

        sum = 0;
        foreach (var item in inventory1)
        {
            sum += item;
           // Console.WriteLine(item);
        }
        //Console.WriteLine($"We have {sum} items in inventory.");

        sum = 0;
        //int bin = 0;
        foreach (var item in inventory2)
        {
            sum += item;
            //Console.WriteLine($"Bin {bin++} = {item} itens (total: {sum})");
            //Console.WriteLine(item);
        }

        //Console.WriteLine($"We have {sum} items in inventory.");

        string[] dadosFraudulentos = new string[8] {"B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179"};

        foreach (var item in dadosFraudulentos)
        {
            if (item.StartsWith("B"))
            {
                //Console.WriteLine(item);
            }
        }

//Student         Grade

//Sophia          92.2    ?
//Andrew          89.6    ?
//Emma            85.6    ?
//Logan           91.2    ?
//Press the Enter key to continue

        int numerosExames = 5;
        decimal somaScore =0 ;

        string[] studentNames = new string[4] {"Sophia", "Andrew", "Emma", "Logan"};
        int[] sophiaScoresExame = new int[] { 90, 86, 87, 98, 100, 94, 90 };
        int[] andrewScoresExame = new int[] { 92, 89, 81, 96, 90, 89 };
        int[] emmaScoresExame = new int[] { 90, 85, 87, 98, 68, 89, 89, 89 };
        int[] loganScoresExame = new int[] { 90, 95, 87, 88, 96, 96 };

        int numerosExames1 = sophiaScoresExame.Length;
        int numerosExames2 = andrewScoresExame.Length;
        int numerosExames3 = emmaScoresExame.Length;
        int numerosExames4 = loganScoresExame.Length;

        decimal [] sophiaScores = new decimal[numerosExames];
        decimal [] andrewScores = new decimal[numerosExames];
        decimal [] emmaScores = new decimal[numerosExames];
        decimal [] loganScores = new decimal[numerosExames];

        int [] sophiaScores2 = new int[numerosExames];
        int [] andrewScores2 = new int[numerosExames];
        int [] emmaScores2 = new int[numerosExames];
        int [] loganScores2 = new int[numerosExames];

        decimal[] listScoresSum = new decimal[4];
        
        //decimal[] listScoresSumOnlyExame = new decimal[4];


        for (int i = 0; i < numerosExames; i++)
       {
            sophiaScores[i] = sophiaScoresExame[i];
            sophiaScores2[i] = sophiaScoresExame[i];
            andrewScores[i] = andrewScoresExame[i];
            andrewScores2[i] = andrewScoresExame[i];    
            emmaScores[i] = emmaScoresExame[i];
            emmaScores2[i] = emmaScoresExame[i];
            loganScores[i] = loganScoresExame[i];
            loganScores2[i] = loganScoresExame[i];        
        }

        decimal[] scoreSumOnlyExame = new decimal[4] {sophiaScores.Sum()/5, andrewScores.Sum()/5, emmaScores.Sum()/5, loganScores.Sum()/5};
        int[] scoreSumOnlyExame2 = new int[4] {sophiaScores2.Sum()/5, andrewScores2.Sum()/5, emmaScores2.Sum()/5, loganScores2.Sum()/5};



        if(sophiaScoresExame.Length == numerosExames)
        {
            decimal sumSophiaScores = (decimal) sophiaScoresExame.Sum()/numerosExames;
            listScoresSum[0] = sumSophiaScores;
        }
        else
        {
            decimal[] newSophiaScores = new decimal[(sophiaScoresExame.Length - numerosExames)];
            somaScore = 0;
            for (int i = 5; i < sophiaScoresExame.Length; i++)
            {
                newSophiaScores[i-5] = sophiaScoresExame[i];
                somaScore += newSophiaScores[i-5];
            }
            decimal somaScore1 = newSophiaScores.Sum();
            decimal sumSophiaScores = (sophiaScores.Sum()+somaScore1/10)/numerosExames;
            listScoresSum[0] = sumSophiaScores;
        }
        if (andrewScoresExame.Length == numerosExames)
        {
            decimal sumAndrewScores = (decimal) andrewScoresExame.Sum()/numerosExames;
            listScoresSum[1] = sumAndrewScores; 
        }
        else
        {
            decimal[] newAndrewScores = new decimal[(andrewScoresExame.Length - numerosExames)];
            somaScore = 0;
            for (int i = 5; i < andrewScoresExame.Length; i++)
            {
                newAndrewScores[i-5] = andrewScoresExame[i];
                somaScore += newAndrewScores[i-5];
            }
            decimal somaScore2 = newAndrewScores.Sum();
            decimal sumAndrewScores = (andrewScores.Sum()+somaScore2/10)/numerosExames;
            listScoresSum[1] = sumAndrewScores;

        }
        if (emmaScoresExame.Length == numerosExames)
        {
            var sumEmmaScores = (decimal) emmaScoresExame.Sum()/numerosExames;
            listScoresSum[2] = sumEmmaScores;
        }
        else
        {
            decimal[] newEmmaScores = new decimal[(emmaScoresExame.Length - numerosExames)];
            somaScore = 0;
            for (int i = 5; i < emmaScoresExame.Length; i++)
            {
                newEmmaScores[i-5] = emmaScoresExame[i];
                somaScore += newEmmaScores[i-5];
            }
            decimal somaScore3 = newEmmaScores.Sum();
            decimal sumEmmaScores = (emmaScores.Sum()+somaScore3/10)/numerosExames;
            listScoresSum[2] = sumEmmaScores;
        }
        if (loganScoresExame.Length == numerosExames)
        {
            var sumLoganScores = (decimal) loganScoresExame.Sum()/loganScores.Length;
            listScoresSum[3] = sumLoganScores;
        }
        else
        {
            decimal[] newLoganScores = new decimal[(loganScoresExame.Length - numerosExames)];
            somaScore = 0;
            for (int i = 5; i < loganScoresExame.Length; i++)
            {
                newLoganScores[i-5] = loganScoresExame[i];
                somaScore += newLoganScores[i-5];
                //Console.WriteLine(" newLoganScores[i]:" + newLoganScores[i-5]);
                //Console.WriteLine(" somaScore:" + somaScore);   
            }
            decimal somaScore3 = newLoganScores.Sum();
            decimal sumLoganScores = (loganScores.Sum()+somaScore3/10)/numerosExames;
            listScoresSum[3] = sumLoganScores;
            //Console.WriteLine(" somaScore3:" + somaScore3); 
        }
//        Student         Exam Score      Overall Grade   Extra Credit

//        Sophia          92.2            95.88   A       92 (3.68 pts)
//        Andrew          89.6            91.38   A-      89 (1.78 pts)
//        Emma            85.6            90.94   A-      89 (5.34 pts)
//        Logan           91.2            93.12   A       96 (1.92 pts)

       //decimal[] listScoresSum = new decimal[4] {sumSophiaScores, sumAndrewScores, sumEmmaScores, sumLoganScores};

        Console.WriteLine("Student\t\tExam Score\tOverall\t\tGrade\t\tExtra Credit\n");

        string currentStudentLetterGrade;
        int contador = 0;
        foreach (string nome in studentNames)
        {
        if      (listScoresSum[contador] >= 97)
                currentStudentLetterGrade = "A+";
        else if (listScoresSum[contador] >= 93)
                currentStudentLetterGrade = "A";
        else if (listScoresSum[contador] >= 90)
                currentStudentLetterGrade = "A-";
        else if (listScoresSum[contador] >= 87)
                currentStudentLetterGrade = "B+";
        else if (listScoresSum[contador] >= 83)
                currentStudentLetterGrade = "B";
        else if (listScoresSum[contador] >= 80)
                currentStudentLetterGrade = "B-";
        else if (listScoresSum[contador] >= 77)
                currentStudentLetterGrade = "C+";
        else if (listScoresSum[contador] >= 73)
                currentStudentLetterGrade = "C";
        else if (listScoresSum[contador] >= 70)
                currentStudentLetterGrade = "C-";
        else if (listScoresSum[contador] >= 67)
                currentStudentLetterGrade = "D+";
        else if (listScoresSum[contador] >= 63)
                currentStudentLetterGrade = "D";
        else if (listScoresSum[contador] >= 60)
                currentStudentLetterGrade = "D-";
        else
                currentStudentLetterGrade = "F";  
   
        Console.WriteLine($"{nome}\t\t{scoreSumOnlyExame[contador]}\t\t{listScoresSum[contador]}\t\t{currentStudentLetterGrade}\t\t{scoreSumOnlyExame2[contador]}({listScoresSum[contador]-scoreSumOnlyExame[contador]})");
            contador++;
        }
        //Console.WriteLine("Press the Enter key to continue");

        //Console.WriteLine("a" == "a");
        //Console.WriteLine("a" == "A");
       //Console.WriteLine(1 == 2);

        //string myValue = "a";
        //Console.WriteLine(myValue == "a");

        string value1 = " a";
        string value2 = "A ";
        Console.WriteLine(value1.Trim().ToLower() == value2.Trim().ToLower());

        int saleAmount = 1001;
        int discount = saleAmount > 1000 ? 100 : 50;
        Console.WriteLine($"Discount: {discount}");

        //Random coin = new();
        Random coin = new Random();
        int flip = coin.Next(0, 2);
        Console.WriteLine(flip == 0 ? "heads" : "tails");

        Random coin1 = new();
        Console.WriteLine(coin1.Next(0, 2) == 0 ? "heads" : "tails");

        string permission = "Admin|Manager";
        int level = 55;
        // Admin && level > 55 // Welcome, Super Admin user.
        // Adm || level > 55 // Welcome, Admin user.
        // Manager && level >= 20 // Contact an Admin for access.
        // else // You do not have sufficient privileges.

        if (permission.Contains("Admin") && level > 55)
        {
            Console.WriteLine("Welcome, Super Admin user.");
        }
        else if (permission.Contains("Admin") || level > 55)
        {
            Console.WriteLine("Welcome, Admin user.");
        }
        else if (permission.Contains("Manager") && level >= 20)
        {
            Console.WriteLine("Contact an Admin for access.");
        }
        else
        {
            Console.WriteLine("You do not have sufficient privileges.");
        }

        //bool flag = true;
        int value = 5;
        if (value > 0)
        {
            int value20 = 6;
            value += value20;
           // Console.WriteLine($"Inside of code block: {value}");
        }
        Console.WriteLine($"Outside of code block: {value}");



        int[] numbers = { 4, 8, 15, 16, 23, 42 };

        int total = 0;
        bool found = false;

        foreach (int number in numbers)
        {
            // int total;

            total += number;

            if (number == 42)
            {
            found = true;

            }

        }

        if (found) 
        {
            Console.WriteLine("Set contains 42");

        }

        Console.WriteLine($"Total: {total}");

        // swith case 'emplyeeName'


        string employeeName = "John Smith";
        int employeeLevel = 201;

        string title = employeeLevel switch
        {
            100 => "Junior Associate",
            200 => "Senior Associate",
            300 => "Manager",
            400 => "Senior Manager",
            _ => "Associate"
        };
        Console.WriteLine($"{employeeName} ({title})"); 

        //string employeeName1 = "John Smith";
        employeeLevel = 201;

        string title1 = "0";

        switch (employeeLevel)
        {
            //case 100:
                //title1 = "Junior Associate";
                //break;
            case 100:
            case 200:
                title1 = "Senior Associate";
                break;
            case 300:
                title1 = "Manager";
                break;
            case 400:
                title1 = "Senior Manager";
                break;
            default:
                title1 = "Associate";
                break;
        }
        Console.WriteLine($"{employeeName} ({title1})");

        // SKU = Stock Keeping Unit. 
        // SKU value format: <product #>-<2-letter color code>-<size code>
        string sku = "01-MN-L";

        string[] product = sku.Split('-');
        Console.WriteLine($"Product type: {product[0]}"); 
        Console.WriteLine($"Color code: {product[1]}");
        Console.WriteLine($"Size: {product[2]}");  

        //string type = "";
        //string color = "";
        // string size = "";

        //if (product[0] == "01")
        //{
        //    type = "Sweat shirt";
        //} else if (product[0] == "02")
        //{
        //    type = "T-Shirt";
        //} else if (product[0] == "03")
        //{
        //    type = "Sweat pants";
        //}
        //else
        //{
        //    type = "Other";
        //}

        string type = product[0] switch
        {
            "01" => "Sweat shirt",
            "02" => "T-Shirt",
            "03" => "Sweat pants",
            _ => "Other"
        };

        //if (product[1] == "BL")
        //{
        //    color = "Black";
        //} else if (product[1] == "MN")
        //{
        //    color = "Maroon";
        //} else
        //{
        //    color = "White";
        //}

        string color = product[1] switch
        {
            "BL" => "Black",
            "MN" => "Maroon",
            _ => "White"
        };

        //if (product[2] == "S")
        //{
        //    size = "Small";
        //} else if (product[2] == "M")
        //{
        //    size = "Medium";
        //} else if (product[2] == "L")
        //{
        //    size = "Large";
        //} else
        //{
        //    size = "One Size Fits All";
        //}

        string size = product[2] switch
        {
            "S" => "Small",
            "M" => "Medium",
            "L" => "Large",
            _ => "One Size Fits All"
        };

        Console.WriteLine($"Product: {size} {color} {type}");


        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(i);
        }

        for (int i = 10; i >= 0; i--)
        {
            Console.WriteLine(i);
        }

        for (int i = 0; i < 10; i += 3)
        {
            Console.WriteLine(i);
        }

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(i);
            if (i == 7) break;
        }

        string[] names11 = { "Alex", "Eddie", "David", "Michael" };
        for (int i = names11.Length - 1; i >= 0; i--)
        {
            Console.WriteLine(names11[i]);
        }

        string[] names12 = { "Alex", "Eddie", "David", "Michael" };
        for (int i = 0; i < names12.Length; i++)
            if (names12[i] == "David") names12[i] = "Sammy";

        foreach (var name in names12) Console.WriteLine(name);

        // desafio fizzbuzz

        for (int counter = 0; counter < 100; counter++)
        {
            if (counter % 3 == 0 && counter % 5 == 0)
            {
                Console.WriteLine($"{counter} - FizzBuzz");
            }
            else if (counter % 3 == 0)
            {
                Console.WriteLine($"{counter} - Fizz");
            }
            else if (counter % 5 == 0)
            {
                Console.WriteLine($"{counter} - Buzz");
            }
            else
            {
                Console.WriteLine(counter);
            }
        }

        for (int counter = 0; counter < 100; counter++)
        {
            string output1 = "";
            if (counter % 3 == 0) output1 += "Fizz";
            if (counter % 5 == 0) output1 += "Buzz";
            if (output1 == "") Console.WriteLine(counter.ToString());
            Console.WriteLine($"{counter} - {output1}");
        }

        string size1 = product[2] switch
        {
            "S" => "Small",
            "M" => "Medium",
            "L" => "Large",
            _ => "One Size Fits All"
        };

        Console.WriteLine($"Product: {size1} {color} {type}");


    Random random1 = new Random();
    int dadoA;
    int contador1 = 0;
    do{
        dadoA = random1.Next(1, 11);
        contador1++;
        Console.WriteLine($"{dadoA} {contador1}");
        if (dadoA >= 7) continue;
        contador1++;
        Console.WriteLine($"{dadoA} {contador1}");
    } while (dadoA != 6);

    int monstro = 10;
    int heroi = 10;
    int ataquePonto;
    bool controle = true;   

    do{
      Random ataque = new();
      if(heroi > 0 && controle == true)
      {
        ataquePonto = ataque.Next(1, 11);
        monstro -= ataquePonto;
        controle = false;
        Console.WriteLine($"Heroi: {heroi} Pontos: {ataquePonto} Monstro: {monstro}");
      }
      else if (monstro > 0 && controle == false)
      {
        ataquePonto = ataque.Next(1, 11);
        heroi -= ataquePonto;
        Console.WriteLine($"Heroi: {heroi} Pontos: {ataquePonto} Monstro: {monstro}");
        controle = true;
      }  
    } while (monstro > 0 && heroi > 0);
    if(monstro <= 0)
    {
      Console.WriteLine("Heroi venceu");
    }
    else
    {
      Console.WriteLine("Monstro venceu");
    }
    Console.WriteLine(monstro>0?"Monstro venceu":"Heroi venceu");

    string? readResult;
    Console.WriteLine("Enter a string:");
    do
    {
        readResult = Console.ReadLine();
    } while (readResult == null);


    string? readResult1;
    bool isValidString = false;
    Console.WriteLine("Enter a string containing at least three characters:");

    do{
        readResult1 = Console.ReadLine();
        if (readResult1.Length >= 3)
        {
            isValidString = true;
            Console.WriteLine($"You entered: {readResult1}");
        } else
        {
            Console.WriteLine("You must enter at least three characters. Try again.");
        }
    } while (isValidString == false);

    int readResult2;
    int numericValue;
    bool isValidNumber = false;
    Console.WriteLine("Enter a int number:");

    do{
        readResult1 = Console.ReadLine();
        isValidNumber = int.TryParse(readResult1, out readResult2);
        if (isValidNumber == true)
        {
            isValidNumber = true;
            Console.WriteLine($"You entered: {readResult2}");
        } else
        {
            Console.WriteLine("You must enter a int number. Try again.");
        }
    } while (isValidString == false);

    int validNumber;
    bool isValidNumber1 = false;
    Console.WriteLine("Enter a int number with range 5 and 10:");
    
    do{
        string readResultInt = Console.ReadLine();
        isValidNumber1 = int.TryParse(readResultInt, out validNumber);
        if (isValidNumber1 == true && validNumber >= 5 && validNumber <= 10)
        {
            isValidNumber1 = true;
            Console.WriteLine($"You entered: {validNumber}");
        } else
        {
            Console.WriteLine("You must enter a int number with range 5 and 10. Try again.");
        }
    } while (isValidNumber1 == false);

    string? readResult11;
    bool isValidString1 = false;
    Console.WriteLine("Digite a sua função (Admin, Manager, Employee):");

    do{
        readResult11 = Console.ReadLine().ToLower().Trim();

        if (readResult11 == "admin" || readResult11 == "manager" || readResult11 == "employee")
        {
            isValidString1 = true;
            Console.WriteLine($"You entered: {readResult11}");
        } else
        {
            Console.WriteLine("You must enter at least three characters. Try again.");
        }
    } while (isValidString1 == false); */

    string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
    int stringsCount = myStrings.Length;

    string myString = "";
    int periodLocation = 0;

    for (int i = 0; i < stringsCount; i++)
    {
        myString = myStrings[i];
        periodLocation = myString.IndexOf(".");
        Console.WriteLine($"periodLocation: {periodLocation}");


        string mySentence;

        // extract sentences from each string and display them one at a time
        while (periodLocation != -1)
        {

            // first sentence is the string value to the left of the period location
            //mySentence = myString.Substring(0, periodLocation + 1);
            mySentence = myString.Remove(periodLocation);
            Console.WriteLine($"mySentence: {mySentence}");

            // the remainder of myString is the string value to the right of the location
            myString = myString.Substring(periodLocation + 1);
            Console.WriteLine($"myString: {myString}");

            // remove any leading white-space from myString
            myString = myString.TrimStart();

            // update the comma location and increment the counter
            periodLocation = myString.IndexOf(".");

            Console.WriteLine(mySentence);
        }
    
        mySentence = myString.Trim();
        Console.WriteLine(mySentence);
    }


    }
}

