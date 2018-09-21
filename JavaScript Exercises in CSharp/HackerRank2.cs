using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JavaScript_Exercises_in_CSharp
{
    class HackerRank2
    {





        //https://www.hackerrank.com/challenges/30-inheritance/problem?h_r=email&unlock_token=de73302109da90d0a8876f3374038d2327892c3b&utm_campaign=30_days_of_code_continuous&utm_medium=email&utm_source=daily_reminder

        class Person
        {
            protected string firstName;
            protected string lastName;
            protected int id;

            public Person() { }
            public Person(string firstName, string lastName, int identification)
            {
                this.firstName = firstName;
                this.lastName = lastName;
                this.id = identification;
            }
            public void printPerson()
            {
                Console.WriteLine("Name: " + lastName + ", " + firstName + "\nID: " + id);
            }
        }

        class Student : Person
        {
            private int[] testScores;


         

            // Write your constructor here

                public Student(string fn, string ln, int id, int[] scores) : base(fn, ln, id)
            {
                testScores = scores;
            }

            //
            //  Method Name: Calculate
            //  Return: A character denoting the grade.
            public char Calculate()
            {
                int sum = 0;
                char ch = 'O';

                for (int i = 0; i < testScores.Length; i++)
                {
                    sum += testScores[i];
                }
                int total = sum / testScores.Length;

                if (total <= 100 && total >= 90)
                    ch = 'O';
                else if (total < 90 && total >= 80)
                    ch = 'E';
                else if (total < 80 && total >= 70)
                    ch = 'A';
                else if (total < 70 && total >= 55)
                    ch = 'P';
                else if (total < 55 && total >= 40)
                    ch = 'D';
                else if (total < 40)
                    ch = 'T';
                return ch;


            }

            //
            // Write your method here
        }

        class Solution
        {
            static void Main()
            {
                string[] inputs = Console.ReadLine().Split();
                string firstName = inputs[0];
                string lastName = inputs[1];
                int id = Convert.ToInt32(inputs[2]);
                int numScores = Convert.ToInt32(Console.ReadLine());
                inputs = Console.ReadLine().Split();
                int[] scores = new int[numScores];
                for (int i = 0; i < numScores; i++)
                {
                    scores[i] = Convert.ToInt32(inputs[i]);
                }

                Student s = new Student(firstName, lastName, id, scores);
                s.printPerson();
                Console.WriteLine("Grade: " + s.Calculate() + "\n");

                Console.ReadKey();
            }
        }





        ////https://www.hackerrank.com/challenges/30-abstract-classes/problem?h_r=email&unlock_token=a4266035162cfd18d5f3fa778a5f601f5c4f11ed&utm_campaign=30_days_of_code_continuous&utm_medium=email&utm_source=daily_reminder

        //abstract class Book
        //{

        //    protected String title;
        //    protected String author;

        //    public Book(String t, String a)
        //    {
        //        title = t;
        //        author = a;
        //    }
        //    public abstract void display();






        //}

        //class MyBook : Book
        //{
        //    private int price = 0;

        //    public MyBook(String title, String author, int price) : base(title, author)
        //    {
        //        this.price = price;
        //    }

        //    public override void display()
        //    {
        //        Console.WriteLine("Title: {0} \nAuthor: {1} \nPrice: {2}", title, author, price);


        //        Console.ReadKey();

        //    }
        //}



        //class Solution
        //{
        //    static void Main(String[] args)
        //    {
        //        String title = Console.ReadLine();
        //        String author = Console.ReadLine();
        //        int price = Int32.Parse(Console.ReadLine());
        //        Book new_novel = new MyBook(title, author, price);
        //        new_novel.display();
        //    }
        //}

















    }
}
