using System;
using System.Collections.Generic;
namespace ConsoleAppProject.App04
{
        /// <summary>
        /// Refactored To Post Class
        /// </summary>
    public class Post
    {
        /// <summary>
        /// Declared variables and lists
        /// </summary>
        public int PostId;
        private static int instances = 0;
        private int postlikes;
        private readonly List<String>comments;
        
        // username of the post's author
        public String Username;
        public DateTime Timestamp;

        /// <summary>
        /// Created a Post method and added author to initialise the message, post
        /// </summary>

        public Post(string author)
        {
            instances++;
            PostId = instances;
            
            this.Username = author;
            Timestamp = DateTime.Now;

            postlikes = 0;
            comments = new List<String>();
        }

        /// <summary>
        /// Created a Like Post method and Unlike post, it will indicate the number of likes
        /// </summary>
        public void LikePosts()
        {
            postlikes++;
        }

        ///<summary>
        /// If an user unliked the post, it will decrement and will indicate the user unliked the post
        ///</summary>
        public void UnlikePosts()
        {
            if (postlikes > 0)
            {
                postlikes--;
            }
        }
        
        ///<summary>
        /// This method for adding comment to the post
        /// </summary>
        /// <param name="text">
        /// </param>        
        public void AddComment(String text)
        {
            comments.Add(text);
        }

        ///<summary>
        /// As there are 3 Displays in Message Post, Post and PhotPost, I've used Polymorphorism and created virtual for Post.
        /// Here displays the post details.
       
        ///</summary>
        
        public virtual void Display()
        {
            Console.WriteLine();
            Console.WriteLine($"    Author: {Username}");
            Console.WriteLine($"    Time Elpased: {FormatElapsedTime(Timestamp)}");
            Console.WriteLine();

            if (postlikes > 0)
            {
                Console.WriteLine($"    The number of people liked this is :  {postlikes}.");
            }
            else
            {
                Console.WriteLine();
            }

            if (comments.Count == 0)
            {
                Console.WriteLine("    No comments.");
            }
            else
            {
                Console.WriteLine($"    {comments.Count}  comment(s)");
            }
        }

        ///<summary>
        /// Here shows the minutes and seconds of the time the message, post posted 
        /// </summary>
        /// <param name="time">
        ///  The time value to convert (in system milliseconds)
        /// </param> 
        /// <returns>
        /// A relative time string for the given time
        /// </returns>      
        private String FormatElapsedTime(DateTime time)
        {
            DateTime current = DateTime.Now;
            TimeSpan timePast = current - time; 

            long seconds = (long)timePast.TotalSeconds;
            long minutes = seconds / 60;
            
            if (minutes > 0)
            {
                return minutes + " minutes ago";
            }
            else
            {
                return seconds + " seconds ago";
            }
        }
    
    }
}