using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JavaScript_Exercises_in_CSharp
{

    ////https://app.pluralsight.com/player?course=csharp-equality-comparisons&author=simon-robinson&name=csharp-equality-comparisons-m2-dotnet&clip=1&mode=live


    class EqualityComparisons
    {
        //static void Main(string[] args)
        //{
        //    Food banana = new Food("banana");
        //    Food banana2 = new Food("banana");
        //    Food chocolate = new Food("chocolate");


        //    //virtual bool Equals()
        //    Console.WriteLine("virtual Equals");
        //    Console.WriteLine(banana.Equals(chocolate)); //false
        //    Console.WriteLine(banana.Equals(banana2)); //false
        //    Console.WriteLine(banana.Equals(null)); //false  null is not the same a a non-null instance


        //    //StaticEquals() or static bool Equals() shown below
        //https://app.pluralsight.com/player?course=csharp-equality-comparisons&author=simon-robinson&name=csharp-equality-comparisons-m2-dotnet&clip=5&mode=live
        //    Console.WriteLine("Static Equals");
        //    Console.WriteLine(object.Equals(banana, null)); //false
        //    Console.WriteLine(object.Equals(null, banana));//false
        //    Console.WriteLine(object.Equals(null, null)); //true
        //    //this StaticEquals() checks for nulls first then gives same results as virtual method

        //    //essentially code below are the steps StaticEquals() takes to evaluate
        //    //public static bool Equals(object obj1, object obj2)
        //    //{
        //    //    if (obj1 == obj2)
        //    //        return true;
        //    //    if (obj1 == null || obj2 == null)
        //    //        return false;
        //    //    else
        //    //        return obj1.Equals(obj2);
        //    //}



        //    string banana3 = "banana3";
        //    string banana4 = string.Copy(banana3);

        //    Console.WriteLine(banana3.Equals(banana4)); //true


        //    //reference Equals() method
        //    Console.WriteLine("Reference Equals");
        //    Console.WriteLine(banana3);
        //    Console.WriteLine(ReferenceEquals(banana3, banana4)); //false since banana 3 and 4 are different references
        //    Console.WriteLine(banana3.Equals((object)banana4)); //true since comparing values

        //    //statis methods are never overridable. So ReferenceEquals() behavior cannot be changed!




        //    // IEquatable<T> useful for value type comparisons, not good for reference types, not good for inheritence

        //https://app.pluralsight.com/player?course=csharp-equality-comparisons&author=simon-robinson&name=csharp-equality-comparisons-m2-dotnet&clip=8&mode=live
        //    int three = 3;
        //    int threeAgain = 3;
        //    int four = 4;

        //    Console.WriteLine("IEquatable");
        //    Console.WriteLine(three.Equals(threeAgain)); //true
        //    Console.WriteLine(three.Equals(four)); //false


        //    Console.ReadLine();






        ////public override bool Equals(object obj)
        ////{
        ////    return base.Equals(obj);
        ////}


        //static void Main(string[] args)
        //{
        //    Foodstuff banana = new Foodstuff("banana");
        //    Foodstuff banana2 = new Foodstuff("banana");
        //    Foodstuff chocolate = new Foodstuff("chocolate");



        //    Console.WriteLine(banana.Equals(chocolate)); //false
        //    Console.WriteLine(banana.Equals(banana2)); //true ---- get true much like we would expect when comparing values and not the object references! System.ValueType.Equals() uses reflection, performance is bad. not best choice!

        // Console.ReadLine();
        //}






        // looking at difference between == and .Equal() method

        //https://app.pluralsight.com/player?course=csharp-equality-comparisons&author=simon-robinson&name=csharp-equality-comparisons-m3-equality-op&clip=1&mode=live

        static void Main(string[] args)
        {
            Console.WriteLine("Operator: " + AreIntsEqualOp(3, 3));
            Console.WriteLine("Method: " + AreIntsEqualMethod(3, 3));
            Console.ReadLine();
        }

                static bool AreIntsEqualOp(int x, int y)
            {
                return x == y;
            }

            static bool AreIntsEqualMethod(int x, int y)
            {
                return x.Equals(y);
            }



           

        

    }
}
