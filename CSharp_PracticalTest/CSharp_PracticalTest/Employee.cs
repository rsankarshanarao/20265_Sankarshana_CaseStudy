using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_PracticalTest
{
    /// <summary>
    /// Abstract Class Employee
    /// </summary>
    abstract class Employee
    {
        public string EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public string Address { get; set; }
        protected double BasicPay { get; set; }

        /// <summary>
        /// Constructor of Base Class Employee
        /// </summary>
        /// <param name="ID">Employee ID</param>
        /// <param name="Name">Employee Name</param>
        /// <param name="Add">Employee Address</param>
        /// <param name="Pay">Basic Pay</param>
        public Employee(string ID, string Name, string Add, double Pay)
        {
            EmployeeID = ID;
            EmployeeName = Name;
            Address = Add;
            if(Pay > 0)
            {
                BasicPay = Pay;
            }
            else
            {
                throw (new CustomException("\nBasic Pay cannot be 0 or negative!! \nUnable to Create object...\n\n"));
            }
        }

        /// <summary>
        /// Abstract Class to Calculate Total salary includeing HRA
        /// </summary>
        /// <returns></returns>
        public abstract double CalculateSalary();

        /// <summary>
        /// Overrided Method to give details of Employee
        /// </summary>
        /// <returns>Employee ID and Name as a </returns>
        public override string ToString()
        {
            return ("Employee ID is " + EmployeeID + " and Name is " + EmployeeName);
        }
    }
}
