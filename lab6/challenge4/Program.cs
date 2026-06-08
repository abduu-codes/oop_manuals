using System;

namespace challenge4

{
    class Program
    {
        static void Main(string[] args)
        {
 
            User user1 = new User("JohnDoe");

            Post p1 = new Post("Hello World! This is my first post.");
            user1.myPosts.Add(p1);

            Comment c1 = new Comment(); 
            c1.text = "Great post!";
            c1.commenter = "JaneSmith" ;
            p1.comments.Add(c1);

            Like l1 = new Like();
                l1.userName = "JaneSmith" ;
            p1.likes.Add(l1);

            Console.WriteLine($"User: {user1.username}");
            foreach (var post in user1.myPosts)
            {
                Console.WriteLine($" Post: {post.content}");
                Console.WriteLine($" Likes: {post.likes.Count}");
                foreach (var comment in post.comments)
                {
                    Console.WriteLine($"  Comment by {comment.commenter}: {comment.text}");
                }
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}