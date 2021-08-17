using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_PracticalTest
{
    /// <summary>
    /// Class Staff Member Derived from Base Class Employee
    /// </summary>
    class StaffMember : Employee
    {
        string[] Title;

        /// <summary>
        /// Constructor of Derived Class StaffMember
        /// </summary>
        /// <param name="ID">Employee ID</param>
        /// <param name="Name">Name</param>
        /// <param name="Add">Address</param>
        /// <param name="Pay">Pay</param>
        /// <param name="In_Title">Work Titles</param>
        public StaffMember(string ID, string Name, string Add, double Pay, string[] In_Title) : base(ID, Name, Add, Pay)
        {
            Title = In_Title;
        }

        /// <summary>
        /// Overrided Method to Calculate Salary.
        /// </summary>
        /// <returns>Salary Including HRA as Double</returns>
        public override double CalculateSalary()
        {
            return (base.BasicPay + 0.18 * base.BasicPay); //Salary = Basic Pay + HRA
        }

        public override string ToString()
        {
            return ("Employee ID is " + EmployeeID + " and Name is " + EmployeeName + GetTitles());
        }

        string GetTitles()
        {
            if (Title.Length == 0)
            {
                return " Has Not been assigned to any title ";
            }
            else
            {
                return (" Has been assigned as " + string.Join(",", Title) + " ");
            }
        }

    }
}
