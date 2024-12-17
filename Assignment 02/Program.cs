namespace Assignment_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //Console.WriteLine("Enter a number");
            //if (int.TryParse(Console.ReadLine(), out int Number))
            //{
            //    if (Number % 3 == 0 && Number % 4 == 0)
            //    {
            //        Console.WriteLine("Yes");
            //    }
            //    else
            //    {
            //        Console.WriteLine("No");
            //    }
            //}
            //else 
            //{
            //    Console.WriteLine("Invalid input");
            //}

            #endregion

            #region Q2
            //Console.WriteLine("Enter a number");
            //if (int.TryParse(Console.ReadLine(), out int Number))
            //{
            //    if (Number < 0)
            //    {
            //        Console.WriteLine("Negative");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Positive");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input");
            //}

            #endregion

            #region Q3

            //int[] Numbers = new int[3];
            //Console.WriteLine("Enter three numbers");

            //for (int i = 0; i < Numbers.Length; i++)
            //{
            //    Console.Write($"Enter number {i + 1}: ");
            //    Numbers[i] = int.Parse(Console.ReadLine());
            //}

            //int Max = Numbers[0];
            //int Min = Numbers[0];

            //for (int i = 1; i < Numbers.Length; i++)
            //{
            //    if (Numbers[i] > Max)
            //    {
            //        Max = Numbers[i];
            //    }
            //    if (Numbers[i] < Min)
            //    {
            //        Min = Numbers[i];
            //    }
            //}
            //Console.WriteLine($"Max : {Max} Min : {Min}");

            #endregion

            #region Q4
            //Console.WriteLine("Enter a number");
            //if (int.TryParse(Console.ReadLine(), out int Number))
            //{
            //    if (Number % 2 == 0 )
            //    {
            //        Console.WriteLine($"{Number} is Even");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{Number} is odd");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input");
            //}

            #endregion

            #region Q5
            //Console.WriteLine("Enter an alphabet");
            //char input= Convert.ToChar(Console.ReadLine().ToLower());

            //if (input == 'a' || input == 'e' || input == 'i' || input == 'o' || input == 'u')
            //{
            //    Console.WriteLine("Vowel");
            //}
            //else if (char.IsLetter(input))
            //{
            //    Console.WriteLine("Consonant");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input. Please enter an alphabet character.");
            //}

            #endregion

            #region Q6
            //Console.WriteLine("Enter a number");

            //if (int.TryParse(Console.ReadLine(), out int NUMBER))
            //{
            //    Console.WriteLine($"From 1 to {NUMBER} : ");
            //    for (int i = 1; i <= NUMBER; i++)
            //    {
            //        Console.WriteLine(i);
            //    }

            //}
            //else
            //{
            //    Console.WriteLine("Invalid input");
            //}

            #endregion

            #region Q7
            //Console.WriteLine("Enter a number");

            //if (int.TryParse(Console.ReadLine(), out int NUMBER))
            //{
            //    Console.WriteLine("------------");
            //    for (int i = 1; i <= 12; i++)
            //    {
            //        Console.WriteLine($"{NUMBER} * {i} = {NUMBER * i}");
            //    }

            //}
            //else
            //{
            //    Console.WriteLine("Invalid input");
            //}

            #endregion

            #region Q8
            //Console.WriteLine("Enter a number:");
            //if (int.TryParse(Console.ReadLine(), out int Number))
            //{
            //    Console.WriteLine($"Even numbers between 1 and {Number}:");


            //    for (int i = 1; i <= Number; i++)
            //    {

            //        if (i % 2 == 0)
            //        {
            //            Console.WriteLine(i);
            //        }
            //    }
            //}
            //else
            //{

            //    Console.WriteLine("Invalid input. Please enter a valid integer.");
            //}

            #endregion

            #region Q9
            //Console.WriteLine("Enter the base number:");
            //if (int.TryParse(Console.ReadLine(), out int Number))
            //{
            //    Console.WriteLine("Enter the exponent:");
            //    if (int.TryParse(Console.ReadLine(), out int Power))
            //    {
            //        if (Power == 0)
            //        {
            //            Console.WriteLine($"{Number} to the power of {Power} is 1");
            //        }
            //        else
            //        {
            //            int Result = 1;
            //            for (int i = 0; i < Power; i++)
            //            {
            //                Result *= Number; 
            //            }
            //            Console.WriteLine($"{Number} to the power of {Power} is {Result}");
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("Enter a valid number for the power.");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Enter a valid number for the base.");
            //}
            #endregion

            #region Q10

            //int[] Grades = new int[5];
            //int TotalMarks = 0, Average;
            //double Percentage; 
            //const int MaxMarks = 100;

            //Console.WriteLine("Enter 5 grades:");

            //for (int i = 0; i < 5; i++)
            //{
            //    Console.Write($"Enter grade {i + 1}: ");
            //    if (int.TryParse(Console.ReadLine(), out int grade) && grade >= 0 && grade <= MaxMarks)
            //    {
            //        Grades[i] = grade;
            //    }
            //    else
            //    {
            //        Console.WriteLine(" Please enter a valid grade between 0 and 100.");

            //    }
            //}

            //for (int i = 0; i < 5; i++)
            //{
            //    TotalMarks += Grades[i];
            //}

            //Average = TotalMarks / 5;

            //Percentage = ((double)TotalMarks / (5 * MaxMarks)) * 100;


            //Console.WriteLine($"Total Marks: {TotalMarks}");
            //Console.WriteLine($"Average: {Average}");
            //Console.WriteLine($"Percentage: {Percentage}%");

            #endregion

            #region Q11
            //Console.WriteLine("Enter number of month");

            //if (int.TryParse(Console.ReadLine(), out int Number))
            //{
            //    if (Number >= 1 && Number <= 12)
            //    {
            //        if (Number == 1 || Number == 3 || Number == 5 || Number == 7 || Number == 8 || Number == 10 || Number == 12)
            //        {
            //            Console.WriteLine("31 Days");
            //        }
            //        else if (Number == 4 || Number == 6 || Number == 9 || Number == 11)
            //        {
            //            Console.WriteLine("30 Days");
            //        }
            //        else
            //        { 
            //            Console.WriteLine("28 or 29 Days");
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("Enter a number from 1 to 12");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Enter a valid number from 1 to 12");
            //}

            #endregion

            #region Q12
            //Console.WriteLine("Enter the first number:");
            //double num1 = double.Parse(Console.ReadLine());

            //Console.WriteLine("Enter the second number:");
            //double num2 = double.Parse(Console.ReadLine());

            //Console.WriteLine("Enter the operation (+, -, *, /):");
            //string operation = Console.ReadLine();

            //double result = 0;

            //switch (operation)
            //{
            //    case "+":
            //        result = num1 + num2;
            //        Console.WriteLine($"The result of {num1} + {num2} is: {result}");
            //        break;

            //    case "-":
            //        result = num1 - num2;
            //        Console.WriteLine($"The result of {num1} - {num2} is: {result}");
            //        break;

            //    case "*":
            //        result = num1 * num2;
            //        Console.WriteLine($"The result of {num1} * {num2} is: {result}");
            //        break;

            //    case "/":
            //        if (num2 != 0)
            //        {
            //            result = num1 / num2;
            //            Console.WriteLine($"The result of {num1} / {num2} is: {result}");
            //        }
            //        else
            //        {
            //            Console.WriteLine("Error: Cannot divide by zero.");
            //        }
            //        break;

            //    default:
            //        Console.WriteLine("Invalid operation. Please enter +, -, *, or /.");
            //        break;
            //}
            #endregion

            #region Q13
            //string word;
            //Console.WriteLine("Enter A string");
            //word = Console.ReadLine();

            //for(int i = word.Length-1 ; i>=0 ; i--)
            //{
            //    Console.Write(word[i]); 
            //}
            #endregion

            #region Q14
            //Console.WriteLine("Enter an integer:");
            //if (int.TryParse(Console.ReadLine(), out int Number))
            //{
            //    string reversedString = new string(Number.ToString().Reverse().ToArray());
            //    Console.WriteLine($"The reverse of {Number} number is: {reversedString}");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input. Please enter a valid integer.");
            //}
            #endregion

            #region Q15
            //Console.WriteLine("Enter the start for the range:");
            //int start = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter the end for the range:");
            //int end = int.Parse(Console.ReadLine());

            //Console.WriteLine($"The prime numbers between {start} and {end} are:");
            //Console.WriteLine("--------------");

            //for (int number = start; number <= end; number++)
            //{
            //    int divisorCount = 0;  


            //    for (int i = 1; i <= number; i++)
            //    {
            //        if (number % i == 0)  
            //        {
            //            divisorCount++;
            //        }
            //    }


            //    if (divisorCount == 2)
            //    {
            //        Console.Write(number + " ");
            //    }
            //}
            //Console.WriteLine("--------------");


            #endregion

            #region Q16
            //int Number;
            //bool flag;

            //string Result = " ";
            //do
            //{
            //    Console.WriteLine("Enter Number");
            //    flag = int.TryParse(Console.ReadLine(), out Number);

            //} while (!flag);

            //for (int i = 0; Number > 0; i++)
            //{                 
            //    Result = (Number % 2) + Result; 
            //    Number /= 2;

            //}
            //Console.WriteLine(Result);
            #endregion

            #region Q17
            //Console.WriteLine("Enter coordinates for the first point (x1, y1):");
            //if (double.TryParse(Console.ReadLine(), out double x1) && double.TryParse(Console.ReadLine(), out double y1))
            //{
            //    Console.WriteLine("Enter coordinates for the second point (x2, y2):");
            //    if (double.TryParse(Console.ReadLine(), out double x2) && double.TryParse(Console.ReadLine(), out double y2))
            //    {
            //        Console.WriteLine("Enter coordinates for the third point (x3, y3):");
            //        if (double.TryParse(Console.ReadLine(), out double x3) && double.TryParse(Console.ReadLine(), out double y3))
            //        {
            //            if ((y2 - y1) * (x3 - x2) == (y3 - y2) * (x2 - x1))
            //            {
            //                Console.WriteLine("The points lie on a single straight line.");
            //            }
            //            else
            //            {
            //                Console.WriteLine("The points do not lie on a single straight line.");
            //            }
            //        }
            //        else
            //        {
            //            Console.WriteLine("Invalid input for the third point. Please enter valid numbers.");
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("Invalid input for the second point. Please enter valid numbers.");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input for the first point. Please enter valid numbers.");
            //}

            #endregion

            #region Q18
            //Console.WriteLine("Enter the time taken by the worker to complete the task (in hours):");

            //if (double.TryParse(Console.ReadLine(), out double timeTaken))
            //{
            //    if (timeTaken >= 2 && timeTaken <= 3)
            //    {
            //        Console.WriteLine("The worker is highly efficient.");
            //    }
            //    else if (timeTaken > 3 && timeTaken <= 4)
            //    {
            //        Console.WriteLine("The worker needs to increase their speed.");
            //    }
            //    else if (timeTaken > 4 && timeTaken <= 5)
            //    {
            //        Console.WriteLine("The worker requires training to enhance their speed.");
            //    }
            //    else if (timeTaken > 5)
            //    {
            //        Console.WriteLine("The worker is required to leave the company.");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Invalid time range. Please enter a value of 2 hours or more.");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input. Please enter a numeric value for the time.");
            //}
            #endregion
        }
    }
}
