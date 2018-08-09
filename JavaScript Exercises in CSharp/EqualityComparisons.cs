using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//namespace JavaScript_Exercises_in_CSharp
//{

//    ////https://app.pluralsight.com/player?course=csharp-equality-comparisons&author=simon-robinson&name=csharp-equality-comparisons-m2-dotnet&clip=1&mode=live


//    class EqualityComparisons
//    {
//        //static void Main(string[] args)
//        //{
//        //    Food banana = new Food("banana");
//        //    Food banana2 = new Food("banana");
//        //    Food chocolate = new Food("chocolate");


//        //    //virtual bool Equals()
//        //    Console.WriteLine("virtual Equals");
//        //    Console.WriteLine(banana.Equals(chocolate)); //false
//        //    Console.WriteLine(banana.Equals(banana2)); //false
//        //    Console.WriteLine(banana.Equals(null)); //false  null is not the same a a non-null instance


//        //    //StaticEquals() or static bool Equals() shown below
//        //https://app.pluralsight.com/player?course=csharp-equality-comparisons&author=simon-robinson&name=csharp-equality-comparisons-m2-dotnet&clip=5&mode=live
//        //    Console.WriteLine("Static Equals");
//        //    Console.WriteLine(object.Equals(banana, null)); //false
//        //    Console.WriteLine(object.Equals(null, banana));//false
//        //    Console.WriteLine(object.Equals(null, null)); //true
//        //    //this StaticEquals() checks for nulls first then gives same results as virtual method

//        //    //essentially code below are the steps StaticEquals() takes to evaluate
//        //    //public static bool Equals(object obj1, object obj2)
//        //    //{
//        //    //    if (obj1 == obj2)
//        //    //        return true;
//        //    //    if (obj1 == null || obj2 == null)
//        //    //        return false;
//        //    //    else
//        //    //        return obj1.Equals(obj2);
//        //    //}



//        //    string banana3 = "banana3";
//        //    string banana4 = string.Copy(banana3);

//        //    Console.WriteLine(banana3.Equals(banana4)); //true


//        //    //reference Equals() method
//        //    Console.WriteLine("Reference Equals");
//        //    Console.WriteLine(banana3);
//        //    Console.WriteLine(ReferenceEquals(banana3, banana4)); //false since banana 3 and 4 are different references
//        //    Console.WriteLine(banana3.Equals((object)banana4)); //true since comparing values

//        //    //statis methods are never overridable. So ReferenceEquals() behavior cannot be changed!




//        //    // IEquatable<T> useful for value type comparisons, not good for reference types, not good for inheritence

//        //https://app.pluralsight.com/player?course=csharp-equality-comparisons&author=simon-robinson&name=csharp-equality-comparisons-m2-dotnet&clip=8&mode=live
//        //    int three = 3;
//        //    int threeAgain = 3;
//        //    int four = 4;

//        //    Console.WriteLine("IEquatable");
//        //    Console.WriteLine(three.Equals(threeAgain)); //true
//        //    Console.WriteLine(three.Equals(four)); //false


//        //    Console.ReadLine();






//        ////public override bool Equals(object obj)
//        ////{
//        ////    return base.Equals(obj);
//        ////}


//        //static void Main(string[] args)
//        //{
//        //    Foodstuff banana = new Foodstuff("banana");
//        //    Foodstuff banana2 = new Foodstuff("banana");
//        //    Foodstuff chocolate = new Foodstuff("chocolate");



//        //    Console.WriteLine(banana.Equals(chocolate)); //false
//        //    Console.WriteLine(banana.Equals(banana2)); //true ---- get true much like we would expect when comparing values and not the object references! System.ValueType.Equals() uses reflection, performance is bad. not best choice!

//        // Console.ReadLine();
//        //}






//        // looking at difference between == and .Equal() method

//        //https://app.pluralsight.com/player?course=csharp-equality-comparisons&author=simon-robinson&name=csharp-equality-comparisons-m3-equality-op&clip=1&mode=live

//        static void Main(string[] args)
//        {
//            // https://www.udemy.com/csharp-tutorial-for-beginners/learn/v4/t/lecture/2168744?start=0
//            byte number = 2; // can replace byte, int, float etc. with 'var'
//            int count = 10;
//            float totalPrice = 20.95f;
//            char character = 'A';
//            string myName = "Cliff";
//            bool isWorking = true;


//            const float Pi = 3.14f; //use constants if you don't want a value changed!!!! 
//            //Pi = 1; // can't be changed it is immutable!

//            byte b = 1; // 00000001  // binary representation
//            int i = b; //00000000 00000000 00000000 00000001
//            Console.WriteLine(i);

//            int integer = 1;
//            byte byteVar = (byte)integer;  // wont' compile because doesn't have the memory for integer, so we add "(byte) in front of integer!!!!

//            int i5 = 1;
//            byte b5 = (byte)i5; // we cast integer into a byte with "(byte)"

//            //now try i6 =1000

//            int i6 = 1000;
//            byte b6 = (byte)i6;
//            Console.WriteLine(b6); // console writes 232, not "1000" so we lost some information!!! max storage in byte is 255!!! some of the buts were lost!!!!

//            var number1 = "1234";
//            //int i7 = (int) number; //cannot cast expression of type 'string' to 'int'
//            int i8 = Convert.ToInt32(number1);
//            Console.WriteLine(i8);


//            try
//            {
//                var number2 = "1234";
//                //int i7 = (int) number; //cannot cast expression of type 'string' to 'int'
//                int byte2 = Convert.ToByte(number2); //this breaks because we don't have enough memory for variable in the byte2
//                Console.WriteLine(byte2);


//                string str9 = "true";
//                bool b3 = Convert.ToBoolean(str9); //have to use Convert to go from string to bool because they are not equal types
//                Console.WriteLine(b3);


//            }
//            catch (Exception e)
//            {
//                Console.WriteLine(e);
              
//            }




//            string s = "1";
//            //int i1 = (int)s; // won't compile, we can't convert!!


//            string s1 = "1";  // converting string to integer
//            int i2 = Convert.ToInt32(s1);
//            int j = int.Parse(s1);


//            Console.WriteLine(number);
//            Console.WriteLine(count);
//            Console.WriteLine(totalPrice);
//            Console.WriteLine(character);
//            Console.WriteLine(myName);
//            Console.WriteLine(isWorking);
//            Console.WriteLine(); //shortcut type cw then tab key

//            Button button1 = new Button();
//            button1.Text = "Click me now!";

//            Button button2 = new Button();
//            button2.Text = "Click me now!";

//            Console.WriteLine("Operator: " + AreIntsEqualOp(3, 3));
//            Console.WriteLine("Method: " + AreIntsEqualMethod(3, 3));

//            Console.WriteLine(button1 == button2);
//            Console.WriteLine("Operator: " + AreButtonsEqualOp(button1, button2));
//            Console.WriteLine("Method: " + AreButtonsEqualMethod(button1, button2));

//            string str1 = "Click me now!";
//            string str2 = string.Copy((str1));

//            Console.WriteLine("Reference string: " + ReferenceEquals(str1, str2));
//            Console.WriteLine("Operator string: " + AreStringsEqualOp(str1, str2));
//            Console.WriteLine("Method string: " + AreStringEqualMethod(str1, str2));


//            Console.ReadLine();
//        }

//        static bool AreIntsEqualOp(int x, int y)
//        {
//            return x == y;
//        }

//        static bool AreIntsEqualMethod(int x, int y)
//        {
//            return x.Equals(y);
//        }

//        static bool AreButtonsEqualOp(Button x, Button y)
//        {
//            return x == y;
//        }

//        static bool AreButtonsEqualMethod(Button x, Button y)
//        {
//            return x.Equals(y);
//        }


//        static bool AreStringsEqualOp(string x, string y)
//        {
//            return x == y;
//        }

//        static bool AreStringEqualMethod(string x, string y)
//        {
//            return x.Equals(y);
//        }


//    }
//}
