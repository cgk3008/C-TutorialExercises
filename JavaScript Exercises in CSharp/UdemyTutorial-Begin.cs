using System;
using System.Collections.Generic;
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






            
//1- Write a program to count how many numbers between 1 and 100 are divisible by 3 with no remainder.Display the count on the console.



//2- Write a program and continuously ask the user to enter a number or "ok" to exit. Calculate the sum of all the previously entered numbers and display it on the console.



//3- Write a program and ask the user to enter a number.Compute the factorial of the number and print it on the console. For example, if the user enters 5, the program should calculate 5 x 4 x 3 x 2 x 1 and display it as 5! = 120.



//4- Write a program that picks a random number between 1 and 10. Give the user 4 chances to guess the number.If the user guesses the number, display “You won"; otherwise, display “You lost". (To make sure the program is behaving correctly, you can display the secret number on the console first.)



//5- Write a program and ask the user to enter a series of numbers separated by comma.Find the maximum of the numbers and display it on the console.For example, if the user enters “5, 3, 8, 1, 4", the program should display 8.





        }





    }
}
