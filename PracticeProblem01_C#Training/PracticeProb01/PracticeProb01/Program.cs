using System;

namespace PracticeProb01
{
    class Program
    {
        static void Main()
        {

            Console.WriteLine("Welcome to Publication Management!! \n");
            Console.WriteLine("Enter 1 to Add publication \n 2 to add publication and display it ");
            var in_type = int.Parse(Console.ReadLine());
            if(in_type == 0 || in_type > 2)
            {
                throw (new TypeException("Wrong Input. Restart the Program for Best Performance!!"));
            }

            Console.WriteLine("Choose the type of Publication to be added \n 1 for Book \n 2 for Video");
            var in_BorV = int.Parse(Console.ReadLine());
            if(in_BorV == 0 || in_BorV > 2)
            {
                throw (new TypeException("Entered type value is incorrect.Unable to Determine " +
                    "the type.Restart the Program for Best Performance!!"));
            }

            Console.WriteLine("Enter the Title : ");
            var Title = Console.ReadLine();
            Console.WriteLine("Enter the Price : ");
            var Price = Console.ReadLine();

            Publication pubObj = null;
            /*Book BObj = null;
            Video VObj = null*/
            ;

            if (in_BorV == 1)
            {
                Console.WriteLine("Enter the Author : ");
                var Author = Console.ReadLine();
                Console.WriteLine("Enter the Number of Pages : ");
                var Pages = Console.ReadLine();
                pubObj = new Book(Title, double.Parse(Price), Author, double.Parse(Pages));
                /*BObj = new Book(Title, double.Parse(Price), Author, double.Parse(Pages));*/
            }
            else
            {
                Console.WriteLine("Enter the Duration in Minutes only : ");
                var Duration = Console.ReadLine();
                pubObj = new Video(Title, double.Parse(Price), float.Parse(Duration));
                /*VObj = new Video(Title, double.Parse(Price), float.Parse(Duration));*/
            }
            if (in_type == 1)
            {
                Console.WriteLine("Object Added Successfully!!");
            }
            else
            {
                Console.WriteLine("Details of the added Object : \n" + pubObj.ToString());
                /*if(in_BorV == 1)
                {
                    Console.WriteLine("Details of the added Object : \n" + BObj.ToString());
                }
                else
                {
                    Console.WriteLine("Details of the added Object : \n" + VObj.ToString());
                }*/
            }

        }
    }
}
