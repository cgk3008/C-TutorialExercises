﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JavaScript_Exercises_in_CSharp
{
    class UdemyTutorial_Begin
    {
        //public enum ShippingMethod
        //{
        //    RegularAirMail = 1,
        //    REgisterAirmail = 2,
        //    Express = 3
        //}

        // class Program
        //  {
        //static void Main(string[] args)
        //{
        //    var method = ShippingMethod.Express;
        //    Console.WriteLine((int)method);

        //    var methodId = 3;
        //    Console.WriteLine((ShippingMethod)methodId);

        //    Console.WriteLine(method.ToString()); ///explicity converting to string

        //    Console.WriteLine(method); //automatically converts to string

        //    var methodName = "Express";
        //    var shippingMethod = (ShippingMethod)Enum.Parse(typeof(ShippingMethod), methodName); //pares a string to an Enum

        //    Console.ReadKey();
        //}


        //class Program
        // {
        //static void Main(string[] args)
        //{
        //    var a = 10;
        //    var b = a;
        //    b++;
        //    Console.WriteLine(string.Format("a: {0}, b: {1}", a, b));

        //    var array1 = new int[3] { 1, 2, 3 };
        //    var array2 = array1;
        //    array2[0] = 0;
        //    Console.WriteLine(string.Format("array1[0]: {0}, array2[0]: {1}", array1[0], array2[0]));


        //    Console.ReadKey();
        //}
        //}

        //public class Program
        //{
        //    public class Person
        //    {
        //        public int Age;
        //    }

        //    static void Main(string[] args)
        //    {
        //        var number = 1;
        //        Increment(number);
        //        Console.WriteLine(number);

        //        var person = new Person()
        //        {  Age = 20};
        //        MakeOld(person);
        //        Console.WriteLine(person.Age);


        //        Console.ReadKey();
        //    }
        //    public static void Increment(int number)
        //    {
        //        number += 10;
        //    }

        //    public static void MakeOld(Person person)
        //    {
        //        person.Age += 10;
        //    }


        //}

        class Program
        {
            //static void Main(string[] args)
            //{
            //    ////int hour = 10;

            //    ////if (hour > 0 && hour < 12)
            //    ////{
            //    ////    Console.WriteLine("It's morning.");
            //    ////}
            //    ////else if (hour >= 12 && hour < 18)
            //    ////{
            //    ////    Console.WriteLine("It's afternoon.");
            //    ////}
            //    ////else
            //    ////{
            //    ////    Console.WriteLine("It's evening.");
            //    ////}
            //    ////Console.ReadKey();


            //    //bool isGoldCustomer = true;

            //    ////float price;
            //    ////if (isGoldCustomer)
            //    ////{
            //    ////    price = 19.95f;
            //    ////}
            //    ////else
            //    ////{
            //    ////    price = 29.95f;
            //    ////}

            //    //float price = (isGoldCustomer) ? 19.95f : 29.95f; //isGold Customer is true so price = 19.95, otherwise it would be 29.95 if false.

            //    //Console.WriteLine(price);

            //    //Console.ReadKey();

            //}




            //public enum Season
            //{
            //    Spring,
            //    Summer,
            //    Autumn,
            //    Winter
            //}
            //static void Main(string[] args)
            //{
            //    var season = Season.Spring;

            //    switch (season)
            //    {
            //        case Season.Autumn:
            //            Console.WriteLine("it's Autumn and a beautiful season.");
            //            Console.ReadKey();
            //            break;

            //            case Season.Summer:
            //            Console.WriteLine("Let's go to the beach.");
            //            Console.ReadKey();
            //            break;

            //        case Season.Winter:
            //        case Season.Spring:
            //            Console.WriteLine("We have a promotional sale!");
            //            Console.ReadKey();
            //            break;



            //        default:
            //            Console.WriteLine("I don;t understand that season!");
            //            Console.ReadKey();
            //            break;

            //    }
            //}

            //static void Main(string[] args)
            //{


            //    //Console.WriteLine("Enter number from 1 to 10");

            //    //int number;
            //    //number = Convert.ToInt32(Console.ReadLine());
            //    //if (number >=1  && number <= 10)
            //    //{
            //    //    Console.WriteLine("Number is valid");
            //    //}
            //    //else 
            //    //        {
            //    //    Console.WriteLine("Invalid number entered");
            //    //}
            //    //Console.ReadKey();






            //    //int number1, number2;
            //    //Console.WriteLine("Enter first number");
            //    //number1 = Convert.ToInt32(Console.ReadLine());

            //    //Console.WriteLine("Enter second number");
            //    //number2 = Convert.ToInt32(Console.ReadLine());

            //    //if (number1 > number2)
            //    //{
            //    //    Console.WriteLine(number1 + " is greater!");
            //    //    Console.ReadKey();
            //    //}
            //    //else if (number2 > number1)
            //    //{
            //    //    Console.WriteLine(number2 + " is greater!");
            //    //    Console.ReadKey();
            //    //}
            //    //else
            //    //{
            //    //    Console.WriteLine("Numbers are equal or null!");
            //    //    Console.ReadKey();
            //    //}







            //    //int number1, number2;
            //    //Console.WriteLine("Enter width");
            //    //number1 = Convert.ToInt32(Console.ReadLine());

            //    //Console.WriteLine("Enter height");
            //    //number2 = Convert.ToInt32(Console.ReadLine());

            //    //if (number1 > number2)
            //    //{
            //    //    Console.WriteLine("Picture is landscape");
            //    //    Console.ReadKey();
            //    //}
            //    //else if (number2 > number1)
            //    //{
            //    //    Console.WriteLine(" picture is portrait");
            //    //    Console.ReadKey();
            //    //}
            //    //else
            //    //{
            //    //    Console.WriteLine("Picture is square or null!");
            //    //    Console.ReadKey();
            //    //}





            //    //int speedLimit, carSpeed, demerit;

            //    //Console.WriteLine("enter speed limit");
            //    //speedLimit = Convert.ToInt32(Console.ReadLine());

            //    //Console.WriteLine("Enter car speed");

            //    //carSpeed = Convert.ToInt32(Console.ReadLine());

            //    //if (carSpeed <= speedLimit)
            //    //{
            //    //    Console.WriteLine("Car speed does not exceed speed limit.");
            //    //    Console.ReadKey();
            //    //}
            //    //else if (carSpeed > speedLimit && ((carSpeed-speedLimit)/5 <= 12))
            //    //{

            //    //    demerit = (carSpeed - speedLimit) / 5;
            //    //    Console.WriteLine("Car speed exceeds speed limit." + demerit + " demerits have been issued to driver!");
            //    //    Console.ReadKey();
            //    //}
            //    //else if (carSpeed > speedLimit && ((carSpeed - speedLimit) / 5 > 12))
            //    //{
            //    //    Console.WriteLine("License Suspended!");
            //    //    Console.ReadKey();
            //    //}
            //    //else
            //    //{
            //    //    Console.WriteLine("inputs are negative or null, re-enter input");
            //    //    Console.ReadKey();
            //    //}



            //    //var numbers = new int[] { 1, 2, 3, 4 };

            //    //foreach(var number in numbers)
            //    //{
            //    //    Console.WriteLine(number);
            //    //    Console.ReadKey();
            //    //}


            //    //while (true)
            //    //{
            //    //    Console.Write("Type your name: ");
            //    //    var input = Console.ReadLine();

            //    //    if (String.IsNullOrWhiteSpace(input))
            //    //        break;

            //    //    Console.WriteLine("@Echo: " + input);
            //    //    Console.ReadKey();
            //    //}






            //    //while (true)
            //    //{
            //    //    Console.Write("Type your name: ");
            //    //    var input = Console.ReadLine();

            //    //    if (!String.IsNullOrWhiteSpace(input)) ///note not operator "!"
            //    //    {

            //    //        Console.WriteLine("@Echo: " + input);
            //    //        continue;
            //    //    }

            //    //    break;


            //    //}


            //}






            ////static void Main(string[] args)
            ////{
            ////    var random = new Random();

            ////    for (var i = 0; i < 10; i++)
            ////    {
            ////        Console.Write((char)random.Next(97, 122));

            ////    }
            ////    Console.WriteLine();//empty line,to start code below on a new line


            ////    Console.WriteLine(random.Next());
            ////    Console.WriteLine((int)'a');


            ////    const int passwordLength = 10;
            ////    char[] buffer = new char[passwordLength];
            ////    for (var i = 0; i < passwordLength; i++)
            ////    {
            ////        buffer[i] = ((char)('a' + random.Next(0, 26)));

            ////        //var password = "";

            ////        var password2 = new String(buffer);
            ////        //Console.WriteLine(password);//empty line,to start code below on a new line
            ////        Console.WriteLine(password2);
            ////    }



            ////    Console.ReadKey();
            ////}







            ////1- Write a program to count how many numbers between 1 and 100 are divisible by 3 with no remainder.Display the count on the console.

            //            static void Main(string[] args)
            //            {
            //                int count = 0;
            //                for(var i =0; i<101; i++)
            //                {
            //                    if(i % 3 == 0)
            //                    {
            //                        count += 1;
            //                    }
            //                }

            //                Console.WriteLine(count);
            //                Console.ReadKey();

            //            }


            //2- Write a program and continuously ask the user to enter a number or "ok" to exit. Calculate the sum of all the previously entered numbers and display it on the console.

            //SOLUTION BELOW NOT WORKING
            //////static void Main(string[] args)
            //////{


            //////    Console.WriteLine("Enter number and repeat. Type 'ok' to exit and sum numbers");

            //////    int n = 0;
            //////    while(Console.ReadLine() != "ok" || Console.ReadLine() != null)

            //////    {
            //////        int input = Convert.ToInt32(Console.ReadLine());
            //////        n += input;
            //////    }

            //////    Console.WriteLine(n);
            //////    Console.ReadKey();
            //////}

            //static void Main(string[] args)
            //{


            //    int sum = 0;


            //    bool okCheck = true;

            //    while (okCheck == true)
            //    {
            //        Console.WriteLine("enter number or 'ok' to exit");
            //        var input = Console.ReadLine();

            //        if (input == "ok")
            //        {
            //            okCheck = false;
            //            Console.WriteLine("ok check is now false");

            //        }
            //        else
            //        {
            //           var inputNumber = Convert.ToInt32(input);
            //            sum += inputNumber;

            //        }


            //    }
            //    Console.WriteLine("Sum of numbers is below");
            //    Console.WriteLine(sum);
            //    Console.ReadKey();

            //}




            //3- Write a program and ask the user to enter a number.Compute the factorial of the number and print it on the console. For example, if the user enters 5, the program should calculate 5 x 4 x 3 x 2 x 1 and display it as 5! = 120.

            //    static void Main(string[] args)
            //{

            //    Console.WriteLine("Enter a number to compute factorial");


            //    var input = Console.ReadLine();

            //    int factorial = Convert.ToInt32(input);

            //    if (factorial ==0 || factorial == 1)
            //    {
            //        Console.WriteLine(factorial + "! = 1");
            //    }

            //    for (var i = factorial - 1; i > 0; i--)
            //    {
            //        factorial *= i;
            //    }

            //    Console.WriteLine(input + "! = " + factorial);
            //    Console.ReadKey();
            //}



            //            //4- Write a program that picks a random number between 1 and 10. Give the user 4 chances to guess the number.If the user guesses the number, display “You won"; otherwise, display “You lost". (To make sure the program is behaving correctly, you can display the secret number on the console first.)

            //            static void Main(string[] args)
            //            {
            //                Random random = new Random();
            //                int generatedNUmber = random.Next(1, 10);

            //                Console.WriteLine(generatedNUmber);

            //                Console.WriteLine("Guess a number between 1 and 10");

            //                for (int i = 0; i < 100; i++)
            //                {

            //                    var guess = Convert.ToInt32(Console.ReadLine());

            //                    if (guess > 10 || guess < 1)
            //                    {
            //                        Console.WriteLine("Number outside of range");
            //                    }

            //                    if (guess == generatedNUmber)
            //                    {
            //                        Console.WriteLine("You guessed correctly! You win!");
            //break;
            //                    }

            //                    else
            //                    {
            //                        Console.WriteLine("Guess again");
            //                    }
            //                }
            //                Console.ReadKey();
            //            }



            //5- Write a program and ask the user to enter a series of numbers separated by comma.Find the maximum of the numbers and display it on the console.For example, if the user enters “5, 3, 8, 1, 4", the program should display 8.

            //static void Main(string[] args)
            //{

            //    Console.WriteLine("Enter a series of numbers separated by commas");

            //    int[] arr = Array.ConvertAll(Console.ReadLine().Split(','), arrTemp => Convert.ToInt32(arrTemp));

            //    Console.WriteLine(arr.Max());

            //    Console.ReadKey();


            //}





            //    //// ARRAYS!
            //static void Main(string[] args)
            //{
            //    var numbers = new[] { 3, 7, 9, 2, 14, 6 };

            //    //Length
            //    Console.WriteLine("Length: " + numbers.Length);

            //    //IndexOf()
            //   var index =  Array.IndexOf(numbers, 9);

            //    Console.WriteLine("Index of 9: " + index);

            //    //Clear Method
            //    Array.Clear(numbers, 0, 2);

            //    Console.WriteLine("Effect of Clear()");
            //    foreach (var n in numbers)
            //        Console.WriteLine(n);


            //    //Copy()
            //    int[] another = new int[3];
            //    Array.Copy(numbers, another, 3);
            //    Console.WriteLine("Effect of Copy()");
            //    foreach (var n in another)
            //        Console.WriteLine(n);


            //    //Sort()
            //    Array.Sort(numbers);
            //    Console.WriteLine("Effect of Sort()");
            //    foreach (var n in numbers)
            //        Console.WriteLine(n);


            //    //Reverse()
            //    Array.Reverse(numbers);
            //    Console.WriteLine("Effect of Reverse()");
            //    foreach (var n in numbers)
            //        Console.WriteLine(n);


            //    Console.ReadKey();
            //}



            //// LISTS!   Generic lists

            //static void Main(string[] args)
            //{
            //    var numbers = new List<int>() {  1, 2, 3, 4 };

            //    numbers.Add(1);
            //    numbers.AddRange(new int[3] { 5, 6, 7 });

            //    foreach (var number in numbers)
            //        Console.WriteLine(number);


            //    //IndexOf()
            //    Console.WriteLine();
            //    Console.WriteLine("Index of 1: " + numbers.IndexOf(1));
            //    Console.WriteLine("Last index of 1: " + numbers.LastIndexOf(1));

            //    Console.WriteLine("Count: " + numbers.Count);

            //    numbers.Remove(1);
            //    foreach (var number in numbers)
            //        Console.WriteLine(number);




            //    //// CANNOT MODIFY COLLECTION IN FOREACH LOOP, SO USE FOR LOOP!!!
            //    //foreach (var number in numbers)
            //    //{
            //    //    if (number == 1)
            //    //        numbers.Remove(number);
            //    //}

            //    //foreach (var number in numbers)
            //    //    Console.WriteLine(number);
            //    Console.WriteLine();
            //    for ( var i =0; i < numbers.Count; i++)
            //    {
            //        if (numbers[i] == 1)
            //            numbers.Remove(numbers[i]);

            //    }

            //    foreach (var number in numbers)
            //        Console.WriteLine(number);


            //    Console.WriteLine();
            //    numbers.Clear();
            //    Console.WriteLine("Count: " + numbers.Count);


            //    Console.ReadKey();
            //}


            ////            Exercises
            ////Section 6, Lecture 56
            ////Note: For any of these exercises, ignore input validation unless otherwise directed.Assume the user enters values in the format that the program expects.



            ////1- When you post a message on Facebook, depending on the number of people who like your post, Facebook displays different information.

            ////If no one likes your post, it doesn't display anything.
            ////If only one person likes your post, it displays: [Friend's Name] likes your post.
            ////If two people like your post, it displays: [Friend 1] and [Friend 2] like your post.
            ////If more than two people like your post, it displays: [Friend 1], [Friend 2] and[Number of Other People] others like your post.
            ////Write a program and continuously ask the user to enter different names, until the user presses Enter (without supplying a name). Depending on the number of names provided, display a message based on the above pattern.

            //static void Main(string[] args)
            //{

            //    List<string> input = new List<string>();
            //    do
            //    {
            //        Console.WriteLine(" Enter name for Likes");

            //        input.Add(Console.ReadLine());

            //    }

            //    while (Console.ReadKey(true).Key != ConsoleKey.Enter); // not quite what I wanted, have to enter a non "enter"  key first to repeat the WriteLine code

            //    if (input.Count == 1)
            //    {
            //        Console.WriteLine(input[0] + " likes your post.");
            //    }

            //    else
            //    {

            //        if (input.Count < 3)
            //        {
            //            Console.WriteLine(input[0] + " and " + input[1] + " likes your post.");
            //        }

            //        else if (input.Count > 2)
            //        {

            //            Console.WriteLine(input[0] + " and " + input[1] + " " + (input.Count -2) + " other likes your post.");
            //        }

            //        Console.ReadKey();

            //    }






            ////2- Write a program and ask the user to enter their name.Use an array to reverse the name and then store the result in a new string. Display the reversed name on the console.


            //static void Main(string[] args)
            //{
            //    Console.WriteLine("Enter your name please.");

            //    var name = Console.ReadLine();

            //    var reversed = "";

            //    for (int i = name.Length - 1; i >= 0; i--)
            //    {
            //        reversed += name[i];

            //    }

            //    Console.WriteLine(reversed);

            //    //second way to revers using Array method!!

            //    Console.WriteLine("Enter your name please.");
            //    var name2 = Console.ReadLine();

            //    char[] charArray = name2.ToCharArray();
            //    Array.Reverse(charArray);
            //    Console.WriteLine(charArray);


            //   // Another way
            //Console.WriteLine("enter your name");
            //    var name3 = Console.ReadLine();

            //    var array1 = new char[name3.Length];
            //    for (var i = name3.Length; i > 0; i--)
            //        array1[name3.Length - 1] = name3[i - 1];

            //    var reversed4 = new string(array1);
            //    Console.WriteLine("reversed name: " + reversed4);







            //    Console.ReadKey();
            //}




            ////3- Write a program and ask the user to enter 5 numbers.If a number has been previously entered, display an error message and ask the user to re-try. Once the user successfully enters 5 unique numbers, sort them and display the result on the console.



            ////4- Write a program and ask the user to continuously enter a number or type "Quit" to exit. The list of numbers may include duplicates.Display the unique numbers that the user has entered.



            ////5- Write a program and ask the user to supply a list of comma separated numbers (e.g 5, 1, 9, 2, 10). If the list is empty or includes less than 5 numbers, display "Invalid List" and ask the user to re-try; otherwise, display the 3 smallest numbers in the list.





            //            static void Main(string[] args)
            //            {


            //                //DateTime objects cannot be changed they are immutable

            ////                Question 2:
            ////What will be the output of this program?

            ////var dateTime = new DateTime(2015, 1, 1);

            ////                dateTime.AddYears(1);

            ////                Console.WriteLine(dateTime.Year);  ANSWER IS 2015


            //                var dateTime = new DateTime(2015, 1, 1);
            //                    var now = DateTime.Now;
            //                var today = DateTime.Today;

            //                Console.WriteLine("Hour: " + now.Hour);
            //                Console.WriteLine("Minute: " + now.Minute);

            //               var tomorrow =  now.AddDays(1);

            //                var yesterday = now.AddDays(-1);

            //                Console.WriteLine(now.ToLongDateString());
            //                Console.WriteLine(now.ToShortDateString());
            //                Console.WriteLine(now.ToLongTimeString());
            //                Console.WriteLine(now.ToShortTimeString());

            //                Console.WriteLine(now.ToString("yyyy-MM-dd HH:mm"));


            //                Console.WriteLine("");

            //                //Creating TimeSpan objects

            //                var timeSpan = new TimeSpan(1, 2, 3);

            //                var timeSpan1 = new TimeSpan(1, 0, 0);

            //                var timeSpan2 = TimeSpan.FromHours(1);  // very clean way to represent 1 hour!

            //                var start = DateTime.Now;
            //                var end = DateTime.Now.AddMinutes(2);

            //                var duration = end - start;
            //                Console.WriteLine("DUration: " + duration);

            //                //Properties
            //                Console.WriteLine("Minutes: " + timeSpan.Minutes);
            //                Console.WriteLine("Total minutes: " + timeSpan.TotalMinutes);

            //                //Add method
            //                Console.WriteLine("Add example: " + timeSpan.Add(TimeSpan.FromMinutes(8)));

            //                //Subtract method
            //                Console.WriteLine("Subtract example: " + timeSpan.Subtract(TimeSpan.FromMinutes(2)));

            //                //ToString method
            //                Console.WriteLine("ToString " + timeSpan.ToString());


            //                //Parse
            //                Console.WriteLine("Parse " + TimeSpan.Parse("01:02:03"));

            //                var currentYear = DateTime.Now.Year;
            //                Console.WriteLine(" Current year: " + currentYear);

            //                Console.ReadKey();

            //            }







            // Format Strings
            //https://docs.microsoft.com/en-us/dotnet/standard/base-types/standard-numeric-format-strings

            //decimal value = 123.456m;
            //Console.WriteLine(value.ToString("C2"));
            //// Displays $123.46

            //static void Main(string[] args)
            //{
            //    var fullName = "Cliff Koenig      ";
            //    Console.WriteLine("Trim:  '{0}'", fullName.Trim());
            //    Console.WriteLine("Trim:  '{0}'", fullName.Trim().ToUpper());

            //    var index = fullName.IndexOf(' ');
            //    var firstName = fullName.Substring(0, index);
            //    var lastName = fullName.Substring(index + 1);

            //    Console.WriteLine(" First Name: " + firstName);
            //    Console.WriteLine("Last Name: " + lastName);


            //    var names = fullName.Split(' ');
            //    Console.WriteLine("First Name using split: " + names[0]);
            //    Console.WriteLine(" Last Name using split: " + names[1]);

            //    Console. WriteLine(fullName.Replace("Cliff", "Clifford"));
            //    Console.WriteLine(fullName.Replace('i', 'I'));

            //    if (String.IsNullOrEmpty(null))
            //        Console.WriteLine("INVALID");

            //    if (String.IsNullOrEmpty(""))
            //        Console.WriteLine("INVALID NUmber 2");

            //    if (String.IsNullOrEmpty(" ".Trim()))
            //        Console.WriteLine("INVALID NUmber 3");

            //    //better isNullorWitespace
            //    if (String.IsNullOrWhiteSpace(" "))
            //        Console.WriteLine("INVALID NUmber 4");

            //    var str = "25";
            //    var age = Convert.ToInt32(str); //no one is older than 256 years

            //    //so better is
            //    Convert.ToByte(str);
            //    Console.WriteLine(age);

            //    float price = 29.95f;
            //    Console.WriteLine(price.ToString("C")); //everything has a ToString method.......
            //    Console.WriteLine(price.ToString("C0")); //


            //    Console.WriteLine("Press any key to continue....");
            //    Console.ReadKey();
            //}




            //    //https://www.udemy.com/csharp-tutorial-for-beginners/learn/v4/t/lecture/2984168?start=0
            //    static void Main(string[] args)
            //    {
            //        var sentence = "This is going to be a really really really really long text.";


            //        var summary = SummarizeText(sentence);

            //        Console.WriteLine(summary);

            //        Console.ReadKey();

            //    }
            //}

            ////create another method to use the above method repeatedly
            //static string SummarizeText(string text, int maxLength =25 )
            //{
            //    if (text.Length < maxLength)
            //        return text;


            //    text.Substring(0, maxLength); // this is not a good way to do this!

            //    var words = text.Split(' '); // now splitting by spaces!!!
            //    var totalCharacters = 0;
            //    var summaryWords = new List<string>();

            //    foreach (var word in words)
            //    {
            //        summaryWords.Add(word);

            //        totalCharacters += word.Length + 1; //adding +1 because of the space afetr the word!

            //        if (totalCharacters > maxLength)
            //            break;
            //    }

            //   return String.Join(" ", summaryWords) + "...";
            //}



            ////https://www.udemy.com/csharp-tutorial-for-beginners/learn/v4/t/lecture/2980852?start=0

            ////StringBUilder can't search strings, just manipulates!
            //static void Main(string[] args)
            //{
            //    var builder = new StringBuilder("Hello World");

            //    builder.Append('-', 10);
            //    builder.AppendLine();
            //    builder.Append("Header");
            //    builder.AppendLine();
            //    builder.Append('-', 10);

            //    builder
            //        .Append('-', 10)
            //    .AppendLine()
            //    .Append("Header")
            //    .AppendLine()
            //    .Append('-', 10);


            //    builder.Replace('-', '+');

            //    builder.Remove(0, 10);

            //    builder.Insert(0, new string('-', 10));

            //    Console.WriteLine(builder);

            //    Console.WriteLine("First Character: " + builder[0]);

            //    Console.ReadKey();



            //}


            //            1- Write a program and ask the user to enter a few numbers separated by a hyphen.Work out if the numbers are consecutive. For example, if the input is "5-6-7-8-9" or "20-19-18-17-16", display a message: "Consecutive"; otherwise, display "Not Consecutive".








            //2- Write a program and ask the user to enter a few numbers separated by a hyphen.If the user simply presses Enter, without supplying an input, exit immediately; otherwise, check to see if there are duplicates.If so, display "Duplicate" on the console.



            //3- Write a program and ask the user to enter a time value in the 24-hour time format(e.g. 19:00). A valid time should be between 00:00 and 23:59. If the time is valid, display "Ok"; otherwise, display "Invalid Time". If the user doesn't provide any values, consider it as invalid time. 



            //4- Write a program and ask the user to enter a few words separated by a space.Use the words to create a variable name with PascalCase.For example, if the user types: "number of students", display "NumberOfStudents". Make sure that the program is not dependent on the input.So, if the user types "NUMBER OF STUDENTS", the program should still display "NumberOfStudents".



            //5- Write a program and ask the user to enter an English word. Count the number of vowels (a, e, o, u, i) in the word. So, if the user enters "inadequate", the program should display 6 on the console.





            //public static void Main(string[] args)
            //{

            //    Console.WriteLine("enter your name");
            //    var name3 = Console.ReadLine();

            //    var reversed4 = ReverseName(name3);

            //    Console.WriteLine("reversed name: " + reversed4);

            //}

            //public static string ReverseName(string name3)
            //{
            //    var array1 = new char[name3.Length];
            //    for (var i = name3.Length; i > 0; i--)
            //        array1[name3.Length - 1] = name3[i - 1];

            //  return new string(array1);


            //}


            //public static void Main(string[] args)
            //{
            //    var numbers = new List<int>();

            //    while (true)
            //    {
            //        Console.Write("enter a number (or 'Quit' to exit): ");
            //        var input = Console.ReadLine();

            //        if (input.ToLower() == "quit")
            //            break;

            //        numbers.Add(Convert.ToInt32(input));
            //    }

            //    //var uniques = GetUniqueNumbers(numbers);



            //    Console.WriteLine("Unique number: ");
            //    foreach (var number in GetUniqueNumbers(numbers))
            //        Console.WriteLine(number);

            //    Console.ReadKey();

            //}

            //public static List<int> GetUniqueNumbers(List<int> numbers)
            //{

            //    var uniques = new List<int>();
            //    foreach (var number in numbers)
            //    {
            //        if (!uniques.Contains(number))
            //            uniques.Add(number);             
            //    }
            //    return uniques;
            //}


            //https://www.udemy.com/csharp-tutorial-for-beginners/learn/v4/t/lecture/2158920?start=0
            static void Main(string[] args)
            {

                var path = @"c:\somefile.jpg";

                //static methods, ok for small number of operations, it security checks each item.
                File.Copy(@"c:\temp\myfile.jpg", "d:\temp\myfile/jpg", true);
                File.Delete(path);
                if (File.Exists(path))
                {
                    //
                }

              var content =   File.ReadAllText(path);


                //Instances which security checks obeject once, then can make multipe changes to it.....
                var fileInfo = new FileInfo(path);
                fileInfo.CopyTo("....");

                fileInfo.Delete();
                
                if(fileInfo.Exists)
                {
                    ///
                }

                


            }























        }





    }
}


