using System;
using System.Collections.Generic;

public class Comment
{
    public User Author { get; private set; }
    public string Content { get; private set; }
    public List<User> Likes { get; private set; }

    public Comment(User author, string content)
    {
        Author = author;
        Content = content;
        Likes = new List<User>();
    }

    public void AddLike(User user)
    {
        if (Likes.Contains(user))
        {
            Console.WriteLine(" You already liked this comment.");
            return;
        }

        Likes.Add(user);
    }
}
