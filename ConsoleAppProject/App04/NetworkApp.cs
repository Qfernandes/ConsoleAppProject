using System;
using System.Collections.Generic;
namespace ConsoleAppProject.App04
{
    public class NetworkApp
    {
        private NewsFeed news = new NewsFeed();
        public void DisplayMenu()
        {
            Console.WriteLine("Which of the following features would you like to use: ");
            Console.WriteLine("1. Post an Image");
            Console.WriteLine("2. Post an Message");
            Console.WriteLine("3. Add Comment");
            Console.WriteLine("4. Like Posts ");
            Console.WriteLine("5. Remove an Post");
            Console.WriteLine("6. Display All Posts");
  

            int choice = Convert.ToInt32(Console.ReadLine());
            
            //added choices, if 1 is pressed, Imperial unit method will run, if 2 is pressed, Metric unit method will run.
            if (choice == 1)
            {
                PostImage();

            }

            if (choice == 2)
            {
                PostMessage();
            }
            
            if (choice == 3)
            {
                DisplayAll();
            }
        }
        public void DisplayAll()
        {
           news.Display(); 
        }
        public void PostMessage()
        {
            Console.WriteLine("Post your Message here ");

            string author = InputName();

            Console.WriteLine("Post your Message here ");
            string message = Console.ReadLine();

            MessagePost post = new MessagePost(author, message);
            news.AddMessagePost(post);

            Console.WriteLine("You have successfully posed an message ");
            post.Display();

        }
        public void PostImage()
        {
            Console.WriteLine("Post your Image here ");

            string author = InputName();

            Console.WriteLine("File Name of your Post ");
            string filename = Console.ReadLine();

            Console.WriteLine("Your Image Caption ");
            string caption = Console.ReadLine();

            PhotoPost post = new PhotoPost(author, filename, caption);
            news.AddPhotoPost(post);

            Console.WriteLine("Your Post has been successfully posted ");
            post.Display();

        }
        public string InputName()
        {
            Console.WriteLine("Please enter your name:  ");
            string author = Console.ReadLine();

            return author;
        }
    }
}