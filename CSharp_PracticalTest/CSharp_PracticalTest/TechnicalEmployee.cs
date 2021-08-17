using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_PracticalTest
{
    /// <summary>
    /// Class Technical Employee derived from Base Class Employee
    /// </summary>
    class TechnicalEmployee : Employee
    {
        string[] TechnicalSkills; // Many skills can be stored as an array of strings

        /// <summary>
        /// Constructor of Derived class TechnicalEmployee
        /// </summary>
        /// <param name="ID">Employee ID</param>
        /// <param name="Name">Name</param>
        /// <param name="Add">Address</param>
        /// <param name="Pay">Basic Pay</param>
        /// <param name="Skills">Technical Skills</param>
        public TechnicalEmployee(string ID, string Name, string Add, double Pay, string[] Skills) : base(ID, Name, Add, Pay)
        {
            TechnicalSkills = Skills;
        }

        /// <summary>
        /// Overrided abstract method to Calculate Salary of Employee
        /// </summary>
        /// <returns>Total salary including HRA as Double</returns>
        public override double CalculateSalary()
        {
            return (base.BasicPay + 0.12 * base.BasicPay);  //Salary = Basic Pay + HRA
        }

        public override string ToString()
        {
            return ("Employee ID is " + EmployeeID + " and Name is " + EmployeeName + GetSkills());
        }

        string GetSkills()
        {
            if(TechnicalSkills.Length == 0)
            {
                return " Has No Skills ";
            }
            else
            {
                return (" Has Skills " + string.Join(",", TechnicalSkills) + " ");
            }
        }

    }
}
