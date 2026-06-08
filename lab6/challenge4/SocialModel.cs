using System.Collections.Generic;

namespace challenge4
{
    public class Like 
    { public string userName; }

    public class Comment
    {
        public string text;
        public string commenter;
    }

    public class Post
    {
        public string content;
        public List<Comment> comments = new List<Comment>();
        public List<Like> likes = new List<Like>();

        public Post(string content) 
        { this.content = content; 
        }
    }

    public class User
    {
        public string username;
        public List<Post> myPosts = new List<Post>();

        public User(string name)
        { this.username = name;
        }
    }
}