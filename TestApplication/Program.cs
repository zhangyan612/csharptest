using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Tutorial.run();

            //Tutorial tuo = new Tutorial();
            //tuo.run2();
            
            // we want to build a program to print out artworks
            // method to print name is Console.WriteLine();


            // Create a string variable called paintingName and give it value "Autum Hug", create int of Length and double of Weight, print out all info

            //string paintingname = "Autum Hug";
            //int Lenght = 23;
            //double Weight = 120.0;

            //string newString = " This painting is called: " + paintingname + " Its Lenght is: " + Lenght + " and it weights " + Weight;
            //Console.WriteLine(newString);

            //// Create another artworks and print out
            //string paintingname1 = "Paradise";
            //int lenght1 = 43;
            //double weight1 = 200.0;
            //string newString1 = "This painting is called: " + paintingname1 + " Its Lenght: " + lenght1 + " and it weight: " + weight1;

            //Console.WriteLine(newString1);

            //// create list of paintings called artworkList and add some paintings in it

            //List<string> PaintingList = new List<string>();

            //PaintingList.Add(paintingname);
            //PaintingList.Add(paintingname1);
            //PaintingList.Add(paintingname);
            //PaintingList.Add(paintingname1);
            //PaintingList.Add(paintingname);


            //// loop and print out all paintingName in the list

            //foreach (var i in PaintingList)
            //{
            //    Console.WriteLine(i);
            //}


            //// create Artwork class and initialize two object and assign it some value 

            //Artworks paintingname3 = new Artworks();

            //paintingname3.name = "Self portrait";
            //paintingname3.Lenght = 35;
            //paintingname3.Weight = 104.0;

            //Artworks paintingname4 = new Artworks();

            //paintingname4.name = "Ballet";
            //paintingname4.Lenght = 58;
            //paintingname4.Weight = 45.0;


            ////creat a list of Artwork and add those two Artwork object inside the list

            //List<Artworks> paintinggroup = new List<Artworks>();

            //paintinggroup.Add(paintingname3);
            //paintinggroup.Add(paintingname4);

            //// loop the Artwork list to print out all Artwork info
            //foreach (var pai in paintinggroup)
            //{
            //    string everything = "This Painting is " + pai.name + " Its lenght is: " + pai.Lenght + " Its weight is: " + pai.Weight;
            //    Console.WriteLine(everything);
            //}


            //// now we need to print out individual Artwork info
            //// create a method PrintInfo and execute the method to print out Artwork info

            //paintingname4.PrintInfo("River Peace", 64, 23);
            //paintingname4.PrintInfo("Vincent Van Gogh", 56, 76);


            //// create another method to combine two artwork and print out it's total Weight
            //paintingname4.printbest("Vincent Van Gogh", "River Peace");

            //// create another method and return the length plus 5, then loop this value in a list to print out
            //foreach (var pai in paintinggroup)
            //{
            //    string text = pai.isAFamousPainting(pai.name);
            //    int newLength = pai.Lenghtaddaddision(pai.Lenght);

            //    Console.WriteLine(text);
            //    Console.WriteLine(newLength);

            //}

            Console.ReadKey();
        }
    }



    class Artworks
    {
        public string name { get; set; }
        public int Lenght { get; set; }
        public double Weight { get; set; }


        public void PrintInfo(string name, int age, double grade)
        {
            string info = " This painting is called: " + name + " Its Lenght is: " + age + " and it weights " + grade;

            Console.WriteLine(info);
        }


        public void printbest(string name, string name2)
        {
            string info = name + " Was painted with oil paint, just like the painting " + name2;

            Console.WriteLine(info);
        }

        public string isAFamousPainting(string name)
        {
            string info = name + " is a famous painting";
            return info;
        }

        public int Lenghtaddaddision(int name)
        {
            int info = name * 8;
            return info;
        }
    }
}