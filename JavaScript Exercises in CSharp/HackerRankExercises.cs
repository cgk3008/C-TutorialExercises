
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

namespace JavaScript_Exercises_in_CSharp
{
    class HackerRankExercises
    {


        class Solution
        {

            //// Complete the compareTriplets function below. STILL HAVE NOT COMPLETED!!!!
            // https://www.hackerrank.com/challenges/compare-the-triplets/problem?h_r=next-challenge&h_v=zen&h_r=next-challenge&h_v=zen
            //static List<int> compareTriplets(List<int> a, List<int> b)
            //{
            //    //int [] A = List<int> a;

            //    int scoreA = 0;
            //    int scoreB = 0;
            //    List<int> scoreArray = new List<int> { scoreA, scoreB };

            //    foreach (int numberA in a)
            //    {
            //        foreach (int numberB in b)
            //        {
            //            if (numberA > numberB)
            //            {
            //                scoreA += 1;
            //            }

            //            else if (numberA < numberB)
            //            {
            //                scoreB += 1;
            //            }

            //            //else (numberA == numberB);


            //        }
            //        //return new int[] { scoreA, scoreB };

            //    };
            //    return scoreArray;
            //}

            //static void Main(string[] args)
            //{
            //    TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            //    List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

            //    List<int> b = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(bTemp => Convert.ToInt32(bTemp)).ToList();

            //    List<int> result = compareTriplets(a, b);

            //    textWriter.WriteLine(String.Join(" ", result));

            //    textWriter.Flush();
            //    textWriter.Close();
            //}






            //factorial by recursive function

            //function findFactorial(value1)
            //{
            //    //var value1 = Number(document.getElementById("1Fact").value);
            //    {
            //        if (value1 === 0)
            //        {
            //            value1 = 1;

            //            return value1 * findFactorial(value1 - 1);
            //        }
            //        document.getElementById("resultF").innerHTML = value1;
            //    }


            ////closure in javascript
            //let obj = function () {
            //    let i = 0;

            //    return {
            //        setI(k) {
            //            i = k;
            //        },
            //        getI() {
            //            return i;
            //        }
            //    }
            //};

            //let x = obj();
            //x.setI(2);
            //x.setI(4);
            //console.log(x.getI());





            //was it a car or a cat i saw

            //https://medium.freecodecamp.org/how-to-reverse-a-string-in-javascript-in-3-different-ways-75e4763c68cb
            //Reverse a String With Recursion
            //function reverseString(str) {
            //    if (str === "") // This is the terminal case that will end the recursion
            //        return "";

            //    else
            //        return reverseString(str.substr(1)) + str.charAt(0);
            //    /* 
            //    First Part of the recursion method
            //    You need to remember that you won’t have just one call, you’ll have several nested calls
            //    Each call: str === "?"        	                  reverseString(str.subst(1))     + str.charAt(0)
            //    1st call – reverseString("Hello")   will return   reverseString("ello")           + "h"
            //    2nd call – reverseString("ello")    will return   reverseString("llo")            + "e"
            //    3rd call – reverseString("llo")     will return   reverseString("lo")             + "l"
            //    4th call – reverseString("lo")      will return   reverseString("o")              + "l"
            //    5th call – reverseString("o")       will return   reverseString("")               + "o"
            //    Second part of the recursion method
            //    The method hits the if condition and the most highly nested call returns immediately
            //    5th call will return reverseString("") + "o" = "o"
            //    4th call will return reverseString("o") + "l" = "o" + "l"
            //    3rd call will return reverseString("lo") + "l" = "o" + "l" + "l"
            //    2nd call will return reverserString("llo") + "e" = "o" + "l" + "l" + "e"
            //    1st call will return reverserString("ello") + "h" = "o" + "l" + "l" + "e" + "h" 
            //    */
            //}
            //reverseString("hello");





            // //Sum an array
            //        using System;
            //using System.Collections.Generic;
            //using System.IO;
            //using System.Linq;

            //class Solution
            //            {

            //                /*
            //                 * Complete the simpleArraySum function below.
            //                 */
            //                static int simpleArraySum(int[] ar)
            //                {
            //                    int sum = 0;
            //                    int i = 0;
            //                    int n = ar.Length;
            //                    for (i = 0; i < n; i++)
            //                    {
            //                        sum += ar[i];
            //                    }
            //                    return sum;
            //                }

            //                static void Main(string[] args)
            //                {
            //                    TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            //                    int arCount = Convert.ToInt32(Console.ReadLine());

            //                    int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp))
            //                    ;
            //                    int result = simpleArraySum(ar);

            //                    textWriter.WriteLine(result);

            //                    textWriter.Flush();
            //                    textWriter.Close();
            //                }
            //            }







            // https://www.hackerrank.com/challenges/a-very-big-sum/problem
            //// Complete the aVeryBigSum function below.
            //static long aVeryBigSum(long[] ar)
            //{
            //    return ar.Sum(); // this was all I needed??? 

            //    //var sum = ar.Sum(a => (long)a); // or using LINQ

            //    //return sum; //using LINQ
            //}

            //static void Main(string[] args)
            //{
            //    TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            //    int arCount = Convert.ToInt32(Console.ReadLine());

            //    long[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt64(arTemp))
            //    ;
            //    long result = aVeryBigSum(ar);

            //    textWriter.WriteLine(result);

            //    textWriter.Flush();
            //    textWriter.Close();
            //}



            //            using System;
            //using System.Collections.Generic;
            //using System.IO;


            //static void Main(String[] args)
            //{
            //    int i = 4;
            //    double d = 4.0;
            //    string s = "HackerRank ";


            //    // Declare second integer, double, and String variables.
            //    //int j = 0;
            //    //double e = 0;
            //    //string t = "";

            //    // Read and save an integer, double, and String to your variables.
            //    int j =Convert.ToInt32( Console.ReadLine());
            //    double e = Convert.ToDouble(Console.ReadLine());
            //    string t = Console.ReadLine();
            //    // Print the sum of both integer variables on a new line.
            //    var intSum = i + j;
            //    Console.WriteLine(intSum);

            //    // Print the sum of the double variables on a new line.
            //    var doubleSum = d + e;
            //    Console.WriteLine(doubleSum);
            //    // Concatenate and print the String variables on a new line
            //    // The 's' variable above should be printed first.
            //    var stringConcat = s + t;
            //    Console.WriteLine(stringConcat);
            //    Console.ReadKey();
            //}


            ////https://www.hackerrank.com/challenges/diagonal-difference/problem?h_r=next-challenge&h_v=zen

            //static int diagonalDifference(int[][] arr)
            //{
            //    var sumADiagonal = 0;
            //    var sumBDiagonal = 0;


            //    for(int i = 0; i < arr.Length; i++)
            //    {
            //        sumADiagonal += arr[i][i];
            //        sumBDiagonal += arr[((arr.Length - 1) - i)][i];
            //    }
            //    return Math.Abs(sumADiagonal - sumBDiagonal);

            //}

            //static void Main(string[] args)
            //{
            //    TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            //    int n = Convert.ToInt32(Console.ReadLine());

            //    int[][] arr = new int[n][];

            //    for (int i = 0; i < n; i++)
            //    {
            //        arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            //    }

            //    int result = diagonalDifference(arr);

            //    textWriter.WriteLine(result);

            //    textWriter.Flush();
            //    textWriter.Close();
            //}





            //        //   https://www.hackerrank.com/challenges/30-conditional-statements/problem?h_r=email&unlock_token=2af73adfd8abde4d2641b1b624435338fb7ba546&utm_campaign=30_days_of_code_continuous&utm_medium=email&utm_source=daily_reminder
            //           static void Main(string[] args)
            //           {
            //Console.Write("Enter a number from 1 to 100 : ");

            //               int N = Convert.ToInt32(Console.ReadLine());

            //               bool even1 = N % 2 == 0;

            //               if ( even1 == false)
            //               {
            //                   Console.WriteLine("Weird");
            //               }
            //               else if (even1 == true && N >= 2 && N <= 5)
            //               {
            //                   Console.WriteLine("Not Weird");
            //               }

            //               else if(even1 == true && N >= 6 && N <= 20)
            //               {
            //                   Console.WriteLine("Weird");
            //               }
            //               else if (even1 == true && N > 20)
            //               {
            //                   Console.WriteLine("Not Weird");
            //               }



            //               Console.ReadKey();

            //           }

            //    //https://www.hackerrank.com/challenges/plus-minus/problem
            //    static void plusMinus(int[] arr)
            //    {

            //        double pos = 0;
            //        double neg = 0;
            //        double z = 0;
            //        var res = new Array[1]; //did I ever use this line????

            //        for (int i = 0; i < arr.Length;  i++)
            //            if (arr[i] > 0)
            //            {
            //                pos += 1;

            //            }
            //        else if(arr[i] < 0)
            //        {
            //            neg += 1;

            //        }
            //        else if(arr[i] == 0)
            //        {
            //            z += 1;

            //        }

            //        Console.WriteLine(pos / arr.Length);
            //        Console.WriteLine(neg / arr.Length);
            //        Console.WriteLine(z / arr.Length);
            //    }

            //    static void Main(string[] args)
            //    {
            //        int n = Convert.ToInt32(Console.ReadLine());

            //        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
            //        ;
            //        plusMinus(arr);
            //    }

            //}


            ////https://www.hackerrank.com/challenges/30-class-vs-instance/problem
            //class Person
            //{
            //    public int age;
            //    public Person(int initialAge)
            //    {
            //        // Add some more code to run some checks on initialAge
            //       if (initialAge > 0)
            //        {
            //            age = initialAge;
            //        }
            //       else
            //        {
            //           age = 0;
            //            Console.WriteLine("Age is not valid, setting age to 0.");
            //        }
            //    }
            //    public void amIOld()
            //    {
            //        // Do some computations in here and print out the correct statement to the console
            //        if (age < 13)
            //        {
            //            Console.WriteLine("You are young.");
            //        }
            //        else if (age>= 13 && age < 18)
            //        {
            //            Console.WriteLine("You are a teenager.");
            //        }
            //        else if ( age >= 18)
            //        {
            //            Console.WriteLine("You are old.");
            //        }
            //    }

            //    public void yearPasses()
            //    {
            //        // Increment the age of the person in here
            //        age = age + 1;
            //    }

            //    static void Main(String[] args)
            //    {
            //        int T = int.Parse(Console.In.ReadLine());
            //        for (int i = 0; i < T; i++)
            //        {
            //            int age = int.Parse(Console.In.ReadLine());
            //            Person p = new Person(age);
            //            p.amIOld();
            //            for (int j = 0; j < 3; j++)
            //            {
            //                p.yearPasses();
            //            }
            //            p.amIOld();
            //            Console.WriteLine();
            //        }
            //    }
            //}






            //// https://www.hackerrank.com/challenges/30-loops/problem?h_r=email&unlock_token=575cdf50dea76cf06a564a4943c523eff4f088c8&utm_campaign=30_days_of_code_continuous&utm_medium=email&utm_source=daily_reminder


            //static void Main(string[] args)
            //{
            //    int n = Convert.ToInt32(Console.ReadLine());

            //    var i = 1;
            //    for (i = 1; i <= 10; i++)
            //    {
            //        Console.WriteLine("{0} x {1} = {2}", n, i, (n*i));

            //    }

            //}






            ////https://www.hackerrank.com/challenges/30-operators/problem?h_r=email&unlock_token=575cdf50dea76cf06a564a4943c523eff4f088c8&utm_campaign=30_days_of_code_continuous&utm_medium=email&utm_source=daily_reminder&h_r=next-challenge&h_v=zen
            //// Complete the solve function below.
            //static void solve(double meal_cost, int tip_percent, int tax_percent)
            //{
            //    var tip = Convert.ToDouble(tip_percent);
            //    var tax = Convert.ToDouble(tax_percent);

            //    var total = Math.Round(meal_cost + (meal_cost * (tip / 100)) + (meal_cost * (tax / 100)));

            //    int convert = Convert.ToInt32(total);

            //    Console.WriteLine("The total meal cost is " + convert + " dollars.");
            //Console.ReadKey();
            //}

            //static void Main(string[] args)
            //{
            //    double meal_cost = Convert.ToDouble(Console.ReadLine());

            //    int tip_percent = Convert.ToInt32(Console.ReadLine());

            //    int tax_percent = Convert.ToInt32(Console.ReadLine());

            //    solve(meal_cost, tip_percent, tax_percent);
            //}




            // https://www.hackerrank.com/challenges/30-review-loop/problem?h_r=next-challenge&h_v=zen


            //////static void oddEven(int n, int[] arr)
            //////            {




            //////                Console.WriteLine("");

            //////                Console.ReadKey();
            //////            }

            //////            static void Main(String[] args)
            //////            {
            //////                int n = Convert.ToInt32(Console.ReadLine());

            //////                int[][] jaggedArray = new int[n][];

            //////                int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));





            //////                oddEven(n, arr);

            //////            }


            //////C# solution

            //static void Main(string[] args)
            //{
            //    int T = Convert.ToInt32(Console.ReadLine());
            //    string[] s1 = new string[T];

            //    int i = 0;
            //    while (i < T)
            //    {
            //        string s = Console.ReadLine(); //continues to read the console lines until we reached last line based on first input integer.
            //        s1[i++] = s;
            //    }

            //    i = 0;
            //    while (i < T)
            //    {
            //        char[] c1 = s1[i].ToCharArray();
            //        string even = "";
            //        string odd = "";
            //        for (int j = 0; j < c1.Length; j++)
            //        {
            //            if (j % 2 == 0) even += c1[j];
            //            if (j % 2 != 0) odd += c1[j];
            //        }
            //        Console.WriteLine(even + " " + odd);
            //        i++;
            //    }
            //}

            ////////Looks like javascript here
            //////public static void main(String[] args)
            //////{

            //////    Scanner scan = new Scanner(System.in);
            //////    int i = scan.nextInt();
            //////    scan.nextLine();
            //////    String[] lines = new String[i];

            //////    for (int j = 0; j < i; j++)
            //////    {

            //////        lines[j] = scan.nextLine();
            //////        char[] characters = lines[j].toCharArray();

            //////        for (int k = 0; k < lines[j].length(); k += 2)
            //////        {
            //////            System.out.print(characters[k]);
            //////        }
            //////        System.out.print(" ");

            //////        for (int k = 1; k < lines[j].length(); k += 2)
            //////        {
            //////            System.out.print(characters[k]);
            //////        }
            //////        System.out.println();
            //////    }
            //////    scan.close();
            //////}







            //// https://www.hackerrank.com/challenges/30-arrays/problem

            //static void Main(string[] args)
            //{
            //    int n = Convert.ToInt32(Console.ReadLine());

            //    int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
            //    ;

            //    string reverse = "";
            //    int i = 0;
            //    for (i = (arr.Length) - 1; i >= 0; i--)
            //    {
            //        reverse += arr[i] + " ";
            //    }

            //    Console.WriteLine(reverse);
            //               Console.ReadKey();

            //}




            //// https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2?redirectedfrom=MSDN&view=netframework-4.7.2
            //static void Main(string[] args)
            //{           
            //    //English to spanish dictionary

            //    Dictionary<string, string> translateEnglishToSpanish = new Dictionary<string, string>();

            //    //Adding elements to dictonary, no duplicate "Keys" (first values), but some duplicate "Values" (second value/input)
            //    translateEnglishToSpanish.Add("I'm sorry", "Lo siento");
            //    translateEnglishToSpanish.Add("bathroom", "bano");
            //    translateEnglishToSpanish.Add("Monday", "Lunes");
            //    translateEnglishToSpanish.Add("Hi", "Hola");

            //    try
            //    {
            //        translateEnglishToSpanish.Add("bathroom", "biblioteca");
            //    }
            //    catch (ArgumentException)
            //    {
            //        Console.WriteLine("An element with Key = \"bathroom\" already exists.");
            //    }

            //    foreach (KeyValuePair<string, string> kvp in translateEnglishToSpanish)
            //    {
            //        Console.WriteLine("Key = {0}, Value = {1}",
            //                      kvp.Key, kvp.Value);

            //    }
            //}




            ////https://www.hackerrank.com/challenges/30-dictionaries-and-maps/problem?h_r=next-challenge&h_v=zen


            //static void Main(String[] args)
            //{
            //    int N = Convert.ToInt32(Console.ReadLine());
            //    Dictionary<string, int> phoneBook = new Dictionary<string, int>(N);
            //    for (int i = 0; i < N; i++)
            //    {
            //        string[] temp = Console.ReadLine().Split(' ');
            //        if (temp[1].Length == 8)
            //        {
            //            phoneBook.Add(temp[0], Convert.ToInt32(temp[1]));
            //        }
            //    }
            //    string nameToSearch = "";
            //    while ((nameToSearch = Console.ReadLine()) != null)
            //    {
            //        int flagFound = 0;
            //        if (nameToSearch != "")
            //        {
            //            if (phoneBook.ContainsKey(nameToSearch))
            //            {
            //                flagFound = 1;
            //            }
            //        }
            //        if (flagFound == 1)
            //        {
            //            Console.WriteLine(nameToSearch + "=" + phoneBook[nameToSearch]);
            //        }
            //        else
            //        {
            //            Console.WriteLine("Not found");
            //        }
            //    }
            //    Console.ReadKey();
            //}




            //ALMOST CORRECT ALTERNATE SOLUTION
            //static void Main(String[] args)
            //{
            //    int n = Convert.ToInt32(Console.ReadLine());
            //    var d = new Dictionary<string, string>();
            //    for (int i = 0; i < n; i++)
            //    {
            //        var s = Console.ReadLine().Split(' ');
            //        d.Add(s[0], s[1]);
            //    }
            //    for (int i = 0; i < n; i++)
            //    {
            //        var s = Console.ReadLine();
            //        if (d.ContainsKey(s))
            //        {
            //            Console.WriteLine(s + "=" + d[s]);
            //        }
            //        else
            //        {
            //            Console.WriteLine("Not found");
            //        }

            //        Console.ReadKey();

            //    }
            //}

            //https://www.hackerrank.com/challenges/30-binary-numbers/problem?h_r=next-challenge&h_v=zen

            //static void Main(string[] args)
            //{
            //    int n = Convert.ToInt32(Console.ReadLine());


            //    string binary = Convert.ToString(n, 2);

            //    string[] arr = binary.Split('0').ToArray();

            //    var maxOnes = arr.Select(x =>x.Length).Max();                

            //    Console.WriteLine(maxOnes);

            //    Console.ReadKey();

            //}




            ////ANOTHER SOLUTION
            //static void Main(String[] args)
            //{
            //    int n = Convert.ToInt32(Console.ReadLine());
            //    int Quotient = n;
            //    int Remainder = 0;
            //    string BinaryValue = "";


            //    while (Quotient > 0)
            //    {
            //        Remainder = Quotient % 2;
            //        BinaryValue = Remainder.ToString() + BinaryValue;
            //        Quotient = Quotient / 2;
            //    }
            //    Console.WriteLine(CheckConsecutive(BinaryValue));

            //    Console.ReadKey();
            //}

            //static string CheckConsecutive(string BinValue)
            //{

            //    int HighestConsecutive = 0;
            //    int CurrentConsecutive = 0;
            //    for (int i = 0; i < BinValue.Length; i++)
            //    {
            //        if (BinValue.Substring(i, 1) == "1" && i != BinValue.Length - 1)
            //        {
            //            CurrentConsecutive++;
            //        }
            //        else
            //        {
            //            if (i == BinValue.Length - 1 && BinValue.Substring(i, 1) == "1")
            //            {
            //                CurrentConsecutive++;
            //            }
            //            if (CurrentConsecutive > HighestConsecutive)
            //            {
            //                HighestConsecutive = CurrentConsecutive;
            //            }
            //            CurrentConsecutive = 0;
            //        }
            //    }
            //    return HighestConsecutive.ToString();
            //}







            //https://www.hackerrank.com/challenges/30-2d-arrays/problem

            //static void Main(string[] args)
            //{
            //    int[][] arr = new int[6][];

            //    for (int i = 0; i < 6; i++)
            //    {
            //        arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            //    }

            //int[] sum = new int[16];
            //int h = -64;
            //for (int i = 0; i < 4; i++)
            //{
            //    for (int j = 0; j < 4; j++)
            //    {
            //        sum[h] = arr[i][j] + arr[i][j + 1] + arr[i][j + 2]
            //                + arr[i + 1][j + 1] + arr[i + 2][j] + arr[i + 2][j + 1]
            //                + arr[i + 2][j + 2];
            //        h++;
            //    }
            //}
            //Array.Sort(sum);
            //Console.WriteLine(sum[15]);
            //Console.ReadKey();


            ////slightly different solution
            //// OMG HAD TO PUT SPACES IN INPUT!!!! NEXT TIME COPY SAMPLE INPUT OR AT LEAST CHECK IF THERE ARE SPACES!!!
            //static void Main(string[] args)
            //{
            //    int[][] arr = new int[6][];

            //    for (int i = 0; i < 6; i++)
            //    {
            //        arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            //    }
            //    int sum = -64;
            //    int sumTemp = 0;
            //    for (int i = 0; i < 4; i++)
            //    {
            //        for (int j = 0; j < 4; j++)
            //        {
            //            sumTemp = arr[i][j] + arr[i][j + 1] + arr[i][j + 2]
            //                    + arr[i + 1][j + 1] + arr[i + 2][j] + arr[i + 2][j + 1]
            //                    + arr[i + 2][j + 2];
            //            if (sumTemp > sum)
            //            {
            //                sum = sumTemp;
            //            }//this will keep sum up to date
            //        }
            //    }

            //    Console.WriteLine(sum);
            //    Console.ReadKey();







                //////another solution, Javascript ok avoid i guess

                //function main()
                //    {
                //        var arr = [];
                //        for (arr_i = 0; arr_i < 6; arr_i++)
                //        {
                //            arr[arr_i] = readLine().split(' ');
                //            arr[arr_i] = arr[arr_i].map(Number);
                //        }

                //        //setting highestSum initially to -63 because that is lowest possible outcome for hourglass.
                //        //-9 -9 -9
                //        //   -9
                //        //-9 -9 -9
                //        // = -63
                //        var highestSum = -63;
                //        var tempSum = 0;
                //        for (let i = 0; i < 4; i++)
                //        {
                //            for (let j = 0; j < 4; j++)
                //            {
                //                tempSum = arr[i][j] + arr[i][j + 1] + arr[i][j + 2] + arr[i + 1][j + 1] + arr[i + 2][j] + arr[i + 2][j + 1] + arr[i + 2][j + 2];
                //                if (tempSum > highestSum)
                //                {
                //                    highestSum = tempSum;
                //                }
                //            }
                //        }

                //        console.log(highestSum);
                //    }











            


        }
    }
}

