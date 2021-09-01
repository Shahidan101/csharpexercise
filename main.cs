using System;

namespace csharpexercise
{
    class ExerciseMain
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Exercise Number to Run: ");
            string key = Console.ReadLine();

            Console.Clear();
            
            switch (key) {
                // Exercise 1

                // Question:
                // Write a C# Sharp program to print Hello and your name in a separate line.

                case "1":
                    Console.Write("Exercise ");
                    Console.Write(key);
                    Console.Write(" entered...\n\n");
                    
                    //Start coding here...
                    Console.WriteLine("Hello");
                    Console.WriteLine("Shahidan bin Idris");
                    break;
                
                // Exercise 2

                // Question:
                // Write a C# Sharp program to print the sum of two numbers.

                case "2":
                    Console.Write("Exercise ");
                    Console.Write(key);
                    Console.Write(" entered...\n\n");
                    
                    //Start coding here...
                    int num1 = 15;
                    int num2 = 13;
                    int additionAnswer;

                    additionAnswer = num1 + num2;
                    Console.WriteLine(additionAnswer);
                    break;

                // Exercise3

                // Question:
                // Write a C# Sharp program to print the result of dividing two numbers.

                case "3":
                    Console.Write("Exercise ");
                    Console.Write(key);
                    Console.Write(" entered...\n\n");
                    
                    //Start coding here...
                    float float1 = 3;
                    float float2 = 2;

                    float floatDivisionAnswer;

                    // **This one doesn't work. Cause it's implicitly converting to int
                    // int floatDivisionAnswer;
                    
                    floatDivisionAnswer = float1 / float2;

                    Console.Write("Float Division = ");
                    // **To control the decimal places, need to use a Math class (system)
                    Console.WriteLine(floatDivisionAnswer);

                    // **Both arguments AND results are float, output will be a float
                    break;
                
                // Exercise4

                // Question:
                // Write a C# Sharp program to print the result of the specified operations.

                // -1 + 4 * 6
                // ( 35+ 5 ) % 7
                // 14 + -4 * 6 / 11
                // 2 + 15 / 6 * 1 - 7 % 2

                case "4":
                    Console.Write("Exercise ");
                    Console.Write(key);
                    Console.Write(" entered...\n\n");
                    
                    //Start coding here...
                    Console.Write("-1 + 4 * 6 = ");
                    Console.WriteLine(-1 + 4 * 6);
                    Console.WriteLine("Correct Answer = 23");
                    Console.Write("( 35+ 5 ) % 7 = ");
                    Console.WriteLine((35 + 5) % 7);
                    Console.WriteLine("Correct Answer = 5");
                    
                    Console.Write("14 + -4 * 6 / 11 = ");
                    // **The command below produces an integer answer
                    Console.WriteLine(14 + -4 * 6 / 11);

                    // **Float alternative: Attempt 1
                    double answer = 14 + -4 * 6 / 11;
                    Console.Write("14 + -4 * 6 / 11 = ");
                    // **The command below STILL produces an integer answer
                    Console.WriteLine(answer);

                    // **Float alternative: Attempt 2
                    answer = 14 + -4 * 6 / 11.0;
                    // **By setting just one number with decimal, entire solution is in decimals
                    Console.Write("14 + -4 * 6 / 11 = ");
                    Console.WriteLine(answer);

                    Console.WriteLine("Correct Answer = 11.8181");
                    Console.Write("2 + 15 / 6 * 1 - 7 % 2 = ");
                    // **The command below produces an integer answer
                    Console.WriteLine(2 + 15 / 6 * 1 - 7 % 2);

                    // **Float alternative: Attempt 2
                    answer = 2 + 15.0 / 6 * 1 - 7 % 2;
                    // **By setting just one number with decimal, entire solution is in decimals
                    Console.Write("2 + 15 / 6 * 1 - 7 % 2 = ");
                    Console.WriteLine(answer);

                    Console.WriteLine("Correct Answer = 3.5");
                    break;

                // Exercise5

                // Question:
                // Write a C# Sharp program to swap two numbers.

                // Test Data:
                // Input the First Number : 5
                // Input the Second Number : 6
                // Expected Output:
                // After Swapping :
                // First Number : 6
                // Second Number : 5

                case "5":
                    Console.Write("Exercise ");
                    Console.Write(key);
                    Console.Write(" entered...\n\n");
                    
                    //Start coding here...
                    int firstNum;
                    int secondNum;
                    int container;

                    Console.Write("Input The First Number : ");
                    firstNum = int.Parse(Console.ReadLine());
                    Console.Write("Input The Second Number : ");
                    secondNum = int.Parse(Console.ReadLine());

                    container = firstNum;
                    firstNum = secondNum;
                    secondNum = container;

                    Console.WriteLine("After Swapping :");
                    Console.Write("First Number : ");
                    Console.WriteLine(firstNum);
                    Console.Write("Second Number : ");
                    Console.WriteLine(secondNum);
                    break;
                
                // Exercise6

                // Question:
                // Write a C# Sharp program to print on screen the output of adding, 
                // subtracting, multiplying and dividing of two numbers which will be entered by the user.

                // Test Data:
                // Input the first number: 25
                // Input the second number: 4
                // Expected Output:
                // 25 + 4 = 29
                // 25 - 4 = 21
                // 25 x 4 = 100
                // 25 / 4 = 6
                // 25 mod 4 = 1

                case "6":
                    Console.Write("Exercise ");
                    Console.Write(key);
                    Console.Write(" entered...\n\n");
                    
                    //Start coding here...
                    int integerAnswer;

                    Console.Write("Input the first number : ");
                    firstNum = int.Parse(Console.ReadLine());
                    Console.Write("Input the second number : ");
                    secondNum = int.Parse(Console.ReadLine());

                    Console.WriteLine("\nOutput : ");
                    integerAnswer = firstNum + secondNum;
                    Console.WriteLine(firstNum.ToString() + " + " + secondNum.ToString() + " = " + integerAnswer.ToString());
                    integerAnswer = firstNum - secondNum;
                    Console.WriteLine(firstNum.ToString() + " - " + secondNum.ToString() + " = " + integerAnswer.ToString());
                    integerAnswer = firstNum * secondNum;
                    Console.WriteLine(firstNum.ToString() + " x " + secondNum.ToString() + " = " + integerAnswer.ToString());
                    integerAnswer = firstNum / secondNum;
                    Console.WriteLine(firstNum.ToString() + " / " + secondNum.ToString() + " = " + integerAnswer.ToString());
                    integerAnswer = firstNum % secondNum;
                    Console.WriteLine(firstNum.ToString() + " mod " + secondNum.ToString() + " = " + integerAnswer.ToString());
                    break;

                // Exercise8

                // Question:
                // Write a C# Sharp program that takes a number as input and print its multiplication table.

                case "7":
                    Console.Write("Exercise ");
                    Console.Write(key);
                    Console.Write(" entered...\n\n");
                    
                    //Start coding here...
                    int num;
                    int i;

                    Console.Write("Enter the number: ");
                    num = int.Parse(Console.ReadLine());

                    Console.WriteLine("\nOutput : ");
                    
                    for (i = 0; i < 13; i++) {
                        answer = num * i;
                        Console.WriteLine(num.ToString() + " * " + i.ToString() + " = " + answer.ToString());
                    }
                    break;
                
                // Exercise17

                // Question:
                // Write a C# program to create a new string from a given string (length 1 or more )
                // with the first character added at the front and back.

                case "17":
                    Console.Write("Exercise ");
                    Console.Write(key);
                    Console.Write(" entered...\n\n");
                    
                    //Start coding here...
                    Console.Write("Input a string : ");

                    string text;
                    char firstAlpha;
                    text = Console.ReadLine();
                    firstAlpha = text[0];
                    text = firstAlpha + text + firstAlpha;
                    Console.WriteLine(text);
                    break;
                
                // Exercise18

                // Question:
                // Write a C# program to check two given integers and return true 
                // if one is negative and one is positive.

                case "18":
                    Console.Write("Exercise ");
                    Console.Write(key);
                    Console.Write(" entered...\n\n");
                    
                    //Start coding here...
                    Console.WriteLine("Input first integer:");
                    firstNum = int.Parse(Console.ReadLine());
                    Console.WriteLine("Input second integer:");
                    secondNum = int.Parse(Console.ReadLine());
                    Console.WriteLine("Check if one is negative and one is positive:");

                    bool checkNegPos = ((firstNum < 0) && (secondNum > 0));
                    Console.WriteLine(checkNegPos);
                    break;

                // Exercise26

                // Question:
                // Write a C# program to compute the sum of the first 500 prime numbers.

                case "26":
                    Console.Write("Exercise ");
                    Console.Write(key);
                    Console.Write(" entered...\n\n");
                    
                    //Start coding here...
                    
                    break;
                
                // Exercise28

                // Question:
                // Write a C# program to reverse the words of a sentence.

                // Sample Output:
                // Original String: Display the pattern like pyramid using the alphabet.
                // Reverse String: alphabet. the using pyramid like pattern the Display

                case "28":
                    Console.Write("Exercise ");
                    Console.Write(key);
                    Console.Write(" entered...\n\n");
                    
                    //Start coding here...
                    
                    break;
            }
        }
    }
}