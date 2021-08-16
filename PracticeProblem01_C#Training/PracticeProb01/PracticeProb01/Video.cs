using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeProb01
{
    /// <summary>
    /// Class Video derived from Class Publication
    /// </summary>
    class Video : Publication
    {
        public float Duration { get; set; }
        /// <summary>
        /// Constructor to Create the Video Object
        /// </summary>
        /// <param name="l_Title">Title</param>
        /// <param name="l_Price">Price</param>
        /// <param name="l_Duration">Duration</param>
        public Video(string l_Title, double l_Price, float l_Duration) : base(l_Title, l_Price)
        {
            Duration = l_Duration;
        }
        /// <summary>
        /// Overrided TO String Function o display Info of Video
        /// </summary>
        /// <returns>String of Details</returns>
        public override string ToString()
        {
            return (base.ToString() + "\nDuration : " + Duration + " mins");
        }
    }
}
