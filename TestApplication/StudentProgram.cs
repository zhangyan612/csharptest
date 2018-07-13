using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApplication
{
    class StudentProgram
    {
        static void Run()
        {
            // we want to build a program to print out people's name
            // method to print name is Console.WriteLine();

            // create a string variable called name and give it value "Diana", create int of age and double of grade, print out all info
            string name = "Diana";
            int age = 15;
            double grade = 60.0;

            string newString = " My name is: " + name + " My age is: " + age + " My Grade is " + grade;
            Console.WriteLine(newString);

            // Create another person and print out
            string name1 = "Terry";
            int age1 = 18;
            double grade1 = 85.0;
            string newString1 = "My name is " + name1 + " My age is: " + age1 + " My Grade is: " + grade1;

            //Console.WriteLine(name1);
            //Console.WriteLine(age1);
            //Console.WriteLine(grade1);

            Console.WriteLine(newString1);


            // create list of string called StudentList and add some names in it
            List<string> StudentList = new List<string>();

            // add student to list
            StudentList.Add(name);
            StudentList.Add(name1);
            StudentList.Add(name1);
            StudentList.Add(name1);
            StudentList.Add(name1);
            StudentList.Add(name1);
            StudentList.Add(name1);
            StudentList.Add(name1);
            StudentList.Add(name1);
            StudentList.Add(name1);

            // loop and print out all names in the list
            foreach (var i in StudentList)
            {
                Console.WriteLine(i);
            }

            // create an object of student class and give it some value 
            Student student1 = new Student();

            student1.name = "Diana";
            student1.age = 15;
            student1.grade = 60.0;

            Student student2 = new Student();

            student2.name = "Terry";
            student2.age = 18;
            student2.grade = 85.0;


            //creat a list of student and add those two student object inside the list
            List<Student> Studentgroup = new List<Student>();

            // add student to list
            Studentgroup.Add(student1);
            Studentgroup.Add(student2);

            // loop the student group list to print out all student info
            foreach (var stu in Studentgroup)
            {
                string everything = "My name is " + stu.name + " My age is: " + stu.age + " My Grade is: " + stu.grade;
                Console.WriteLine(everything);
            }

            // now we need to print out individual student info
            // create a method PrintInfo and execute the method to print out student info
            student1.PrintInfo("Yan", 28, 100);
            student1.PrintInfo("Jack", 38, 10);

            // create another method to combine two input
            student1.printbest("Diana", "Yan");

            // create another method and return a value, then loop this value in a list
            foreach (var stu in Studentgroup)
            {
                string text = stu.isSuperCool(stu.name);
                Console.WriteLine(text);
            }



            Console.ReadKey();
        }
    }

    class Student
    {
        public string name { get; set; }
        public int age { get; set; }
        public double grade { get; set; }


        public void PrintInfo(string name, int age, double grade)
        {
            string info = "My name is " + name + " My age is: " + age + " My Grade is: " + grade;

            Console.WriteLine(info);
        }


        // create a method passing in people's name and print out "name  is the best"



        public void printbest(string name, string name2)
        {
            string info = name + " is in love with " + name2;

            Console.WriteLine(info);
        }

        public string isSuperCool(string name)
        {
            string info = name + " is super cool";
            return info;
        }


    }
}
