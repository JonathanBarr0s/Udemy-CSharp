using System;
using RedeSocial.Entities;

namespace RedeSocial {
    internal class Program {
        static void Main(string[] args) {

            List<Post> posts = new List<Post>();

            do {
                Console.Write("Moment (dd/MM/yyyy HH:mm:ss): ");
                string moment = Console.ReadLine();

                Console.Write("Title: ");
                string title = Console.ReadLine();

                Console.Write("Content: ");
                string content = Console.ReadLine();

                Console.Write("Likes: ");
                int likes = int.Parse(Console.ReadLine());

                Console.WriteLine();

                Post post = new Post(DateTime.Parse(moment), title, content, likes);

                Console.Write("Number of comments: ");
                int numberOfComments = int.Parse(Console.ReadLine());

                Console.WriteLine();

                for (int i = 1; i <= numberOfComments; i++) {
                    Console.Write("Comment #{0}: ", i);
                    string comment = Console.ReadLine();
                    post.AddComment(comment);

                    Console.WriteLine();
                }

                posts.Add(post);

                Console.Write("Do you want to make another post (y/n)? ");

            } while (Console.ReadLine().ToLower() == "y");

            Console.WriteLine();

            foreach (var j in posts) {
                Console.WriteLine(j);
            }
        }
    }
}