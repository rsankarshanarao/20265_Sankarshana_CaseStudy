using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeProb01
{
    /// <summary>
    /// Class Publication
    /// </summary>
    class Publication
    {
        string Title;
        public double Price { get; set; }

        /// <summary>
        /// Constructor to create a Publication Object
        /// </summary>
        /// <param name="l_Title">Title</param>
        /// <param name="l_Price">Price</param>
        public Publication(string l_Title, double l_Price)
        {
            Title = l_Title;
            Price = l_Price;
        }

        /// <summary>
        /// Overrided Method to get Detaisl of Object
        /// </summary>
        /// <returns>String of Details</returns>
        public override string ToString()
        {
            return ("The Title : " + Title + "\n" + "Price : " + Price);
        }

        /// <summary>
        /// Method to get title of Publication
        /// </summary>
        /// <returns>Title as String</returns>
        public string getTitle()
        {
            return (Title);
        }
    }
}
