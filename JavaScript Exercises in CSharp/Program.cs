using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JavaScript_Exercises_in_CSharp
{
    class Program
    {
//        static void Main(string[] args)
//        {

//            string option;

//            Console.WriteLine("Main Menu");
//            Console.WriteLine("1.  Addition");
//            Console.WriteLine("2.  Subtraction");
//            Console.WriteLine("3.  Multiplication");
//            Console.WriteLine("4.  Division");
//            Console.WriteLine("5.  Factorial");
//            Console.WriteLine("6.  FizzBuzz");
//            Console.WriteLine("7.  Palindrome");
//            Console.WriteLine("8.  All Combinations of a String");
//            Console.WriteLine("9.  Letters from String in Alphabetical Order");
//            Console.WriteLine("10. First Letter Capitalization");
//            Console.WriteLine("11. First Non-Repeated Character");
//            Console.WriteLine("12. Generate Random String ID");
//            Console.WriteLine("13. The ??? between two numbers that add up to ten exercise");

//            Console.Write("Enter the Operation you want to perform : ");
//            option = Console.ReadLine(); //   DO I NEED TO ENTER CONDITION IN READLINE PARENTHESES??? TO CAPTURE MORE THAN ONE CHARACTER/NUMBER FOR DOUBLE DIGIT OPTIONS????
//            //object result6 = null;
//            switch (option)
//            {
//                case "1":
//                    int Num1, Num2, result1;
//                    Console.Write("Enter the first number : ");
//                    Num1 = Convert.ToInt32(Console.ReadLine());
//                    Console.Write("Enter the second number : ");
//                    Num2 = Convert.ToInt32(Console.ReadLine());
//                    result1 = Num1 + Num2;
//                    Console.WriteLine("The result of addition is : {0} ", result1);
//                    Console.ReadKey();
//                    break;

//                case "2":
//                    int Num3, Num4, result2;
//                    Console.Write("Enter the First Number : ");
//                    Num3 = Convert.ToInt32(Console.ReadLine());
//                    Console.Write("Enter the Second Number : ");
//                    Num4 = Convert.ToInt32(Console.ReadLine());
//                    result2 = Num3 - Num4;
//                    Console.WriteLine("The result of subtraction is : {0} ", result2);
//                    Console.ReadKey();
//                    break;

//                case "3":
//                    int Num5, Num6, result3;
//                    Console.Write("Enter the first number : ");
//                    Num5 = Convert.ToInt32(Console.ReadLine());
//                    Console.Write("Enter the second number : ");
//                    Num6 = Convert.ToInt32(Console.ReadLine());
//                    result3 = Num5 * Num6;
//                    Console.WriteLine("The result of multiplication is : {0} ", result3);
//                    Console.ReadKey();
//                    break;

//                case "4":
//                    int Num7, Num8, result4;
//                    Console.Write("Enter the first number : ");
//                    Num7 = Convert.ToInt32(Console.ReadLine());
//                    Console.Write("Enter the second number : ");
//                    Num8 = Convert.ToInt32(Console.ReadLine());
//                    result4 = Num7 / Num8;
//                    Console.WriteLine("The result of division is : {0} ", result4);
//                    Console.ReadKey();
//                    break;

//                case "5":
//                    int i, result5 = 1, Num9;
//                    Console.Write("Enter a number : ");
//                    Num9 = Convert.ToInt32(Console.ReadLine());

//                    for (i = Num9 - 1; i >= 1; i--)
//                    {
//                        result5 += result5 * i;
//                    }

//                    Console.WriteLine("The result of factorization is : {0} ", result5);
//                    Console.ReadKey();
//                    break;


//                case "6":

//                    int Num10, Num11;
//                    Console.Write("Enter the first number : ");
//                    Num10 = Convert.ToInt32(Console.ReadLine());
//                    Console.Write("Enter the second number : ");
//                    Num11 = Convert.ToInt32(Console.ReadLine());


//                    for (i = 1; i <= 100; i++)
//                    {                   // my error, for (int i = 1; DO NOT NEED "int" and thus produced this error Severity	Code	Description	Project	File	Line	Suppression State
//                        //Error CS0136  A local or parameter named 'i' cannot be declared in this scope because that name is used in an enclosing local scope to define a local or parameter    JavaScript Exercises in CSharp C:\Users\cgk30\source\repos\JavaScript Exercises in CSharp\JavaScript Exercises in CSharp\Program.cs    92  Active
//                        //REMOVED THE int from (int i =1; and error was resolved!!!!

//                        bool fizz = i % Num10 == 0;
//                        bool buzz = i % Num11 == 0;
//                        if (fizz && buzz)
//                            Console.WriteLine("FizzBuzz");
//                        else if (fizz)
//                            Console.WriteLine("Fizz");
//                        else if (buzz)
//                            Console.WriteLine("Buzz");
//                        else
//                            Console.WriteLine(i);
//                    }
//                    Console.ReadKey();
//                    break;

//                case "7":
//                    string s, revs = "";
//                    Console.Write(" Enter string:  ");
//                    s = Console.ReadLine();

//                    s = System.Text.RegularExpressions.Regex.Replace(s, @"\s", "").ToLower(); //add lowercase conversion!!!!!!!!!!

//                    for (i = s.Length - 1; i >= 0; i--) //String Reverse
//                    {                               //NOTE IN THE STATEMENT ABOVE PREVIOUSLY HAD same int error in front of i = s.Length - 1;
//                        revs += s[i].ToString();
//                    }
//                    if (revs == s) // Checking whether string is palindrome or not
//                    {
//                        Console.WriteLine("String is a palindrome \n Entered string was {0} and reverse string is {1}", s, revs);
//                    }
//                    else
//                    {
//                        Console.WriteLine("String is not palindrome \n Entered string was {0} and reverse string is {1}", s, revs);
//                    }
//                    Console.ReadKey();
//                    break;

//                case "8":

//                    string s2S;
                    
//                    Console.Write(" Enter string");
//                    s2S = Console.ReadLine();

//                    List<string> result = new List<string>();
//                    int total = (int)Math.Pow(2, s2S.Length);

//                    for (i = 0; i < total; i++)   //again put int before i = 0, need to stop doing that!!!
//                    {
//                        string tempWord = string.Empty;
//                        // pick the letters from the word

//                        for (int temp = i, j = 0; temp > 0; temp = temp >> 1, j++)
//                        {
//                            if ((temp & 1) == 1)
//                            {
//                                tempWord += s2S[j];
//                            }
//                        }

//                        ////// generate permutations from the letters
//                        ////List<string> permutations;

//                        ////Recursion rec = new Recursion();
//                        ////rec.InputSet = rec.MakeCharArray(inputLine);
//                        ////rec.CalcPermutation(0);

//                        ////Permutations(tempWord, out permutations); //crap add permutation code

//                        ////foreach (var prm in permutations)
//                        ////    result.Add(prm);
                    
            

//        }
//        Console.ReadKey();
//                    break;

//                case "9":
//                    string case9string;
//        Console.Write(" Enter string:  ");
//                    case9string = Console.ReadLine();

//                    {
//                        char[] c = case9string.ToCharArray();
//        Array.Sort(c);
//                        Console.WriteLine(new String(c));
//                    }
//    Console.ReadKey();
//                    break;

//                //case "10":
//                //    string case10string;
//                //    Console.Write(" Enter string");
//                //    case10string = Console.ReadLine();
//                //    case10string = case10string.Split(" ");
//                //     {

//                //        if (string.IsNullOrEmpty(case10string)) // Check for empty string.
//                //        {
//                //            Console.WriteLine("Empty string");
//                //        }
//                //        else (var i = 0, x = case10string.length; i < x; i++)
//                //        {
//                //            case10string[i] = case10string[i][0].toUpperCase() + case10string[i].substr(1);

//                //            Console.WriteLine(char.ToUpper(case10string[0]) + case10string.Substring(1));// Return char and concat substring.


//                //        }


//                //}
//                //Console.ReadKey();
//                //break;

//                //case "11":
//                //    string case11string;
//                //    Console.Write(" Enter string");
//                //    case11string = Console.ReadLine();
//                //    case11string = case11string.Split(" ");
//                //    {
//                //    }
//                //    Console.ReadKey();
//                //    break;





//                //function strNotRepeat()
//                //{
//                //    var str = document.getElementById('string30').value;

//                //    var arra1 = str.split('');
//                //    var result = '';
//                //    var ctr = 0;

//                //    for (var x = 0; x < arra1.length; x++)
//                //    {
//                //        ctr = 0;

//                //        for (var y = 0; y < arra1.length; y++)
//                //        {
//                //            if (arra1[x] === arra1[y])
//                //            {
//                //                ctr += 1;
//                //            }
//                //        }

//                //        if (ctr < 2)
//                //        {
//                //            result = arra1[x];
//                //            break;
//                //        }
//                //    }
//                //    //return result;
//                //    document.getElementById("resultNotRepeat").innerHTML = result;




//                //case "12":
//                //    int Num12, resultId;
//                //    Console.Write("Enter ID length as number: ");
//                //    Num12 = Convert.ToInt32(Console.ReadLine());
//                //    resultId = Num7 / Num8;


//                //    Console.WriteLine("The random ID is : {0}", resultId);
//                //    break;


//                //function strRanId()
//                //{
//                //    var l = document.getElementById('stringId').value;

//                //    var text = "";
//                //    var char_list = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
//                //    for (var i = 0; i < l; i++)
//                //    {
//                //        text += char_list.charAt(Math.floor(Math.random() * char_list.length));


//                //        //The String object's charAt() method returns a new string consisting of the single UTF-16 code unit located at the specified offset into the string.
//                //        /*A number representing the largest integer less than or equal to the specified number.*/
//                //        //The Math.random() function returns a floating- point, pseudo - random number in the range from 0 inclusive up to but not including 1 — which you can then scale to your desired range.The implementation selects the initial seed to the random number generation algorithm; it cannot be chosen or reset by the user.

//                //    }

//                //    document.getElementById('resultRanId').innerHTML = text;

//                //}

//                //case "13":
//                //        //three question marks exercise between two numbers that add up to ten.

//                //    string question;
//                //    Console.Write("Enter a string with ? marks between two numbers : ");
//                //    question = (Console.ReadLine());

//                //    {
//                //        char[] c = question.ToCharArray();
//                //        char.IsDigit;

//                //        Console.WriteLine(new String(c));

//                //    }
//                //    Console.ReadKey();
//                //    break;

//                default:
//                    Console.WriteLine("Invalid Option");
//                    break;


//            }


//Console.ReadKey();

//        }






    }

}




