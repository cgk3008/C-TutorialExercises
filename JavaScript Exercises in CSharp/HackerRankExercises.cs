﻿
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
            //        var res = new Array[1];

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


            //https://www.hackerrank.com/challenges/30-class-vs-instance/problem
            class Person
            {
                public int age;
                public Person(int initialAge)
                {
                    // Add some more code to run some checks on initialAge
                   if (initialAge > 0)
                    {
                        age = initialAge;
                    }
                   else
                    {
                       age = 0;
                        Console.WriteLine("Age is not valid, setting age to 0.");
                    }
                }
                public void amIOld()
                {
                    // Do some computations in here and print out the correct statement to the console
                    if (age < 13)
                    {
                        Console.WriteLine("You are young.");
                    }
                    else if (age>= 13 && age < 18)
                    {
                        Console.WriteLine("You are a teenager.");
                    }
                    else if ( age >= 18)
                    {
                        Console.WriteLine("You are old.");
                    }
                }

                public void yearPasses()
                {
                    // Increment the age of the person in here
                    age = age + 1;
                }

                static void Main(String[] args)
                {
                    int T = int.Parse(Console.In.ReadLine());
                    for (int i = 0; i < T; i++)
                    {
                        int age = int.Parse(Console.In.ReadLine());
                        Person p = new Person(age);
                        p.amIOld();
                        for (int j = 0; j < 3; j++)
                        {
                            p.yearPasses();
                        }
                        p.amIOld();
                        Console.WriteLine();
                    }
                }
            }

        }
    }
}

