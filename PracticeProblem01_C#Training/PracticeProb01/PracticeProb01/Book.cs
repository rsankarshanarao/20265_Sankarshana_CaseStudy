using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeProb01
{
    /// <summary>
    /// Class Book Derived from Class Publication
    /// </summary>
    class Book : Publication
    {
        string Author;
        public double PageCount { get; set; }
        /// <summary>
        /// Constructor to create Book Object
        /// </summary>
        /// <param name="l_Title">Title</param>
        /// <param name="l_Price">Price</param>
        /// <param name="l_Author">Author</param>
        /// <param name="l_PageCount">PageCount</param>
        public Book(string l_Title, double l_Price, string l_Author, double l_PageCount) : base(l_Title, l_Price)
        {
            Author = l_Author;
            PageCount = l_PageCount;
        }
        /// <summary>
        /// Overrided Method to get Details of Book
        /// </summary>
        /// <returns>String of Details of Book</returns>
        public override string ToString()
        {
            return (base.ToString() + "\n" +
                "Author : " + Author + "\n" +
                "Number of Pages : " + PageCount + "\n");
        }
        /// <summary>
        /// Method to Get Author of Book
        /// </summary>
        /// <returns>Author Name as String</returns>
        public string getAuthor()
        {
            return Author;
        }
    }
}
