using System;

namespace ConsoleAppProject.App04
{
    ///<summary>
    /// This class stores information about a post in a social network. 
    /// The main part of the post consists of a photo and a caption. 
    /// Other data, such as author and time, are also stored.
    ///</summary>
    /// <author>
    /// Michael Kölling and David J. Barnes
    /// @version 0.1
    /// </author>

    ///<summary>
    /// I've inherited the Post so it can communicate and access the Post class
    /// This class is where the filename, caption, author and time is created.
    ///</summary>

    public class PhotoPost : Post
    {
        // declared the filename for the image file
        public String Filename;
        
        // declared the caption for displaying the caption
        
         public String Caption;  

        ///<summary>
        /// Constructor for objects of class PhotoPost.
        ///</summary>
        /// <param name="author">
        /// The username of the author of this post.
        /// </param>
        /// <param name="caption">
        /// A caption for the image.
        /// </param>
        /// <param name="filename">
        /// The filename of the image in this post.
        /// </param>
        public PhotoPost(String author, String filename, String caption):base(author)
        {
            this.Filename = filename;
            this.Caption = caption;
        }

        ///<summary>
        /// I've used Polymorphorism and created virtual for PhotPost for displaying filename, caption.
        ///</summary>
        public override void Display()
        {
            Console.WriteLine($"    Filename: [{Filename}]");
            Console.WriteLine($"    Caption: {Caption}");
            base.Display();
        }
    }
}
