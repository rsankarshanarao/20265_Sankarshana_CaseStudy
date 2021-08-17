using System;

namespace CSharp_PracticalTest
{
    class UsingPeople
    {
        static void Main() //Main Driver Program
        {
            Console.WriteLine("Creating a TechnicalEmployee....\n");
            TechnicalEmployee t = new TechnicalEmployee("20265", "Sankarshana", 
                "Bangalore, Karnataka", 20000, 
                new string[] {"c", "c++", "java"}); //Calling Constructor to create Technical Employee Object

            Console.WriteLine("Created a TechnicalEmployee and Details are: \n");
            Console.WriteLine(t.ToString() + 
                "and Salary is " + t.CalculateSalary()); // Calling the Overrided ToString Method and CalculateSalaryMethod

            Console.WriteLine("\n\nCreating a TechnicalEmployee.... with No Skills\n");
            TechnicalEmployee t1 = new TechnicalEmployee("20265", "New Employee",
                "Bangalore, Karnataka", 21000,
                new string[] { }); //Calling Constructor to create Technical Employee Object

            Console.WriteLine("Created a TechnicalEmployee and Details are: \n");
            Console.WriteLine(t1.ToString() +
                "and Salary is " + t1.CalculateSalary()); // Calling the Overrided ToString Method and CalculateSalaryMethod

            Console.WriteLine("\n\nCreating a StaffMember....\n");
            StaffMember s = new StaffMember("01A21", "ABC",
                "Hyderabad, Telagana", 10000, 
                new string[] { "House Keeping", "Security" }); //Calling Constructor to create Staff Member Object

            Console.WriteLine("Created a StaffMember and Details are: \n");
            Console.WriteLine(s.ToString() + 
                "and Salary is " + s.CalculateSalary()); // Calling the Overrided ToString Method and CalculateSalaryMethod

            Console.WriteLine("\n\nCreating a StaffMember with 0 basic pay....\n");
            StaffMember s1 = new StaffMember("01A210", "ABC1",
                "Hyderabad, Telagana", 0,
                new string[] { "Hose Keeping", "Security" }); //Calling Constructor to create Staff Member Object

            Console.WriteLine("Created a StaffMember and Details are: \n");
            Console.WriteLine(s1.ToString() +
                " and Salary is " + s1.CalculateSalary()); // Calling the Overrided ToString Method and CalculateSalaryMethod
        }
    }
}
