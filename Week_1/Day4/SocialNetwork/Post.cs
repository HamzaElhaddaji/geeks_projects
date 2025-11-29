using System;
using System.Collections.Generic;

public class Post
{
    public User Author { get; private set; }
    public string Content { get; private set; }
    public List<Comment> Comments { get; private set; }
    public List<User> Likes { get; private set; }
    public DateTime CreatedAt { get; private set; }

    public Post(User author, string content)
    {
        Author = author;
        Content = content;
        Comments = new List<Comment>();
        Likes = new List<User>();
        CreatedAt = DateTime.Now;
    }

    public void AddComment(Comment comment)
    {
        Comments.Add(comment);
    }

    public void AddLike(User user)
    {
        if (Likes.Contains(user))
        {
            Console.WriteLine(" You already liked this post.");
            return;
        }

        Likes.Add(user);
    }
}
