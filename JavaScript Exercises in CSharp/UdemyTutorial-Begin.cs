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

            static void Main(string[] args)
            {


                //Console.WriteLine("Enter number from 1 to 10");

                //int number;
                //number = Convert.ToInt32(Console.ReadLine());
                //if (number >=1  && number <= 10)
                //{
                //    Console.WriteLine("Number is valid");
                //}
                //else 
                //        {
                //    Console.WriteLine("Invalid number entered");
                //}
                //Console.ReadKey();






                //int number1, number2;
                //Console.WriteLine("Enter first number");
                //number1 = Convert.ToInt32(Console.ReadLine());

                //Console.WriteLine("Enter second number");
                //number2 = Convert.ToInt32(Console.ReadLine());

                //if (number1 > number2)
                //{
                //    Console.WriteLine(number1 + " is greater!");
                //    Console.ReadKey();
                //}
                //else if (number2 > number1)
                //{
                //    Console.WriteLine(number2 + " is greater!");
                //    Console.ReadKey();
                //}
                //else
                //{
                //    Console.WriteLine("Numbers are equal or null!");
                //    Console.ReadKey();
                //}







                //int number1, number2;
                //Console.WriteLine("Enter width");
                //number1 = Convert.ToInt32(Console.ReadLine());

                //Console.WriteLine("Enter height");
                //number2 = Convert.ToInt32(Console.ReadLine());

                //if (number1 > number2)
                //{
                //    Console.WriteLine("Picture is landscape");
                //    Console.ReadKey();
                //}
                //else if (number2 > number1)
                //{
                //    Console.WriteLine(" picture is portrait");
                //    Console.ReadKey();
                //}
                //else
                //{
                //    Console.WriteLine("Picture is square or null!");
                //    Console.ReadKey();
                //}





                //int speedLimit, carSpeed, demerit;

                //Console.WriteLine("enter speed limit");
                //speedLimit = Convert.ToInt32(Console.ReadLine());

                //Console.WriteLine("Enter car speed");

                //carSpeed = Convert.ToInt32(Console.ReadLine());

                //if (carSpeed <= speedLimit)
                //{
                //    Console.WriteLine("Car speed does not exceed speed limit.");
                //    Console.ReadKey();
                //}
                //else if (carSpeed > speedLimit && ((carSpeed-speedLimit)/5 <= 12))
                //{

                //    demerit = (carSpeed - speedLimit) / 5;
                //    Console.WriteLine("Car speed exceeds speed limit." + demerit + " demerits have been issued to driver!");
                //    Console.ReadKey();
                //}
                //else if (carSpeed > speedLimit && ((carSpeed - speedLimit) / 5 > 12))
                //{
                //    Console.WriteLine("License Suspended!");
                //    Console.ReadKey();
                //}
                //else
                //{
                //    Console.WriteLine("inputs are negative or null, re-enter input");
                //    Console.ReadKey();
                //}











            }

        }





    }
}
